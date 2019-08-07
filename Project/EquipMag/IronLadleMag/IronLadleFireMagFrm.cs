using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleFireMagFrm : DockContent, IMESForm
    {
        public IronLadleFireMagFrm()
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

        //�ؼ�����
        private void IronLadleFireMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-3);
            dtEnd.Value = DateTime.Now;

            cmbIronladleID.Items.Add("");
            for (int i = 0; i < dsIronladleID.Tables[0].Rows.Count; i++)
            {
                cmbIronladleID.Items.Add(dsIronladleID.Tables[0].Rows[i]["IronLadleID"]);
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
                DataRow newrow = dsFireInfo.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["IronLadleID"] = "";
                newrow["Fire_Type"] = "";
                newrow["FireID"] = 0;
                newrow["Fire_Start_Time"] = DateTime.Now;
                newrow["Fire_End_Time"] = DateTime.Now;
                newrow["Fire_Length"] = 0;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["NOTE"] = "";

                dsFireInfo.Tables[0].Rows.Add(newrow);

                bsFireInfo.MoveFirst();
                while (((System.Data.DataRowView)(bsFireInfo.Current)).Row != newrow && bsFireInfo.Position != dsFireInfo.Tables[0].Rows.Count - 1)
                {
                    bsFireInfo.MoveNext();
                }
                IronLadleFireShowFrm Frm = new IronLadleFireShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsFireInfo.Position, strSort, ref dsFireInfo);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsFireInfo.Position>=0)
            {
                bsFireInfo.RemoveCurrent();
            }
            
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvFireInfo.EndEdit();
            bsFireInfo.EndEdit();
            bool bSucc = false;
            //ɾ��
            if (dsFireInfo.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete())
                {
                    FormQueryString();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsFireInfo.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy())
                {
                    FormQueryString(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsFireInfo.GetChanges(DataRowState.Added) != null)
            {
                if (!Added())
                {
                    FormQueryString(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                FormQueryString();
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        //˫�������޸�
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsFireInfo.Tables[0].Rows.Count > 0)
            {
                bsFireInfo.Position = e.RowIndex;
                IronLadleFireShowFrm Frm = new IronLadleFireShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsFireInfo.Position, strSort, ref dsFireInfo);
                GC.Collect();
            }
        }

        //��ѯ
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
            if (cmbIronladleID.Text != null && cmbIronladleID.Text != "")
            {
                strCurSql += " and IronLadleID = '" + cmbIronladleID.SelectedItem.ToString() + "'";
            }
            cmdFireInfo.Parameters[0].ConstantValue = strCurSql;
            dsFireInfo.LoadData();
        }

        private void dvFireInfo_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsFireInfo.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�����濾ʵ��", dvFireInfo);
        }

        private void IronLadleFireMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvFireInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private bool Added()
        {
            object objAdd = null;
            string strMessage = "";
            if (dsFireInfo.CommitAdded(ref objAdd))
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
                        strMessage = "����ʧ�ܣ�";
                        break;
                    case -1:
                        strMessage = "û�������Ż�濾���ͻ�濾������������������";
                        break;
                    case -2:
                        strMessage = "�濾�����Ȼ�����Ϣ�к濾�����ߣ�����������";
                        break;
                    case -3:
                        strMessage = "�濾��¼�Ѵ��ڣ�������������";
                        break;
                    default:
                        strMessage = "ϵͳԭ�򣬵�ǰ����������";
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

        private bool Modiy()
        {
            object objMod = null;
            string strMessage = "";
            if (dsFireInfo.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "ϵͳæ�����Ժ���";
                        break;
                    case -1:
                        strMessage = "��ǰ�޸ļ�¼û�йؼ���(����û��ˢ��)��";
                        break;
                    case -2:
                        strMessage = "��ǰ�޸ļ�¼û�������Ż�濾������濾���ͣ�";
                        break;
                    case -3:
                        strMessage = "�濾�����Ȼ�����Ϣ�к濾�����ߣ�����������";
                        break;
                    case -5:
                        strMessage = "�������޸ģ��Ѿ�������Ҫ�޸ĵ��ļ�¼��";
                        break;
                    case -6:
                        strMessage = "ɾ��ԭ�м�¼ʧ�ܣ�";
                        break;
                    default:
                        strMessage = "�����쳣�����";
                        break;
                }
            }
            else
                strMessage = "ϵͳæ�����Ժ���";
            MessageBox.Show(strMessage, "�޸�ʧ�ܣ�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool Delete()
        {
            object objDel = null;
            if (dsFireInfo.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
                    return false;
                }
                else
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
                    return true;
                }
            }
            MessageBox.Show("ϵͳæ�����Ժ���", "��ʾ");
            return false;
        }
    }
}