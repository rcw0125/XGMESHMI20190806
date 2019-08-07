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
    public partial class LanceCheckMagFrm : DockContent, IMESForm
    {
        public LanceCheckMagFrm()
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
        private object objShiftID = "";
        private object objTeamID = "";
        private string strSort = "";

        LanceCheckMagShowFrm frm = new LanceCheckMagShowFrm();

        //控件加载
        private void LanceCheckMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbLanceID.Items.Clear();
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
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsM.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["Off_Date"] = DateTime.Now;
                newrow["Nozzle_Assembly_Date"] = DateTime.Now;
                newrow["Rise_Lance_Date"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();//
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }

                frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
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
                frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
            }
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position >= 0)
            {
                bsM.RemoveCurrent();
            }
        }








        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 注释 [4/20/2011 sunxiaotian]
            //    dvM.EndEdit();
            //    bsM.EndEdit();
            //    bool bAdd = false;
            //    if (dsM.GetChanges(DataRowState.Added) != null)
            //        bAdd = true;
            //    if (dsM.UpdateData())
            //    {
            //        MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK);
            //        FormQueryString();
            //        return;
            //    }
            //    if (bAdd)
            //        MessageBox.Show("操作失败,请检查新增信息对应氧枪在其基本信息中是否有\"氧枪制作编号\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //    else
            //        MessageBox.Show("操作失败！", "提示");
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
            strCurSql = " Input_Time between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS') ";
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
                strSort = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("氧枪检查实绩", dvM);
        }

        private void LanceCheckMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



    }
}