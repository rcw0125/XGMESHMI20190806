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
                MessageBox.Show("��������ȷ��¯��");
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
            //    MessageBox.Show("���ֶ�ɾ��DataSent�ļ��е�MES_Data.xml�ļ�!");
            //    return;
            //}
            string strXslt = @"MillPlanToNC.xslt";
            if (dsPlanOrder.Tables[0].Rows.Count > 0)
            {  
                //������д�뵽xml��
                string strXML = TelComm.TranslateDataSetToNC(strXslt, dsPlanOrder);
                //��xml�ļ�������NC
                string strRet = TelComm.TransferXML(strXML);
                if (strRet != "")
                {
                    if (strRet == "1")
                    {
                        //�齨�ɹ���¼��
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
                        //�齨ʧ�ܼ�¼��
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
                    MessageBox.Show("����ʧ��!");
                }
            }
            else
            {
                MessageBox.Show("���Ȳ�ѯ����Ҫ�ϴ�������!");
            }
            
        }

        private void btnUpdateSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("���ֶ�ɾ��DataSent�ļ��е�MES_Data.xml�ļ�!");
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
                        //�齨�ɹ���¼��
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
                        //�齨ʧ�ܼ�¼��
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
                    MessageBox.Show("����ʧ��!");
                }
            }
            else
            {
                MessageBox.Show("���Ȳ�ѯ����Ҫ�ϴ�������!");
            }
        }

        private void dvPlanOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

  

    }
}