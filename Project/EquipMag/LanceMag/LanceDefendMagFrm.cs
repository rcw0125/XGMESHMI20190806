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

        #region IMESForm 成员

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

        //控件加载
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

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //添加一行数据，对相应数据进行填充
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
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改信息
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

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position>=0)
            {
                bsM.RemoveCurrent();
            }
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //dvM.EndEdit();
            //bsM.EndEdit();
            //bool bAdd = false;
            //if (dsM.GetChanges(DataRowState.Added) != null)
            //    bAdd = true;
            //if (dsM.UpdateData())
            //{
            //    MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK);
            //    FormQueryString();
            //    return;
            //}
            //if (bAdd)
            //    MessageBox.Show("操作失败,请检查新增信息对应氧枪在其基本信息中是否有\"氧枪制作编号\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //else
            //    MessageBox.Show("操作失败！", "提示");
            dvM.EndEdit();
            bsM.EndEdit();
            if (dsM.GetChanges() == null)
            {
                return;
            }
            DataSet ddddd = dsM.GetChanges(DataRowState.Added);
            bool bSucc = false;
            //删除
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
            //新增
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
                    MessageBox.Show("删除失败！", "提示");
                    return true;
                }
                else
                {
                    MessageBox.Show("删除成功！", "提示");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
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
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK);
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
                    MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }





        //查询
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

        //信息取消
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
                //添加一行数据，对相应数据进行填充
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
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //删除
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
            //新增
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
                    MessageBox.Show("删除失败！", "提示");
                    return true;
                }
                else
                {
                    MessageBox.Show("删除成功！", "提示");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
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
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK);
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
                    MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //主信息换行
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
                            //提示是否保存从信息
                            string strYes = MessageBox.Show("维护实绩已经修改,是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
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