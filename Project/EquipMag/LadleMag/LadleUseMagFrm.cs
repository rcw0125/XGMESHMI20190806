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
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改信息
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

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsUse.Position>=0)
            {
                bsUse.RemoveCurrent();
            }
        }

        //信息保存
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

            ////存在新增
            //if (dsUse.GetChanges(DataRowState.Added) != null)
            //{
            //    string strMessage = "";
            //    for (int i = 0; i < dsUse.GetChanges(DataRowState.Added).Tables[0].Rows.Count; i++)
            //    {
            //        bAdd = true;
            //        string strLadleID = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLEID"].ToString();
            //        string strCheck = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLE_CHECK"].ToString();//LADLE_CHECK钢包检查
            //        string strOff = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["OFF_REASON"].ToString(); //OFF_REASON下线

            //        if ((strCheck != "" && strOff != "") || (strCheck == "" && strOff == ""))
            //        {
            //            MessageBox.Show("钢包检查和下线原因至少选择一个！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return; 
            //        }
            //        //下线检查
            //        if (strCheck != "" && strCheck != "01")
            //        {
            //            if (strMessage != "")
            //                strMessage += "\n确认＂" + strLadleID + "＂钢包中间下线维修工作层？";
            //            else
            //                strMessage += "确认＂" + strLadleID + "＂钢包中间下线维修工作层？";
            //        }
            //        else if (strOff != "")
            //        {
            //            if (strMessage != "")
            //                strMessage += "\n确认＂" + strLadleID + "＂钢包离线待修？";
            //            else
            //                strMessage += "确认＂" + strLadleID + "＂钢包离线待修？";
            //        }
            //    }
            //    if (strMessage != "")
            //        if (!(MessageBox.Show(strMessage, "提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes"))
            //            return;
            //}

            //if (dsUse.UpdateData())
            //{
            //    MessageBox.Show("操作成功！", "提示");
            //    dsUse.LoadData();
            //}
            //else
            //{
            //    if (bAdd)
            //    {
            //        MessageBox.Show("操作失败，钢包状态可能不为热备！", "提示");
            //        return;
            //    }
            //    MessageBox.Show("操作失败！", "提示");
            //}
        }

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsUse.RejectChanges();
            dsUse.LoadData();
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
            CommDataMag.CommonMethed.PutIntoExcel("钢包使用实绩", dvUse);
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
                string strCheck = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["LADLE_CHECK"].ToString();//LADLE_CHECK钢包检查
                string strOff = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["OFF_REASON"].ToString(); //OFF_REASON下线
                string strActLadleGrade = dsUse.GetChanges(DataRowState.Added).Tables[0].Rows[0]["Act_Ladle_Grade"].ToString(); //OFF_REASON下线

                if (strLadleID == "")
                {
                    MessageBox.Show("钢包号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if ((strCheck != "" && strOff != "") || (strCheck == "" && strOff == ""))
                {
                    MessageBox.Show("钢包检查和下线原因至少选择一个！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (strActLadleGrade == "")
                {
                    MessageBox.Show("实绩包况没有选择！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        strMessage = "请确认钢包状态为热备！";
                        break;
                    case -3:
                        strMessage = "检查到新增使用记录中转炉已经指定钢包且还没有出钢，请取消指定！";
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

        private void Modiy()
        {
            object objMod = null;
            string strMessage = "";
            if (dsUse.CommitModified(ref objMod))
            {
                int iRet = Convert.ToInt16(objMod);
                if (iRet > 0)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                    return;
                }
                switch (iRet)
                {
                    case 0:
                        strMessage = "系统忙，请稍候处理！";
                        break;
                    case -1:
                        strMessage = "钢包号不能为空！";
                        break;
                    case -3:
                        strMessage = "检查到修改使用记录中转炉已经指定钢包且还没有出钢，请取消指定！";
                        break;
                    default:
                        strMessage = "出现异常情况！";
                        break;
                }
            }
            else
                strMessage = "系统忙，请稍候处理！";
            MessageBox.Show(strMessage, "修改失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Delete()
        {
            object objDel = null;
            if (dsUse.CommitDeleted(ref objDel))
            {
                if (Convert.ToInt16(objDel) <= 0)
                {
                    MessageBox.Show("删除失败！", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("删除成功！", "提示");
                    return;
                }
            }
            MessageBox.Show("系统忙，请稍候处理！", "提示");
        }

        //选中按钮时True
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

        //查询
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

        //钢包下线查询
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