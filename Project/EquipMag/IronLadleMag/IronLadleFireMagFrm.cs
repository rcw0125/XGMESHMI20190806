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

        //控件加载
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
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsFireInfo.Position>=0)
            {
                bsFireInfo.RemoveCurrent();
            }
            
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvFireInfo.EndEdit();
            bsFireInfo.EndEdit();
            bool bSucc = false;
            //删除
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
            //新增
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

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        //双击弹出修改
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

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        //查询
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
            CommDataMag.CommonMethed.PutIntoExcel("铁包烘烤实绩", dvFireInfo);
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
                    MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "操作失败！";
                        break;
                    case -1:
                        strMessage = "没有铁包号或烘烤类型或烘烤次数，不允许新增！";
                        break;
                    case -2:
                        strMessage = "烘烤次数比基本信息中烘烤次数高，操作不允许！";
                        break;
                    case -3:
                        strMessage = "烘烤记录已存在，不允许新增！";
                        break;
                    default:
                        strMessage = "系统原因，当前不能新增！";
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

        private bool Modiy()
        {
            object objMod = null;
            string strMessage = "";
            if (dsFireInfo.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                    return true;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "系统忙，请稍候处理！";
                        break;
                    case -1:
                        strMessage = "当前修改记录没有关键字(可能没有刷新)！";
                        break;
                    case -2:
                        strMessage = "当前修改记录没有铁包号或烘烤次数或烘烤类型！";
                        break;
                    case -3:
                        strMessage = "烘烤次数比基本信息中烘烤次数高，操作不允许！";
                        break;
                    case -5:
                        strMessage = "不允许修改，已经存在想要修改到的记录！";
                        break;
                    case -6:
                        strMessage = "删除原有记录失败！";
                        break;
                    default:
                        strMessage = "出现异常情况！";
                        break;
                }
            }
            else
                strMessage = "系统忙，请稍候处理！";
            MessageBox.Show(strMessage, "修改失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool Delete()
        {
            object objDel = null;
            if (dsFireInfo.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("删除失败！", "提示");
                    return false;
                }
                else
                {
                    MessageBox.Show("删除成功！", "提示");
                    return true;
                }
            }
            MessageBox.Show("系统忙，请稍候处理！", "提示");
            return false;
        }
    }
}