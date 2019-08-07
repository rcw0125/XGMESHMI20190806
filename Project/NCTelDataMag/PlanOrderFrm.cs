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
    public partial class PlanOrderFrm : DockContent, IMESForm
    {
        public PlanOrderFrm()
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txbHeatID.Text != "")
            {
                dsPlanOrder.Tables[0].Clear();
                cmdPlanOrder.Parameters[0].ConstantValue = txbHeatID.Text;
                cmdPlanOrder.Execute();
            }
            else
            {
                MessageBox.Show("请输入正确的炉号");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"MillPlanToNC.xslt";
            if (dsPlanOrder.Tables[0].Rows.Count > 0)
            {  
                //将数据写入到xml中
                string strXML = TelComm.TranslateDataSetToNC(strXslt, dsPlanOrder);
                //将xml文件发送至NC
                string strRet = TelComm.TransferXML(strXML);
                if (strRet != "")
                {
                    if (strRet == "1")
                    {
                        //组建成功记录集
                        dsLog.Clear();
                        DataRow row = dsLog.Tables[0].NewRow();
                        row["HeatID"] = dsPlanOrder.Tables[0].Rows[0]["HeatID"].ToString();
                        row["BillType"] = strXslt;
                        row["Other1"] = dsPlanOrder.Tables[0].Rows[0]["Flag"].ToString();
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
                        row["HeatID"] = dsPlanOrder.Tables[0].Rows[0]["HeatID"].ToString();
                        row["BillType"] = strXslt;
                        row["Other1"] = dsPlanOrder.Tables[0].Rows[0]["Flag"].ToString();
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
            else
            {
                MessageBox.Show("请先查询出需要上传的数据!");
            }
            
        }

        private void btnUpdateSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"updateMillPlanToNC.xslt";
            if (dsPlanOrder.Tables[0].Rows.Count > 0)
            {
                string strXML = TelComm.TranslateDataSetToNC(strXslt, dsPlanOrder);
                string strRet = TelComm.TransferXML(strXML);
                if (strRet != "")
                {
                    if (strRet == "1")
                    {
                        //组建成功记录集
                        dsLog.Clear();
                        DataRow row = dsLog.Tables[0].NewRow();
                        row["HeatID"] = dsPlanOrder.Tables[0].Rows[0]["HeatID"].ToString();
                        row["BillType"] = strXslt;
                        row["Other1"] = dsPlanOrder.Tables[0].Rows[0]["Flag"].ToString();
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
                        row["HeatID"] = dsPlanOrder.Tables[0].Rows[0]["HeatID"].ToString();
                        row["BillType"] = strXslt;
                        row["Other1"] = dsPlanOrder.Tables[0].Rows[0]["Flag"].ToString();
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
            else
            {
                MessageBox.Show("请先查询出需要上传的数据!");
            }
        }

        private void dvPlanOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

  

    }
}