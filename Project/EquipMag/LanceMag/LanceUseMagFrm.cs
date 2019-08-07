using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LanceMag
{
    public partial class LanceUseMagFrm : DockContent, IMESForm
    {
        public LanceUseMagFrm()
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

        private string strCurSql = "";
        private object objShiftID = "";
        private object objTeamID = "";
        private string strSort = "";
        private LanceUseMagShowFrm Frm = new LanceUseMagShowFrm();

        //�ؼ�����
        private void LanceUseMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-1);
            dtEnd.Value = DateTime.Now;

            cmbLanceID.Items.Add("");
            for (int i = 0; i < dsLanceID.Tables[0].Rows.Count; i++)
            {
                cmbLanceID.Items.Add(dsLanceID.Tables[0].Rows[i]["LanceID"]);
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsM.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;//SHIFT_DATE
                newrow["SHIFT_DATE"] = DateTime.Now.Date;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["NOTE"] = "";

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }
                Frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸���Ϣ
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsM.Tables[0].Rows.Count > 0)
            { 
                bsM.Position = e.RowIndex;
                Frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position>=0)
            {
                bsM.RemoveCurrent();
            }
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //dvM.EndEdit();
            //bsM.EndEdit();
            //bool bAdd = false;
            //if (dsM.GetChanges(DataRowState.Added) != null)
            //    bAdd = true;
            //if (dsM.UpdateData())
            //{
            //    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
            //    FormQueryString();
            //    return;
            //}
            //if (bAdd)
            //    MessageBox.Show("����ʧ��,����������Ϣ��Ӧ��ǹ���������Ϣ���Ƿ���\"��ǹ�������\"��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //else
            //    MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            dvM.EndEdit();
            bsM.EndEdit();
            if (dsM.GetChanges() == null)
            {
                return;
            }
            DataSet ddddd = dsM.GetChanges(DataRowState.Added);
            bool bSucc = false;
            //ɾ��
            if (dsM.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete_Main())
                {
                    dsM.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsM.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy_Main())
                {
                    dsM.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsM.GetChanges(DataRowState.Added) != null)
            {
                if (!Added_Main())
                {
                    dsM.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                btnQuery_Click(sender, e);
        }
        // insert [4/20/2011 sunxiaotian]
        private bool Delete_Main()
        {
            object objDel = null;
            if (dsM.CommitDeleted(ref objDel))
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
        // insert [4/20/2011 sunxiaotian]
        private bool Modiy_Main()
        {
            object objMod = null;
            if (dsM.CommitModified(ref objMod))
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
        // insert [4/20/2011 sunxiaotian]
        private bool Added_Main()
        {
            object objAdd = null;
            if (dsM.CommitAdded(ref objAdd))
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



        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }


        //��ѯ
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (cmbLanceID.Text != null && cmbLanceID.Text != "")
            {
                strCurSql += " and LanceID = '" + cmbLanceID.SelectedItem.ToString() + "'";
            }
            cmdM.Parameters[0].ConstantValue = strCurSql;
            dsM.LoadData();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("��ǹʹ��ʵ��", dvM);
        }

        private void LanceUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}