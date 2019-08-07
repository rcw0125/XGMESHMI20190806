using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class LadleInnerBuildMagFrm : DockContent, IMESForm
    {
        public LadleInnerBuildMagFrm()
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

        private string strLadleID = "";
        private string strSort = "";

        private object objShiftID = "";
        private object objTeamID = "";

        //�ؼ�����
        private void LadleInnerBuildMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbLadleID.Items.Clear();
            cmbLadleID.Items.Add("");
            if (dsLadleID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsLadleID.Tables[0].Rows.Count; i++)
                {
                    cmbLadleID.Items.Add(dsLadleID.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string strSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (strLadleID != "")
            {
                strSql += strLadleID;
            }
            strSql += " order by Input_Time desc,LadleID asc";
            cmdInnerBuildInfos.Parameters[0].ConstantValue = strSql;
            dsInnerBuildInfos.LoadData();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

                DataRow newrow = dsInnerBuildInfos.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["Build_Start_Time"] = DateTime.Now;
                newrow["Build_End_Time"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsInnerBuildInfos.Tables[0].Rows.Add(newrow);
                bsInnerBuildInfos.MoveFirst();
                while (((System.Data.DataRowView)(bsInnerBuildInfos.Current)).Row != newrow && bsInnerBuildInfos.Position != dsInnerBuildInfos.Tables[0].Rows.Count - 1)
                {
                    bsInnerBuildInfos.MoveNext();
                }
                LadleInnerBuildMagShowFrm Frm = new LadleInnerBuildMagShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsInnerBuildInfos.Position, ref dsInnerBuildInfos);
                GC.Collect();
            }
            catch { }
        }

        //�޸���Ϣ
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsInnerBuildInfos.Tables[0].Rows.Count > 0)
            {
                LadleInnerBuildMagShowFrm Frm = new LadleInnerBuildMagShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsInnerBuildInfos.Position, ref dsInnerBuildInfos);
                GC.Collect();
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsInnerBuildInfos.Position>=0)
            {
                bsInnerBuildInfos.RemoveCurrent();
            }
            
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsInnerBuildInfos.EndEdit();
            bool bSucc = false;
            //ɾ��
            if (dsInnerBuildInfos.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete())
                {
                    dsInnerBuildInfos.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsInnerBuildInfos.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy())
                {
                    dsInnerBuildInfos.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsInnerBuildInfos.GetChanges(DataRowState.Added) != null)
            {
                if (!Added())
                {
                    dsInnerBuildInfos.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                dsInnerBuildInfos.LoadData();
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsInnerBuildInfos.LoadData();
        }

        //ѡ��ְ�Cmb�ر�ʱ
        private void cmbLadleID_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbLadleID.Text.ToString() != null && cmbLadleID.Text.ToString() != "")
            {
                strLadleID = " and LadleID = '" + cmbLadleID.Text + "'";
            }
            else
            {
                strLadleID = "";
            }
        }

        //����
        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsInnerBuildInfos.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ְ����ò�����ʵ��", dvM);
        }

        private void LadleInnerBuildMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private bool Added()
        {
            object objAdd = null;
            string strMessage = "";
            if (dsInnerBuildInfos.CommitAdded(ref objAdd))
            {
                int iRet = Convert.ToInt16(objAdd);
                if (iRet > 0)
                {
                    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "ϵͳæ�����Ժ���";
                        break;
                    case -1:
                        strMessage = "�ְ��Ų���Ϊ�գ�";
                        break;
                    case -2:
                        strMessage = "�Ѿ��������ò�������Ϣ��";
                        break;
                    default:
                        strMessage = "�����쳣�����";
                        break;
                }
                MessageBox.Show(strMessage, "����ʧ�ܣ�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("ϵͳæ�����Ժ���", "����ʧ�ܣ�", MessageBoxButtons.OK);
                return false;
            }
        }

        private bool  Modiy()
        {
            object objMod = null;
            if (dsInnerBuildInfos.CommitModified(ref objMod))
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

        private bool Delete()
        {
            object objDel = null;
            if (dsInnerBuildInfos.CommitDeleted(ref objDel))
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
                MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}