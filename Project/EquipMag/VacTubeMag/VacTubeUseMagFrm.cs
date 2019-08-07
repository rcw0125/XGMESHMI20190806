using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeUseMagFrm : DockContent, IMESForm
    {
        public VacTubeUseMagFrm()
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

        private string strSortMain = "";//缓存主信息排序字段及排序方式
        private string strSortDetail = "";//缓存从信息排序字段及排序方式

        private string strInstallID = "";//组装编号
        private string strVacTubeCode = "";//真空槽编号
        private string strUpID = "";
        private string strDownID = "";
        private string strPosition = "";
        

        //控件加载
        private void VacTubeUseMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            //cmbSlotID.Items.Clear();
            //cmbSlotID.Items.Add("");
            //if (dsSlotID.Tables[0].Rows.Count > 0)
            //{
            //    for (int i = 0; i < dsSlotID.Tables[0].Rows.Count; i++)
            //        cmbSlotID.Items.Add(dsSlotID.Tables[0].Rows[i][0].ToString());
            //}
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
                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;

                dsMain.Tables[0].Rows.Add(newrow);

                bsMain.MoveFirst();//
                while (((System.Data.DataRowView)(bsMain.Current)).Row != newrow && bsMain.Position != dsMain.Tables[0].Rows.Count - 1)
                {
                    bsMain.MoveNext();
                }
                VacTubeUseMagShowFrm frm = new VacTubeUseMagShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsMain.Position, strSortMain, ref dsMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改信息
        private void dvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dsMain.Tables[0].Rows.Count > 0)
            {
                bsMain.Position = e.RowIndex;
                VacTubeUseMagShowFrm frm = new VacTubeUseMagShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsMain.Position, strSortMain, ref dsMain);
            }
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsMain.Position >= 0)
                bsMain.RemoveCurrent();
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            dsMain.UpdateData();
            FormQueryString();
        }

        //查询
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (txtVacTubeCode.Text.Trim() != "")
                strCurSql += " and VacTube_Code like '%" + txtVacTubeCode.Text.Trim() + "%'";
            
            cmdpMain.ConstantValue = strCurSql;
            dsMain.LoadData();
        }

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("真空槽组装(使用主)实绩", dvMain);
        }

        private void VacTubeUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutPutDetial_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("真空槽使用详细实绩", dvDetail);
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


        //设置详细信息可用性
        private void DetailEnableSet(bool bFlag)
        {
            btnAddDetail.Enabled = bFlag;
            btnDelDetail.Enabled = bFlag;
            dvDetail.Enabled = bFlag;
            btnConfirmDetail.Enabled = bFlag;
            btnCancelDetail.Enabled = bFlag;
        }

        private void bsMain_CurrentChanged(object sender, EventArgs e)
        {
            if (dvMain.Rows.Count > 0)
            {
                try
                {
                    strInstallID = dvMain.Rows[bsMain.Position].Cells[INSTALL_ID.Index].Value.ToString();
                    strVacTubeCode = dvMain.Rows[bsMain.Position].Cells[VACTUBE_CODE.Index].Value.ToString();
                    strUpID = dvMain.Rows[bsMain.Position].Cells[UP_SLOT_ID.Index].Value.ToString();
                    strDownID = dvMain.Rows[bsMain.Position].Cells[BEL_SLOT_ID.Index].Value.ToString();
                    strPosition = dvMain.Rows[bsMain.Position].Cells[POSITION.Index].Value.ToString();

                    cmdDetail.Parameters[0].ConstantValue = " Install_ID = '" + strInstallID + "' order by INPUT_TIME";

                    if (dsDetail.GetChanges() == null)
                    {
                        dsDetail.Tables[0].Clear();
                        dsDetail.LoadData();
                    }
                    else
                    {
                        //提示是否保存从信息
                        string strYes = MessageBox.Show("使用详细实绩已被修改,是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
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
                strInstallID = "";
                strVacTubeCode = "";
                strUpID = "";
                strDownID = "";
                strPosition = "";
                dsDetail.Tables[0].Clear();
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (strInstallID == "")
                    return;

                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsDetail.Tables[0].NewRow();

                newrow["Input_Time"] = DateTime.Now;
                newrow["Install_ID"] = strInstallID;
                newrow["Position"] = strPosition;
                newrow["VacTube_Code"] = strVacTubeCode;
                newrow["Up_Slot_ID"] = strUpID;
                newrow["Bel_Slot_ID"] = strDownID;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }

                dsDetail.Tables[0].Rows.Add(newrow);
                bsDetail.MoveFirst();

                while ((bsDetail.Current as System.Data.DataRowView).Row != newrow || bsDetail.Position < dsDetail.Tables[0].Rows.Count - 1)
                {
                    bsDetail.MoveNext();
                }

                VacTubeUseInfoShowFrm FrmDetail = new VacTubeUseInfoShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, bsDetail.Position, strSortDetail, ref dsDetail);
                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dsDetail.Tables[0].Rows.Count > 0)
            {
                bsDetail.Position = e.RowIndex;
                VacTubeUseInfoShowFrm FrmDetail = new VacTubeUseInfoShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, bsDetail.Position, strSortDetail, ref dsDetail);
                GC.Collect();
            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            if (bsDetail.Position >= 0)
                bsDetail.RemoveCurrent();
        }

        private void btnConfirmDetail_Click(object sender, EventArgs e)
        {
            dvDetail.EndEdit();
            bsDetail.EndEdit();
            if (dsDetail.GetChanges() == null)
                return;

            dsDetail.UpdateData();
            dsDetail.LoadData();
        }

        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            dsDetail.LoadData();
        }
    }
}