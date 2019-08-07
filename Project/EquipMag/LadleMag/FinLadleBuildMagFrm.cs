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
    public partial class FinLadleBuildMagFrm : DockContent, IMESForm
    {
        private string path = Application.StartupPath;

        public FinLadleBuildMagFrm()
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

        private object objShiftID = "";
        private object objTeamID = "";

        private string strcmbLadleID = "";//缓存选择钢包号
        private string strCurLadleID = "";//缓存主信息当前选中钢包号
        //private string strCurMainGuid = "";//缓存主信息当前选择的GUID
        private string strCurWorkID = "";

        private string strSortMain = "";//缓存主信息排序字段及排序方式
        private string strSortDetail = "";//缓存从信息排序字段及排序方式

        //界面加载
        private void FinLadleBuildMagFrm_Load(object sender, EventArgs e)
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

            cmdMain.Parameters[0].ConstantValue = "to_char(Input_Time,'yyyy-mm-dd hh24:mi:ss') between '" + dtStart.Text.Trim() + " 00:00:00' and '" + dtEnd.Text.Trim() + " 23:59:59'";
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询主信息
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string strSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (strcmbLadleID != "")
            {
                strSql += strcmbLadleID;
            }
            strSql += " order by Input_Time desc,LadleID asc";
            cmdMain.Parameters[0].ConstantValue = strSql;
            dsMain.LoadData();
        }

        //新增主信息
        private void btnAddMain_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["Build_Start_Time"] = DateTime.Now;
                //newrow["Build_End_Time"] = DateTime.Now;
                //newrow["Fire_Start_Time"] = DateTime.Now;
                //newrow["Fire_End_Time"] = DateTime.Now;
                //newrow["Thr_Ladle_Time"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsMain.Tables[0].Rows.Add(newrow);
                bsMain.MoveFirst();

                while (((System.Data.DataRowView)(bsMain.Current)).Row != newrow && bsMain.Position < dsMain.Tables[0].Rows.Count - 1)
                {
                    bsMain.MoveNext();
                }
                FinLadleBuildShowFrm FrmMain = new FinLadleBuildShowFrm();
                FrmMain.ShowDialogEx(Adapter.Session, strSortMain, bsMain.Position, ref dsMain);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改主信息
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsMain.Tables[0].Rows.Count > 0)
            {
                bsMain.Position = e.RowIndex;
                FinLadleBuildShowFrm FrmMain = new FinLadleBuildShowFrm();
                FrmMain.ShowDialogEx(Adapter.Session, strSortMain, bsMain.Position, ref dsMain);
                GC.Collect();
            }
        }

        //删除主信息
        private void btnDelMain_Click(object sender, EventArgs e)
        {
            if (bsMain.Position >= 0)
            {
                bsMain.RemoveCurrent();
            }
            
        }

        //主信息保存
        private void btnConfirmMain_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            if (dsMain.GetChanges() == null)
            {
                return;
            }
            bool bSucc = false;
            //删除
            if (dsMain.GetChanges(DataRowState.Deleted) != null)
            {
                if (!Delete_Main())
                {
                    dsMain.LoadData();
                    return;
                }
                else
                    bSucc = true;
            }
            if (dsMain.GetChanges(DataRowState.Modified) != null)
            {
                if (!Modiy_Main())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            //新增
            if (dsMain.GetChanges(DataRowState.Added) != null)
            {
                if (!Added_Main())
                {
                    dsMain.LoadData(); return;
                }
                else
                    bSucc = true;
            }
            if (bSucc)
                dsMain.LoadData();
        }

        private bool Added_Main()
        {
            object objAdd = null;
            string strMessage = "";
            if (dsMain.CommitAdded(ref objAdd))
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
                        strMessage = "钢包基本信息中没有工作层编号！";
                        break;
                    case -3:
                        strMessage = "已经存在当前钢包砌筑信息！";
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

        private bool Modiy_Main()
        {
            object objMod = null;
            if (dsMain.CommitModified(ref objMod))
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

        private bool Delete_Main()
        {
            object objDel = null;
            if (dsMain.CommitDeleted(ref objDel))
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
        //主信息取消
        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            dsMain.LoadData();
        }

        //主信息换行时发生
        private void bsMain_CurrentChanged(object sender, EventArgs e)
        {
            if (dvMain.Rows.Count > 0)
            {
                try
                {
                    strCurWorkID = dvMain.Rows[bsMain.Position].Cells[wORKIDDataGridViewTextBoxColumn.Index].Value.ToString();
                    strCurLadleID = dvMain.Rows[bsMain.Position].Cells[lADLEIDDataGridViewTextBoxColumn.Index].Value.ToString();
                    cmdDetail.Parameters[0].ConstantValue = "WorkID = '" + strCurWorkID + "' order by ChaID"; 
                    if (dsDetail.GetChanges() == null)
                    {
                        dsDetail.Tables[0].Clear();
                        dsDetail.LoadData();
                    }
                    else
                    {
                        //提示是否保存从信息
                        string strYes = MessageBox.Show("修补实绩已被修改,是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                        if (strYes == "Yes")
                        {
                            dsDetail.UpdateData();
                            dsDetail.LoadData();
                        }
                        else
                        {
                            dsDetail.LoadData();
                        }
                    }
                }
                catch
                {
                    dsDetail.Tables[0].Clear();
                }
            }
            else
            {
                strCurLadleID = "";
                dsDetail.Tables[0].Clear();
            }
        }

        //新增详细信息
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (strCurWorkID == "")
                    return;
                int iChaID = 0;
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    int iCurID = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ChaID"].ToString());
                    if (iCurID >= iChaID)
                        iChaID = iCurID;
                }
                iChaID++;
                string strObjectID = strCurWorkID + iChaID.ToString();

                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsDetail.Tables[0].NewRow();

                newrow["Input_Time"] = DateTime.Now;
                newrow["ChaID"] = iChaID;
                newrow["LadleID"] = strCurLadleID;
                newrow["Cha_Slag_Line_Time"] = DateTime.Now;
                newrow["WorkID"] = strCurWorkID;
                newrow["Object_ID"] = strObjectID;
                newrow["Fire_Start_Time"] = DateTime.Now;
                newrow["Fire_End_Time"] = DateTime.Now;
                newrow["Thr_Ladle_Time"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsDetail.Tables[0].Rows.Add(newrow);
                bsDetail.MoveFirst();

                while ((bsDetail.Current as System.Data.DataRowView).Row != newrow || bsDetail.Position < dsDetail.Tables[0].Rows.Count - 1)
                {
                    bsDetail.MoveNext();
                }
                FinLadleDreShowFrm FrmDetail = new FinLadleDreShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, strSortDetail, bsDetail.Position, ref dsDetail);
                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改详细信息 
        private void dvDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsDetail.Tables[0].Rows.Count > 0)
            {
                bsDetail.Position = e.RowIndex;
                FinLadleDreShowFrm FrmDetail = new FinLadleDreShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, strSortDetail, bsDetail.Position, ref dsDetail);
                GC.Collect();
            }
        }

        //删除详细信息
        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            if (bsDetail.Position >= 0)
            {
                bsDetail.RemoveCurrent();
            }
            
        }

        //详细信息保存
        private void btnConfirmDetail_Click(object sender, EventArgs e)
        {
            dvDetail.EndEdit();
            bsDetail.EndEdit();
            if (dsDetail.GetChanges() == null)
            {
                return;
            }
            if (dsDetail.UpdateData())
            {
                MessageBox.Show("修补实绩操作成功！", "提示");
                dsDetail.LoadData();
            }
            else
            {
                MessageBox.Show("修补实绩操作失败！", "提示");
            }
        }

        //详细信息取消
        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            dsDetail.LoadData();
        }

        private void dvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dsMain.GetChanges() != null || dsMain.Tables[0].Rows.Count < 1)
            {
                DetailEnableSet(false);
            }
            else
            {
                DetailEnableSet(true);
            }
        }

        private void dvMain_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortMain = ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

       
        private void dvDetail_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortDetail = ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        //选择钢包Cmb关闭时
        private void cmbLadleID_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbLadleID.Text.ToString() != null && cmbLadleID.Text.ToString() != "")
            {
                strcmbLadleID = " and LadleID = '" + cmbLadleID.Text + "'";
            }
            else
            {
                strcmbLadleID = "";
            }
        }

        //设置详细信息可用性
        private void DetailEnableSet(bool bFlag)
        {
            btnAddDetail.Enabled = bFlag;
            btnDelDetail.Enabled = bFlag;
            dvDetail.Enabled = bFlag;
            btnConfirmDetail.Enabled = bFlag;
            btnCancelDetail.Enabled = bFlag;
        }

        private void FinLadleBuildMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnExlMain_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("精炼钢包砌筑实绩信息", dvMain);　
        }


        private void btnQueryDetail_Click(object sender, EventArgs e)
        {
            FinLadleBuildQueryFrm frm = new FinLadleBuildQueryFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

    }
}