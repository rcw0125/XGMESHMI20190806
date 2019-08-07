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
                MessageBox.Show("��������ȷ��¯��!");
            }
        }

        private void btnUpdateSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("���ֶ�ɾ��DataSent�ļ��е�MES_Data.xml�ļ�!");
            //    return;
            //}
            string strXslt = @"updateIronBloomInStoreInfor.xslt";
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

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
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

                    // �ϴ��ɹ��󣬸���NC��־
                    string strSql = "update cbfiron set nc_confirm_flag=1 where tap_no='" + dsM.Tables[0].Rows[0]["HeatID"].ToString() + "'";
                    exeSql(Adapter, strSql);
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

        public  string exeSql(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            try
            {
                if (adapter.Session == null || !adapter.Session.Opened)
                {
                    MessageBox.Show("adapter����û�д򿪣������µ�½");
                    return null;
                }
                AppSvrIF.Command cmd = null;
                //����sql����
                int result = adapter.Session.CreateCommand(14, strSql, "", ref cmd);
                if (result == 0)
                {
                    //ʹ��sessionִ��sql����
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
            //    MessageBox.Show("���ֶ�ɾ��DataSent�ļ��е�MES_Data.xml�ļ�!");
            //    return;
            //}
            string strXslt = @"IronBloomInStoreInfor.xslt";
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

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
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
                    // �ϴ��ɹ��󣬸���NC��־
                    string strSql= "update cbfiron set nc_confirm_flag=1 where tap_no='"+ dsM.Tables[0].Rows[0]["HeatID"].ToString() + "'";
                    exeSql(Adapter, strSql);
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

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

      
    }
}