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
    public partial class LadleFireMagFrm : DockContent, IMESForm
    {
        public LadleFireMagFrm()
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

        //private string strLadleID = "";
        private string strSort = "";

        private object objShiftID = "";
        private object objTeamID = "";

        
        //�ؼ�����
        private void LadleFireMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbLadleID.Items.Clear();
            cmbLadleID.Items.Add("");
            if (dsLadleID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsLadleID.Tables[0].Rows.Count; i++)
                    cmbLadleID.Items.Add(dsLadleID.Tables[0].Rows[i][0].ToString());
            }

            cmbFireEquID.Items.Clear();
            if (dsLadleFireEqu.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dsLadleFireEqu.Tables[0].Rows.Count; j++)
                    cmbFireEquID.Items.Add(dsLadleFireEqu.Tables[0].Rows[j][0].ToString());
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
            
            if (cmbLadleID.Text != "")
                strSql += " and LadleID = '" + cmbLadleID.Text + "'";
            
            if(cmbFireEquID.Text.Trim()!="")
                strSql += " and ROASTER_ID = '" + cmbFireEquID.Text.Trim() + "'";

            strSql += " order by Input_Time desc,LadleID asc";

            cmdFire.Parameters[0].ConstantValue = strSql;
            dsFire.LoadData();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

                DataRow newrow = dsFire.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["Fire_Type"] = "";
                newrow["Roaster_ID"] = "";
                newrow["LadleID"] = "";
                newrow["Start_Time"] = DateTime.Now;
                newrow["Start_Operator"] = "";
               // newrow["Set_One_Time"] = DateTime.Now;
                newrow["Set_One_Operator"] = "";
               // newrow["Set_Two_Time"] = DateTime.Now;
                newrow["Set_Two_Operator"] = "";
               // newrow["Set_Three_Time"] = DateTime.Now;
                newrow["Set_Three_Operator"] = "";
              //  newrow["Set_Four_Time"] = DateTime.Now;
                newrow["Set_Four_Operator"] = "";
             //   newrow["End_Time"] = DateTime.Now;
                newrow["End_Operator"] = "";
               // newrow["Suspend_Time"] = DateTime.Now;
                newrow["Suspend_Operator"] = "";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsFire.Tables[0].Rows.Add(newrow);
                bsFire.MoveFirst();
                while (((System.Data.DataRowView)(bsFire.Current)).Row != newrow && bsFire.Position != dsFire.Tables[0].Rows.Count - 1)
                {
                    bsFire.MoveNext();
                }
                LadleFireShowFrm Frm = new LadleFireShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsFire.Position, ref dsFire);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸���Ϣ
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsFire.Tables[0].Rows.Count > 0)
            {
                bsFire.Position = e.RowIndex;
                LadleFireShowFrm Frm = new LadleFireShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsFire.Position, ref dsFire);
                GC.Collect();
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsFire.Position>=0)
            {
                bsFire.RemoveCurrent(); 
            }
            
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvFire.EndEdit(); 
            bsFire.EndEdit();
            bool bSucc = false;
            //ɾ��
            if (dsFire.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete())
                {
                    dsFire.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsFire.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy())
                {
                    dsFire.LoadData();  return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsFire.GetChanges(DataRowState.Added) != null)
            {
                if (!Added())
                {
                    dsFire.LoadData(); ; return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                dsFire.LoadData();
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsFire.LoadData();
        }

        //����
        private void dvFire_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsFire.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ְ��濾ʵ��",dvFire);
        }

        private void LadleFireMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private bool Added()
        {
            object objAdd = null;
            string strMessage = "";
            if (dsFire.CommitAdded(ref objAdd))
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
                        strMessage = "û�иְ��ţ�";
                        break;
                    case -2:
                        strMessage = "û�к濾���ͣ�";
                        break;
                    case -3:
                        strMessage = "û�й������ţ�";
                        break;
                    case -4:
                        strMessage = "�Ѿ����ڸְ�������濾��Ϣ��";
                        break;
                    case -5:
                        strMessage = "�Ѿ����ڸְ����ߺ濾��Ϣ��";
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
            if (dsFire.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("�޸�ʧ��", "��ʾ", MessageBoxButtons.OK);
                    return false;
                }
            }
            MessageBox.Show("�޸�ʧ��", "��ʾ", MessageBoxButtons.OK);
            return false;
        }

        private bool Delete()
        {
            object objDel = null;
            if (dsFire.CommitDeleted(ref objDel))
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