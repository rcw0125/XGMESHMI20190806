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

        private string strLadleID = "";
        private string strSort = "";

        private object objShiftID = "";
        private object objTeamID = "";

        //控件加载
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

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询
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

        //新增信息
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

        //修改信息
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsInnerBuildInfos.Tables[0].Rows.Count > 0)
            {
                LadleInnerBuildMagShowFrm Frm = new LadleInnerBuildMagShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsInnerBuildInfos.Position, ref dsInnerBuildInfos);
                GC.Collect();
            }
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsInnerBuildInfos.Position>=0)
            {
                bsInnerBuildInfos.RemoveCurrent();
            }
            
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsInnerBuildInfos.EndEdit();
            bool bSucc = false;
            //删除
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
            //新增
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

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsInnerBuildInfos.LoadData();
        }

        //选择钢包Cmb关闭时
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

        //排序
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
            CommDataMag.CommonMethed.PutIntoExcel("钢包永久层砌筑实绩", dvM);
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
                    MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "系统忙，请稍候处理！";
                        break;
                    case -1:
                        strMessage = "钢包号不能为空！";
                        break;
                    case -2:
                        strMessage = "已经存在永久层砌筑信息！";
                        break;
                    default:
                        strMessage = "出现异常情况！";
                        break;
                }
                MessageBox.Show(strMessage, "新增失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("系统忙，请稍候处理！", "新增失败！", MessageBoxButtons.OK);
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

        private bool Delete()
        {
            object objDel = null;
            if (dsInnerBuildInfos.CommitDeleted(ref objDel))
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
                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}