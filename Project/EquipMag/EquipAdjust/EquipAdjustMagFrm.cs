using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.EquipAdjust
{
    public partial class EquipAdjustMagFrm : DockContent, IMESForm
    {
        private string path = Application.StartupPath;

        public EquipAdjustMagFrm()
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

        //�������
        private void FinLadleBuildMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            DataRow row1 = dsCheck.Tables[0].NewRow();
            DataRow row2 = dsCheck.Tables[0].NewRow();
            row1["ID"] = 0;
            row1["Desc"] = "δ���";
            dsCheck.Tables[0].Rows.Add(row1);
            row2["ID"] = 1;
            row2["Desc"] = "�����";
            dsCheck.Tables[0].Rows.Add(row2);
            dsCheck.AcceptChanges();
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��ѯ����Ϣ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strdtS = dtStart.Text.Trim() + " 00:00:00";
            string strdtE = dtEnd.Text.Trim() + " 23:59:59";

            cmdMain.Parameters[0].ConstantValue = strdtS;
            cmdMain.Parameters[1].ConstantValue = strdtE;
            dsMain.LoadData();
        }

        private DataSet dsChange = new DataSet();
        //��������Ϣ
        private void btnAddMain_Click(object sender, EventArgs e)
        {
            try
            {
                //���һ�����ݣ�����Ӧ���ݽ������
                dsChange = dsMain.Clone();

                EquipAdjustMainFrm FrmMain = new EquipAdjustMainFrm();
                FrmMain.ShowDialogEx(Adapter.Session, ref dsChange);

                if (dsChange.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsChange.Tables[0].Rows[0];
                    dsMain.Tables[0].ImportRow(row);
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸�����Ϣ
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dvMain.RowCount > 0)
            {
                dsChange = dsMain.Clone();
                dsChange.Tables[0].ImportRow(((System.Data.DataRowView)(bsMain.Current)).Row);

                EquipAdjustMainFrm FrmMain = new EquipAdjustMainFrm();
                FrmMain.ShowDialogEx(Adapter.Session, ref dsChange);

                if (dsChange.Tables[0].Rows.Count > 0)
                {
                    dvMain.CurrentRow.Cells["locationDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Location"];
                    dvMain.CurrentRow.Cells["locationDesDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Location_Des"];
                    dvMain.CurrentRow.Cells["meterDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Meter"];
                    dvMain.CurrentRow.Cells["meterSizeDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Meter_Size"];
                    dvMain.CurrentRow.Cells["rangeDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Range"];
                    dvMain.CurrentRow.Cells["precisionDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Precision"];
                    dvMain.CurrentRow.Cells["factoryDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Factory"];
                    dvMain.CurrentRow.Cells["measureIDDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Measure_ID"];
                    dvMain.CurrentRow.Cells["standardEquDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Standard_Equ"];
                    dvMain.CurrentRow.Cells["scaleMinDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Scale_Min"];

                    dvMain.CurrentRow.Cells["operatorDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Operator"];
                    dvMain.CurrentRow.Cells["checkDateDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Check_Date"];
                    dvMain.CurrentRow.Cells["resultDataGridViewTextBoxColumn"].Value = dsChange.Tables[0].Rows[0]["Result"];
                }
                GC.Collect();
            }
        }

        //ɾ������Ϣ
        private void btnDelMain_Click(object sender, EventArgs e)
        {
            if (dvMain.RowCount > 0)
            {
                bsMain.RemoveCurrent();
            }
        }

        //����Ϣ����
        private void btnConfirmMain_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            if (dsMain.GetChanges() == null)
            {
                return;
            }
            DataSet ddddd = dsMain.GetChanges(DataRowState.Added);
            bool bSucc = false;
            //ɾ��
            if (dsMain.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete_Main())
                {
                    dsMain.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsMain.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy_Main())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsMain.GetChanges(DataRowState.Added) != null)
            {
                if (!Added_Main())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                btnQuery_Click(sender, e);
        }

        private bool Added_Main()
        {
            object objAdd = null;
            if (dsMain.CommitAdded(ref objAdd))
            {
                int iRet = Convert.ToInt16(objAdd);
                if (iRet > 0)
                {
                    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Modiy_Main()
        {
            object objMod = null;
            if (dsMain.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                return false;
            }
        }

        private bool Delete_Main()
        {
            object objDel = null;
            if (dsMain.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
                    return true;
                }
                else
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                return false;
            }
        }

        //����Ϣȡ��
        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        //����Ϣ����ʱ����
        private void dvMain_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvMain.Rows.Count > 0)
                {
                    dsDetail.Tables[0].Clear();
                    string strLogID = dvMain.CurrentRow.Cells["logIDDataGridViewTextBoxColumn"].Value.ToString();
                    cmdDetail.Parameters[0].ConstantValue = strLogID;

                    if (dsDetail.GetChanges() != null)
                    {
                        //��ʾ�Ƿ񱣴����Ϣ
                        string strYes = MessageBox.Show("�豸У��ʵ���ѱ��޸�,�Ƿ񱣴棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                        if (strYes == "Yes")
                            dsDetail.UpdateData();
                    }
                    dsDetail.LoadData();
                }
            }
            catch { }
        }

        private DataSet dsChangeDetail = new DataSet();
        //������ϸ��Ϣ
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                //���һ�����ݣ�����Ӧ���ݽ������
                dsChangeDetail = dsDetail.Clone();

                dsChangeDetail.Tables[0].Rows.Add();
                dsChangeDetail.Tables[0].Rows[0]["LogID"] = dvMain.CurrentRow.Cells["logIDDataGridViewTextBoxColumn"].Value.ToString();

                EquipAdjustDetailFrm FrmDetail = new EquipAdjustDetailFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, ref dsChangeDetail);

                if (dsChangeDetail.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsChangeDetail.Tables[0].Rows[0];
                    dsDetail.Tables[0].ImportRow(row);
                }

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸���ϸ��Ϣ 
        private void dvDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dvDetail.RowCount > 0)
            {
                dsChangeDetail = dsDetail.Clone();
                dsChangeDetail.Tables[0].ImportRow(((System.Data.DataRowView)(bsDetail.Current)).Row);

                EquipAdjustDetailFrm FrmMain = new EquipAdjustDetailFrm();
                FrmMain.ShowDialogEx(Adapter.Session, ref dsChangeDetail);

                if (dsChangeDetail.Tables[0].Rows.Count > 0)
                {
                    dvDetail.CurrentRow.Cells["loadBStdDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_B_Std"];
                    dvDetail.CurrentRow.Cells["loadBActDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_B_Act"];
                    dvDetail.CurrentRow.Cells["loadBDifDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_B_Dif"];
                    dvDetail.CurrentRow.Cells["unLoadBStdDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_B_Std"];
                    dvDetail.CurrentRow.Cells["unLoadBActDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_B_Act"];
                    dvDetail.CurrentRow.Cells["unLoadBDifDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_B_Dif"];
                    dvDetail.CurrentRow.Cells["loadAStdDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_A_Std"];
                    dvDetail.CurrentRow.Cells["loadAActDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_A_Act"];
                    dvDetail.CurrentRow.Cells["loadADifDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["Load_A_Dif"];
                    dvDetail.CurrentRow.Cells["unLoadAStdDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_A_Std"];
                    dvDetail.CurrentRow.Cells["unLoadAActDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_A_Act"];
                    dvDetail.CurrentRow.Cells["unLoadADifDataGridViewTextBoxColumn"].Value = dsChangeDetail.Tables[0].Rows[0]["UnLoad_A_Dif"];
                }
                GC.Collect();
            }
        }

        //ɾ����ϸ��Ϣ
        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            if (bsDetail.Position >= 0)
            {
                bsDetail.RemoveCurrent();
            }            
        }

        private bool Added_Detail()
        {
            object objAdd = null;
            if (dsDetail.CommitAdded(ref objAdd))
            {
                int iRet = Convert.ToInt16(objAdd);
                if (iRet > 0)
                {
                    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Modiy_Detail()
        {
            object objMod = null;
            if (dsDetail.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                return false;
            }
        }

        private bool Delete_Detail()
        {
            object objDel = null;
            if (dsDetail.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
                    return true;
                }
                else
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                return false;
            }
        }

        //��ϸ��Ϣ����
        private void btnConfirmDetail_Click(object sender, EventArgs e)
        {
            dvDetail.EndEdit();
            bsDetail.EndEdit();
            if (dsDetail.GetChanges() == null)
            {
                return;
            }

            bool bSucc = false;
            //ɾ��
            if (dsDetail.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete_Detail())
                {
                    dsMain.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsDetail.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy_Detail())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsDetail.GetChanges(DataRowState.Added) != null)
            {
                if (!Added_Detail())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
            {
                dsDetail.Tables[0].Clear();
                string strLogID = dvMain.CurrentRow.Cells["logIDDataGridViewTextBoxColumn"].Value.ToString();
                cmdDetail.Parameters[0].ConstantValue = strLogID;
                dsDetail.LoadData();
            }
        }

        //��ϸ��Ϣȡ��
        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            dsDetail.Tables[0].Clear();
            string strLogID = dvMain.CurrentRow.Cells["logIDDataGridViewTextBoxColumn"].Value.ToString();
            cmdDetail.Parameters[0].ConstantValue = strLogID;
            dsDetail.LoadData();
        }

        private void dvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dsMain.GetChanges() != null || dsMain.Tables[0].Rows.Count == 0)
            {
                DetailEnableSet(false);
            }
            else
            {
                DetailEnableSet(true);
            }
        }

        //������ϸ��Ϣ������
        private void DetailEnableSet(bool bFlag)
        {
            btnAddDetail.Enabled = bFlag;
            btnDelDetail.Enabled = bFlag;
            dvDetail.Enabled = bFlag;
            btnConfirmDetail.Enabled = bFlag;
            btnCancelDetail.Enabled = bFlag;
            btnCheck.Enabled = bFlag;
        }

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnExlMain_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�豸У׼����", dvMain);��
        }

        private void EquipAdjustMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dvMain.RowCount > 0)
            {
                dvMain.CurrentRow.Cells["auditingTimeDataGridViewTextBoxColumn"].Value = DateTime.Now;
                dvMain.CurrentRow.Cells["assessorDataGridViewTextBoxColumn"].Value = Adapter.Session.User;
                dvMain.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value = "1";

                dvMain.EndEdit();
                bsMain.EndEdit();
               
                object objMod = null;
                if (dsMain.GetChanges() != null)
                {
                    if (dsMain.CommitModified(ref objMod))
                    {
                        int iRet = Convert.ToInt16(objMod);
                        if (iRet > 0)
                        {
                            MessageBox.Show("��˳ɹ���", "��ʾ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("���ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("���ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                    }                   
                }
                btnQuery_Click(sender, e);
            }
        }
    }
}