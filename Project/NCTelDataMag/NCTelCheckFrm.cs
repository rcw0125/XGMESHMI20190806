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
            comboBox1.Text = "Ͷ��";
        }

        #region IMESForm ��Ա

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
        //���͵���
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dvTel.Rows.Count < 1)
            {
                return;
            }
            ////////////////////////////////////////Ͷ�ϵ���
            if (comboBox1.Text.Trim() == "Ͷ��")
            {
                for (int i = 1; i <= dvTel.Rows.Count; i++)
                {
                    string strcell = dvTel.Rows[i - 1].Cells[2].Value.ToString();
                    string strheatid = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    string strtemp;
                    string element;

                    if (strcell.Contains("����ָ�����κţ������"))
                    {
                        int j = strcell.IndexOf("�����");
                        strtemp = strcell.Substring(j + 8,1);
                        if (strtemp == "��")
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
                    //if (strcell.Contains("����ָ�����κţ������"))
                    //{
                    //    int j = strcell.IndexOf("�����");
                    //    string element = strcell.Substring(j + 3, 5);
                    //    addbatchid(strheatid, element);
                    //    dsMain.Tables[0].Clear();
                    //    dsMaterial.Tables[0].Clear();
                    //    cmdMain.Parameters[0].ConstantValue = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    //    cmdMain.Execute();
                    //    send();
                    //    // MessageBox.Show(str);
                    //}
                    else if (strcell.Contains("�����ظ��ύ����!"))
                    {

                    }
                    else if (strcell.Contains("���ϼƻ��Ѿ���������ҵ�񣬲��ܼ���"))
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
            else if (comboBox1.Text.Trim() == "����")
            {
                string sql;
                for (int i = 1; i <= dvTel.Rows.Count; i++)
                {
                    string strcell = dvTel.Rows[i - 1].Cells[2].Value.ToString();
                    string strheatid = dvTel.Rows[i - 1].Cells[0].Value.ToString();
                    if (strcell.Contains("�����ظ��ύ����!"))
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
        //��ѯ

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            LoadData();
        }
        //����NCͨѶ

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void send()
        {

            string strXslt = @"BOFAddMaterialsInforToNC.xslt";
            //��֯���ͼ�¼��
            DataSet dsM = new DataSet();

            if (dsMain.Tables[0].Rows.Count > 0)
            {
                //��֯�����¼��
                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                tbM = dsMain.Tables[0].Copy();
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);
            }
            else
            {
                MessageBox.Show("���ѯ����Ҫ�ϴ�������!");
                return;
            }

            //��֯�ӱ��¼��
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
                MessageBox.Show("���ѯ����Ҫ�ϴ�������!");
                return;
            }

            string strXML = TranslateDataSetToNC(strXslt, dsM);
            string strRet = TransferXML(strXML);
            if (strRet != "")
            {
                if (strRet == "1")
                {
                    //�齨�ɹ���¼��
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
                    //�齨ʧ�ܼ�¼��
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
                MessageBox.Show("����ʧ��!");
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
                //1�������ж�ȡ�ֽڿ飬��������д�����������
                System.IO.FileStream file = new System.IO.FileStream(strXML, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                file.Seek(0, System.IO.SeekOrigin.Begin);//�����ļ����ĵ�ǰλ��
                int iLen = (int)file.Length;
                byte[] data = new byte[iLen];
                file.Read(data, 0, iLen);//�����ж�ȡ�ֽڿ飬��������д�����������
                file.Close();//�ر������ͷ���Դ

                //2����ʼ��WebRequestʵ��  ����NC������
                string strURI = NCServer;
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(strURI);//��ʼ��WebRequestʵ��  ����NC������
                if (request == null)
                    return "����NC������ʧ��";
                request.Method = "POST";
                request.ContentType = "text/xml; charset=gb2312";
                request.ContentLength = iLen;
                request.Timeout = 500000; // 500��
                try
                {
                    System.IO.Stream postDataStream = request.GetRequestStream();//�ֽ����е�һ����ͼ
                    postDataStream.Write(data, 0, iLen);
                    postDataStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return e.Message.ToString();
                }


                //3��Get answer
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

                //��ȡ��������Ӧ����
                Stream rcvStream = resp.GetResponseStream();
                byte[] respBytes = new byte[256];
                int byteCount;

                //����������Ӧת�����ַ�������
                StringBuilder builder = new StringBuilder(); //�ɱ��ַ��ַ���
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

                //������ȷд��־��������
                if (!tok.Equals("1"))
                {
                   // MessageBox.Show(string.Format("����NC�ӿڴ���!\r" + resultCont));
                    return resultCont;
                }
                else
                {
                    //MessageBox.Show(string.Format("�������ݳɹ�!"));
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
                    return "����NC������ʧ��";
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

                //������ȷд��־��������
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
            // string strheatid = "¯��";
            // dvTel.Rows.Clear();
            //strsql.Append("select heatid as ¯��  from  CCCM_Base_Data  where  HeatConfirm = 1  ");
            //strsql.Append("and PRODUCTIONDATE> sysdate-14 and heatid not in ");
            if (comboBox1.Text.Trim() != "")
            {
                strsql.Append("select a.heatid as ¯��,createtime as ����ʱ��,b.remark as ����ԭ�� from  CCCM_Base_Data a,  ");
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
                MessageBox.Show("ִ�����");
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
        //�����κ�


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

           // MessageBox.Show("����ɹ�");
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