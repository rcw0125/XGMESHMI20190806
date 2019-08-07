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
    public partial class IronBloomInfoFrm : DockContent, IMESForm
    {
        public IronBloomInfoFrm()
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
            string strXslt = @"updateIronBloomInfor.xslt";
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

        private void btnAddSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("���ֶ�ɾ��DataSent�ļ��е�MES_Data.xml�ļ�!");
            //    return;
            //}
            string strXslt = @"IronBloomInfor.xslt";
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