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
    public partial class LadleUseMagFrm : DockContent, IMESForm
    {
        public LadleUseMagFrm()
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
        private void LadleUseMagFrm_Load(object sender, EventArgs e)
        {
            cmdUse.Parameters[0].ConstantValue = "1=2";
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

        

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

                DataRow newrow = dsUse.Tables[0].NewRow();

                newrow["Input_Time"] = DateTime.Now;
                newrow["Use_Date"] = DateTime.Now.Date.ToString();
                newrow["Seat_OK_Time"] = DateTime.Now;
                newrow["Off_Ladle_Time"] = DateTime.Now;
                newrow["Arrive_Time"] = DateTime.Now;
                newrow["Complete_Time"] = DateTime.Now;
                newrow["ComFlag"] = 0;
                newrow["Wall_Temp"] = 0;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] =  Adapter.Session.User;

                dsUse.Tables[0].Rows.Add(newrow);

                bsUse.MoveFirst();
                while (((System.Data.DataRowView)(bsUse.Current)).Row != newrow && bsUse.Position != dsUse.Tables[0].Rows.Count - 1)
                {
                    bsUse.MoveNext();
                }
                LadleUseMagShowFrm Frm = new LadleUseMagShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort,false,bsUse.Position, ref dsUse);
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
            if (e.RowIndex >= 0 && dsUse.Tables[0].Rows.Count > 0)
            {
                bsUse.Position = e.RowIndex;
                LadleUseMagShowFrm Frm = new LadleUseMagShowFrm();
                int iRow = dsUse.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsUse.Current)).Row);
                if (Convert.ToBoolean(dsUse.Tables[0].Rows[iRow]["ComFlag"]))
                    Frm.ShowDialogEx(Adapter.Session, strSort, true, bsUse.Position, ref dsUse);
                else
                    Frm.ShowDialogEx(Adapter.Session, strSort, false, bsUse.Position, ref dsUse);
                GC.Collect();
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsUse.Position>=0)
            {
                bsUse.RemoveCurrent();
            }
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUse.EndEdit();
            bsUse.EndEdit();
            
            if (dsUse.GetChanges(DataRowState.Deleted) != null)
                Delete();

            if (dsUse.GetChanges(DataRowState.Modified) != null)
                Modiy();

            if (dsUse.GetChanges(DataRowState.Added) != null)
                Added();

            dsUse.LoadData();

            //bool bAdd = false;
            //if (dsUse.GetChanges() == null)
            //{
            //    return;
            //}

            ////��������
            //if (dsUse.GetChanges(DataRowState.Added) != null)
            //{
            //    string strMessage = "";
            //    for (int i = 0; i < dsUse.GetChanges(DataRowState.Added).Tables[0].Rows.Count; i++)
            //    {
            //        bAdd = true;
            //        string strLadleID = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLEID"].ToString();
            //        string strCheck = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLE_CHECK"].ToString();//LADLE_CHECK�ְ����
            //        string strOff = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["OFF_REASON"].ToString(); //OFF_REASON����

            //        if ((strCheck != "" && strOff != "") || (strCheck == "" && strOff == ""))
            //        {
            //            MessageBox.Show("�ְ���������ԭ������ѡ��һ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return; 
            //        }
            //        //���߼��
            //        if (strCheck != "" && strCheck != "01")
            //        {
            //            if (strMessage != "")
            //                strMessage += "\nȷ�ϣ�" + strLadleID + "���ְ��м�����ά�޹����㣿";
            //            else
            //                strMessage += "ȷ�ϣ�" + strLadleID + "���ְ��м�����ά�޹����㣿";
            //        }
            //        else if (strOff != "")
            //        {
            //            if (strMessage != "")
            //                strMessage += "\nȷ�ϣ�" + strLadleID + "���ְ����ߴ��ޣ�";
            //            else
            //                strMessage += "ȷ�ϣ�" + strLadleID + "���ְ����ߴ��ޣ�";
            //        }
            //    }
            //    if (strMessage != "")
            //        if (!(MessageBox.Show(strMessage, "��ʾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes"))
            //            return;
            //}

            //if (dsUse.UpdateData())
            //{
            //    MessageBox.Show("�����ɹ���", "��ʾ");
            //    dsUse.LoadData();
            //}
            //else
            //{
            //    if (bAdd)
            //    {
            //        MessageBox.Show("����ʧ�ܣ��ְ�״̬���ܲ�Ϊ�ȱ���", "��ʾ");
            //        return;
            //    }
            //    MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            //}
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsUse.RejectChanges();
            dsUse.LoadData();
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
        private void dvUse_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsUse.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ְ�ʹ��ʵ��", dvUse);
        }

        private void LadleUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvUse_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private bool Added()
        {
            for (int i = 0; i < dsUse.GetChanges(DataRowState.Added).Tables[0].Rows.Count; i++)
            {
                string strLadleID = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLEID"].ToString();
                string strCheck = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLE_CHECK"].ToString();//LADLE_CHECK�ְ����
                string strOff = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["OFF_REASON"].ToString(); //OFF_REASON����
                string strActLadleGrade = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["Act_Ladle_Grade"].ToString(); //OFF_REASON����

                if (strLadleID == "")
                {
                    MessageBox.Show("�ְ��Ų���Ϊ�գ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if ((strCheck != "" && strOff != "") || (strCheck == "" && strOff == ""))
                {
                    MessageBox.Show("�ְ���������ԭ������ѡ��һ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (strActLadleGrade == "")
                {
                    MessageBox.Show("ʵ������û��ѡ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            object objAdd = null;
            string strMessage = "";
            if (dsUse.CommitAdded(ref objAdd))
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
                        strMessage = "��ȷ�ϸְ�״̬Ϊ�ȱ���";
                        break;
                    case -3:
                        strMessage = "��鵽����ʹ�ü�¼��ת¯�Ѿ�ָ���ְ��һ�û�г��֣���ȡ��ָ����";
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

        private void Modiy()
        {
            object objMod = null;
            string strMessage = "";
            if (dsUse.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK);
                    return;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "ϵͳæ�����Ժ���";
                        break;
                    case -1:
                        strMessage = "�ְ��Ų���Ϊ�գ�";
                        break;
                    case -3:
                        strMessage = "��鵽�޸�ʹ�ü�¼��ת¯�Ѿ�ָ���ְ��һ�û�г��֣���ȡ��ָ����";
                        break;
                    default:
                        strMessage = "�����쳣�����";
                        break;
                }
            }
            else
                strMessage = "ϵͳæ�����Ժ���";
            MessageBox.Show(strMessage, "�޸�ʧ�ܣ�", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Delete()
        {
            object objDel = null;
            if (dsUse.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
                    return;
                }
                else
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
                    return;
                }
            }
            MessageBox.Show("ϵͳæ�����Ժ���", "��ʾ");
        }

        //ѡ�а�ťʱTrue
        private void SetBtn_AddModDel_Enable_Check(ToolStripButton btnCheck, bool bOperater)
        {
            if (bOperater)
                btnCheck.Checked = bOperater;
            else
            {
                btnAdd.Checked = !bOperater;
                //btnMod.Checked = !bOperater;
                btnDel.Checked = !bOperater;
            }

            btnAdd.Enabled = !bOperater;
            //btnMod.Enabled = !bOperater;
            btnDel.Enabled = !bOperater;
        }

        private void Set_ConfirmCancel_Enable(bool bFlag)
        {
            btnConfirm.Enabled = bFlag;
            btnCancel.Enabled = bFlag;
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string strSql = " Input_Time between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";
            if (strLadleID != "")
            {
                strSql += strLadleID;
            }
            strSql += " order by Input_Time desc,LadleID asc";
            //cmdUse.Parameters[0].ConstantValue = strSql;
            dsUse.SourceCondition = strSql;
            dsUse.LoadData();
        }

        //�ְ����߲�ѯ
        private void btnGBXXQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string strSql = " Input_Time between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";
            if (strLadleID != "")
            {
                strSql += strLadleID;
            }
            strSql += " and OFF_REASON is not null order by Input_Time desc,LadleID asc";
            //cmdUse.Parameters[0].ConstantValue = strSql;
            dsUse.SourceCondition = strSql;
            dsUse.LoadData();

        }


    }
}