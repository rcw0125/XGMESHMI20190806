using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace NCTelDataMag
{
    public partial class  IronInStoreInfoFrm : DockContent, IMESForm
    {
        public IronInStoreInfoFrm()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dsMain.Tables[0].Clear();
            dsMaterial.Tables[0].Clear();
            if (txbHeatID.Text != "")
            {
                cmdMain.Parameters[0].ConstantValue = txbHeatID.Text;
                cmdMain.Execute();
                int i = dsMain.Tables[0].Rows.Count;

            }
            else
            {
                MessageBox.Show("请输入正确的炉号!");
            }
        }

        private void btnUpdateSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"updateIronBloomInStoreInfor.xslt";
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

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
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

                    // 上传成功后，更改NC标志
                    string strSql = "update cbfiron set nc_confirm_flag=1 where tap_no='" + dsM.Tables[0].Rows[0]["HeatID"].ToString() + "'";
                    exeSql(Adapter, strSql);
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

        public  string exeSql(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            try
            {
                if (adapter.Session == null || !adapter.Session.Opened)
                {
                    MessageBox.Show("adapter连接没有打开，请重新登陆");
                    return null;
                }
                AppSvrIF.Command cmd = null;
                //创建sql命令
                int result = adapter.Session.CreateCommand(14, strSql, "", ref cmd);
                if (result == 0)
                {
                    //使用session执行sql命令
                    return adapter.Session.Execute(cmd).ToString();

                }
                else
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        private void btnAddSend_Click(object sender, EventArgs e)
        {

            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"IronBloomInStoreInfor.xslt";
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

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
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
                    // 上传成功后，更改NC标志
                    string strSql= "update cbfiron set nc_confirm_flag=1 where tap_no='"+ dsM.Tables[0].Rows[0]["HeatID"].ToString() + "'";
                    exeSql(Adapter, strSql);
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

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

      
    }
}