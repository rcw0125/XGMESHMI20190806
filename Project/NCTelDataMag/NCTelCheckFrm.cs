using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;
using EDoor.WinFormsUI.Docking;
using System.Reflection;
using System.Collections;


namespace NCTelDataMag
{
    public partial class NCTelCheckFrm : DockContent, IMESForm
    {
        public NCTelCheckFrm()
        {
            InitializeComponent();
            comboBox1.Text = "投料";
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion
    

        private void dvTel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRemark.Text = dvTel.CurrentRow.Cells[2].Value.ToString();
        }
        //发送电文
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dvTel.Rows.Count < 1)
            {
                return;
            }
            ////////////////////////////////////////投料电文
            if (comboBox1.Text.Trim() == "投料")
            {
                for (int i = 1; i <= dvTel.Rows.Count; i++)
                {
                    string strcell = dvTel.Rows[i - 1].Cells[2].Value.ToString();
                    string strheatid = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    string strtemp;
                    string element;

                    if (strcell.Contains("必须指定批次号，请调整"))
                    {
                        int j = strcell.IndexOf("存货：");
                        strtemp = strcell.Substring(j + 8,1);
                        if (strtemp == "《")
                        {
                           element = strcell.Substring(j + 3, 5);
                        }
                        else 
                        { 
                           element = strcell.Substring(j + 3, 6); 

                             }
                        addbatchid(strheatid, element);
                        dsMain.Tables[0].Clear();
                        dsMaterial.Tables[0].Clear();
                        cmdMain.Parameters[0].ConstantValue = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                        cmdMain.Execute();
                        send();
                        // MessageBox.Show(str);
                    }
                    //if (strcell.Contains("必须指定批次号，请调整"))
                    //{
                    //    int j = strcell.IndexOf("存货：");
                    //    string element = strcell.Substring(j + 3, 5);
                    //    addbatchid(strheatid, element);
                    //    dsMain.Tables[0].Clear();
                    //    dsMaterial.Tables[0].Clear();
                    //    cmdMain.Parameters[0].ConstantValue = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    //    cmdMain.Execute();
                    //    send();
                    //    // MessageBox.Show(str);
                    //}
                    else if (strcell.Contains("不能重复提交单据!"))
                    {

                    }
                    else if (strcell.Contains("备料计划已经发生出库业务，不能继续"))
                    {

                    }
                    else
                    {
                        dsMain.Tables[0].Clear();
                        dsMaterial.Tables[0].Clear();
                        cmdMain.Parameters[0].ConstantValue = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                        cmdMain.Execute();
                        send();

                    }



                }
                LoadData();
            }
            else if (comboBox1.Text.Trim() == "订单")
            {
                string sql;
                for (int i = 1; i <= dvTel.Rows.Count; i++)
                {
                    string strcell = dvTel.Rows[i - 1].Cells[2].Value.ToString();
                    string strheatid = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    if (strcell.Contains("不能重复提交单据!"))
                    {

                    }
                    else
                    {
                         sql = "update cccm_base_data set nc_confirm_flag=0 where heatid='" + strheatid + "'";
                         Save(sql);
                    }          
                }

                object Obj = new object();
                string strUri = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
                string column = "NC_Heat_Confirm_Event";
                try
                {


                    Adapter.Session.Get(strUri, column, ref Obj);
                    int i = Convert.ToInt32(Obj.ToString());
                    i++;
                    Adapter.Session.Set(strUri, column, i.ToString());

                }
                catch
                {
                }
                 
            }

            
           
        }
        //查询

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            LoadData();
        }
        //测试NC通讯

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void send()
        {

            string strXslt = @"BOFAddMaterialsInforToNC.xslt";
            //组织发送记录集
            DataSet dsM = new DataSet();

            if (dsMain.Tables[0].Rows.Count > 0)
            {
                //组织主表记录集
                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                tbM = dsMain.Tables[0].Copy();
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            //组织从表记录集
            if (dsMaterial.Tables[0].Rows.Count > 0)
            {
                DataTable tbS = new DataTable();
                tbS = dsMaterial.Tables[0].Clone();
                tbS = dsMaterial.Tables[0].Copy();
                tbS.TableName = "s1";
                dsM.Tables.Add(tbS);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            string strXML = TranslateDataSetToNC(strXslt, dsM);
            string strRet = TransferXML(strXML);
            if (strRet != "")
            {
                if (strRet == "1")
                {
                    //组建成功记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "0";
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
                else
                {
                    //组建失败记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "1";
                    row["Remark"] = strRet;
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
            }
            else
            {
                MessageBox.Show("发送失败!");
            }
        }
        public static string NCServer = @"http://192.168.2.68:80/service/XChangeServlet?account=1&amp;receiver=101 ";
        public static string TranslateDataSetToNC(string strxslt, DataSet data)
        {
            System.Xml.Xsl.XslCompiledTransform trans = new System.Xml.Xsl.XslCompiledTransform();
            trans.Load(strxslt);
            string strTmpDir = Path.GetTempPath();
            //string strLogDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataSent");
            string strLogDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string strDataFile = Path.Combine(strTmpDir, "MES_Data.xml");
            string strXmlFile = Path.Combine(strLogDir, string.Format("{0}.xml", "MES_Data"));
            data.WriteXml(strDataFile);
            trans.Transform(strDataFile, strXmlFile);
            return strXmlFile;
        }
        public static string TransferXML(string strXML)
        {
            try
            {
                //1、从流中读取字节块，并将数据写入给定缓冲区
                System.IO.FileStream file = new System.IO.FileStream(strXML, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                file.Seek(0, System.IO.SeekOrigin.Begin);//设置文件流的当前位置
                int iLen = (int)file.Length;
                byte[] data = new byte[iLen];
                file.Read(data, 0, iLen);//从流中读取字节块，并将数据写入给定缓冲区
                file.Close();//关闭流并释放资源

                //2、初始化WebRequest实例  连接NC服务器
                string strURI = NCServer;
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(strURI);//初始化WebRequest实例  连接NC服务器
                if (request == null)
                    return "连接NC服务器失败";
                request.Method = "POST";
                request.ContentType = "text/xml; charset=gb2312";
                request.ContentLength = iLen;
                request.Timeout = 500000; // 500秒
                try
                {
                    System.IO.Stream postDataStream = request.GetRequestStream();//字节序列的一般视图
                    postDataStream.Write(data, 0, iLen);
                    postDataStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return e.Message.ToString();
                }


                //3、Get answer
                System.Net.HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException err)
                {
                    MessageBox.Show(err.Status + " - " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resp = (HttpWebResponse)err.Response;
                    if (resp == null)
                    {
                        return err.Message.ToString(); ;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return err.Message.ToString(); ;
                }

                //读取服务器响应的体
                Stream rcvStream = resp.GetResponseStream();
                byte[] respBytes = new byte[256];
                int byteCount;

                //将服务器响应转换成字符串编码
                StringBuilder builder = new StringBuilder(); //可变字符字符串
                do
                {
                    byteCount = rcvStream.Read(respBytes, 0, 256);
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                    string inputString = encoding.GetString(respBytes);
                    builder.Append(inputString);

                } while (byteCount > 0);

                XmlDocument doc = new XmlDocument();
                string xmlRet = builder.ToString();
                int iPos = xmlRet.IndexOf(@"</ufinterface>");
                xmlRet = xmlRet.Substring(0, iPos + ((string)@"</ufinterface>").Length);
                doc.LoadXml(xmlRet);

                string tok = XmlGetElement(doc, "resultcode");
                string resultCont = XmlGetElement(doc, "resultdescription");
                resultCont = resultCont.Replace("\r\n", "");
                resultCont = resultCont.Replace("\t", "");
                resp.Close();
                rcvStream.Close();

                //返回正确写日志，否则丢弃
                if (!tok.Equals("1"))
                {
                   // MessageBox.Show(string.Format("调用NC接口错误!\r" + resultCont));
                    return resultCont;
                }
                else
                {
                    //MessageBox.Show(string.Format("发送数据成功!"));
                    return "1";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public static string ErrorTransferXML(string strXML)
        {
            try
            {
                System.IO.FileStream file = new System.IO.FileStream(strXML, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                file.Seek(0, System.IO.SeekOrigin.Begin);
                int iLen = (int)file.Length;
                byte[] data = new byte[iLen];
                file.Read(data, 0, iLen);
                file.Close();

                string strURI = NCServer;
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(strURI);
                if (request == null)
                    return "连接NC服务器失败";
                request.Method = "POST";
                request.ContentType = "text/xml; charset=gb2312";
                request.ContentLength = iLen;

                try
                {
                    System.IO.Stream postDataStream = request.GetRequestStream();
                    postDataStream.Write(data, 0, iLen);
                    postDataStream.Close();
                }
                catch (Exception e)
                {

                    return e.Message.ToString();
                }

                //Get answer
                System.Net.HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException err)
                {

                    resp = (HttpWebResponse)err.Response;
                    if (resp == null)
                    {
                        return err.Message.ToString(); ;
                    }
                }
                catch (Exception err)
                {

                    return err.Message.ToString(); ;
                }


                Stream rcvStream = resp.GetResponseStream();
                byte[] respBytes = new byte[256];
                int byteCount;

                StringBuilder builder = new StringBuilder();
                do
                {
                    byteCount = rcvStream.Read(respBytes, 0, 256);
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                    string inputString = encoding.GetString(respBytes);
                    builder.Append(inputString);

                } while (byteCount > 0);

                XmlDocument doc = new XmlDocument();
                string xmlRet = builder.ToString();
                int iPos = xmlRet.IndexOf(@"</ufinterface>");
                xmlRet = xmlRet.Substring(0, iPos + ((string)@"</ufinterface>").Length);
                doc.LoadXml(xmlRet);

                string tok = XmlGetElement(doc, "resultcode");
                string resultCont = XmlGetElement(doc, "resultdescription");
                resultCont = resultCont.Replace("\r\n", "");
                resultCont = resultCont.Replace("\t", "");
                resp.Close();
                rcvStream.Close();

                //返回正确写日志，否则丢弃
                if (!tok.Equals("1"))
                {
                    return resultCont;
                }
                else
                {
                    return "1";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public static string XmlGetElement(XmlDocument doc, string value)
        {
            XmlNode root = doc.DocumentElement.FirstChild;
            IEnumerator ienum = root.GetEnumerator();
            XmlElement book = null;
            while (ienum.MoveNext())
            {
                book = (XmlElement)ienum.Current;
                if (book.Name.Equals(value))
                {
                    break;
                }

            }

            return (book != null) ? book.InnerText : null;
        }

        private void LoadData()
        {

            StringBuilder strsql = new StringBuilder();
            // string strheatid = "炉号";
            // dvTel.Rows.Clear();
            //strsql.Append("select heatid as 炉号  from  CCCM_Base_Data  where  HeatConfirm = 1  ");
            //strsql.Append("and PRODUCTIONDATE> sysdate-14 and heatid not in ");
            if (comboBox1.Text.Trim() != "")
            {
                strsql.Append("select a.heatid as 炉号,createtime as 错误时间,b.remark as 错误原因 from  CCCM_Base_Data a,  ");
                strsql.Append("(select heatid,remark,createtime,row_number()over(partition by heatid order by createtime desc) as ar ");
                strsql.Append(string.Format("from CRETRUNDATA_NC where BILLTYPE='{0}' and flag=1) b ", comboBox1.Text));
                strsql.Append("where  a.HeatConfirm = 1   and a.PRODUCTIONDATE> sysdate-14 and a.heatid=b.heatid(+) and ((b.ar=1) or (b.ar is null) ) and a.heatid not in ");
                strsql.Append(string.Format("( select heatid from CRETRUNDATA_NC where BILLTYPE='{0}' and flag=0 )", comboBox1.Text));
            }
            else
            { 

                return;
            }

            try
            {

                AppSvrHMI.L3DataSet dsLabElement = new AppSvrHMI.L3DataSet();
                dsLabElement.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                dsLabElement.SourceMethod = strsql.ToString();
                dsLabElement.L3DataAdapter = this.Adapter;
                dsLabElement.LoadData();
                dvTel.DataSource = dsLabElement.Tables[0];
                MessageBox.Show("执行完毕");
            }
            catch
            {
                return;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        //补批次号


        public void addbatchid(string heatid,string element)
        {
            string sql = "call add_batch_id('" + heatid + "'," + "'" + element + "')";
            Save(sql);
        }

        private void Save(string sql)
        {




            if (!string.IsNullOrEmpty(sql))
            {
                AppSvrIF.Command cmd = null;

                int result = Adapter.Session.CreateCommand(14, sql, "", ref cmd);
                if (result == 0)
                {
                    Adapter.Session.Execute(cmd);
                }
            }

           // MessageBox.Show("保存成功");
            // btnSave.Enabled = true;



        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{            
        //    TelQueryFrm frm = new TelQueryFrm();
        //    frm.ShowDialog();
        //    if (strSQL != "")
        //    {
        //        dsLog.SourceMethod = "select * from CRetrunData_NC where HeatID = ''";
        //        dsLog.SourceMethod = strSQL;
        //    }
        //}
    }
}