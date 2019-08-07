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
    public partial class LanceDefendMagFrm : DockContent, IMESForm
    {
        public LanceDefendMagFrm()
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
        private string strSortM = "";
        private string strSortP = "";

        private string strdvLanceID = "";
        private string strdvMakeID = "";
        private string strType = "";

        //�ؼ�����
        private void LanceDefendMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            string strSql = " Input_Time between '" + dtStart.Value + "' and '" + dtEnd.Value + "'";

            cmdM.Parameters[0].ConstantValue = strSql;
         

            cmbLanceID.Items.Clear();
            cmbLanceID.Items.Add("");
            if (dsLanceID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsLanceID.Tables[0].Rows.Count; i++)
                {
                    cmbLanceID.Items.Add(dsLanceID.Tables[0].Rows[i][0].ToString());
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
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsM.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["Check_Date"] = DateTime.Now;
                newrow["ShiftID"] = "2";

                newrow["Operator"] = Adapter.Session.User;

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();//
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }

                LanceMakeMagShowFrm MakeFrm = new LanceMakeMagShowFrm();
                MakeFrm.ShowDialogEx(Adapter.Session, bsM.Position, strSortM, ref dsM);
                //dsM.Tables[0].Rows[bsM.Position]["makeid"] = MakeFrm.makeid;
                //dsM.AcceptChanges();
                //GC.Collect();
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
                LanceMakeMagShowFrm MakeFrm = new LanceMakeMagShowFrm();
                MakeFrm.ShowDialogEx(Adapter.Session, bsM.Position, strSortM, ref dsM);
                GC.Collect();
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

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortM = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            try
            {
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsP.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["Check_Date"] = DateTime.Now;
                newrow["Lance_Head_Type"] = strType;
                newrow["LanceID"] = strdvLanceID; ;
                newrow["MakeID"] = strdvMakeID;
                newrow["ShiftID"] = "2";
                newrow["Operator"] = Adapter.Session.User;

                dsP.Tables[0].Rows.Add(newrow);

                bsP.MoveFirst();//
                while (((System.Data.DataRowView)(bsP.Current)).Row != newrow && bsP.Position != dsP.Tables[0].Rows.Count - 1)
                {
                    bsP.MoveNext();
                }
                LanceDefendMagShowFrm DefendFrm = new LanceDefendMagShowFrm();
                DefendFrm.ShowDialogEx(Adapter.Session, bsP.Position, strSortP, ref dsP);
                //GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            if (bsP.Position>=0)
            {
                bsP.RemoveCurrent();
            }
            
        }

        private void btnConfirmP_Click(object sender, EventArgs e)
        {
            dvP.EndEdit();
            bsP.EndEdit();

            if (dsP.GetChanges() == null)
            {
                return;
            }
            DataSet ddddd = dsP.GetChanges(DataRowState.Added);
            bool bSucc = false;
            //ɾ��
            if (dsP.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete_Main1())
                {
                    dsP.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsP.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy_Main1())
                {
                    dsP.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //����
            if (dsP.GetChanges(DataRowState.Added) != null)
            {
                if (!Added_Main1())
                {
                    dsP.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                dsP.LoadData();
        }
        // insert [4/20/2011 sunxiaotian]
        private bool Delete_Main1()
        {
            object objDel = null;
            if (dsP.CommitDeleted(ref objDel))
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
        private bool Modiy_Main1()
        {
            object objMod = null;
            if (dsP.CommitModified(ref objMod))
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
        private bool Added_Main1()
        {
            object objAdd = null;
            if (dsP.CommitAdded(ref objAdd))
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







        private void btnCancelP_Click(object sender, EventArgs e)
        {
            dsP.LoadData();
        }

        private void dvP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsM.Tables[0].Rows.Count > 0)
            {
                bsP.Position = e.RowIndex;
                LanceDefendMagShowFrm DefendFrm = new LanceDefendMagShowFrm();
                DefendFrm.ShowDialogEx(Adapter.Session, bsP.Position, strSortP, ref dsP);
                GC.Collect();
            }
        }

        //����Ϣ����
        private void bsM_CurrentChanged(object sender, EventArgs e)
        {
            if (dvM.Rows.Count > 0)
            {
                try
                {
                    if (dvM.Rows[bsM.Position].Cells[mAKEIDDataGridViewTextBoxColumn.Index].Value == null)
                    {
                        dsP.Tables[0].Clear();
                        return;
                    }
                    if (strdvMakeID == dvM.Rows[bsM.Position].Cells[mAKEIDDataGridViewTextBoxColumn.Index].Value.ToString())
                    {
                        return;
                    }
                    else
                    {
                        strdvMakeID = dvM.Rows[bsM.Position].Cells[mAKEIDDataGridViewTextBoxColumn.Index].Value.ToString();
                        strdvLanceID = dvM.Rows[bsM.Position].Cells[lANCEIDDataGridViewTextBoxColumn .Index ].Value.ToString();
                        strType = dvM.Rows[bsM.Position].Cells[lANCEHEADTYPEDataGridViewTextBoxColumn.Index].Value.ToString();
                        cmdP.Parameters[0].ConstantValue = "MakeID = '" + strdvMakeID + "' order by Input_Time";
                        if (dsP.GetChanges() == null)
                        {
                            dsP.Tables[0].Clear();
                            dsP.LoadData();
                        }
                        else
                        {
                            //��ʾ�Ƿ񱣴����Ϣ
                            string strYes = MessageBox.Show("ά��ʵ���Ѿ��޸�,�Ƿ񱣴棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                            if (strYes == "Yes")
                            {
                                btnConfirmP_Click(sender, e);
                                
                            }
                            else
                            {
                                dsP.LoadData();
                            }
                        }
                    }
                }
                catch
                {
                    dsP.Tables[0].Clear();
                }
            }
            else
            {
                strdvMakeID = "";
                strdvLanceID = "";
                dsP.Tables[0].Clear();
            }
        }

        private void DetailEnableSet(bool bFlag)
        {
            btnAddP.Enabled = bFlag;
            btnDelP.Enabled = bFlag;
            dvP.Enabled = bFlag;
            btnConfirmP.Enabled = bFlag;
            btnCancelP.Enabled = bFlag;
        }

        private void dvM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dsM.GetChanges() != null || dsM.Tables[0].Rows.Count < 1)
            {
                DetailEnableSet(false);
            }
            else
            {
                DetailEnableSet(true);
            }
        }

        private void dvP_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortP = ((System.Data.DataRowView)(bsP.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void LanceDefendMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}