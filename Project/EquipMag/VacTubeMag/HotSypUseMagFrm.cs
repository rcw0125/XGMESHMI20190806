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
    public partial class HotSypUseMagFrm : DockContent, IMESForm
    {
        public HotSypUseMagFrm()
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
        private void HotSpyUseMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbVacTubeID.Items.Clear();
            cmbVacTubeID.Items.Add("");
            if (dsVacTubeID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsVacTubeID.Tables[0].Rows.Count; i++)
                    cmbVacTubeID.Items.Add(dsVacTubeID.Tables[0].Rows[i][0].ToString());
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
                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["On_Time"] = DateTime.Now;
                
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["On_TeamID"] = objTeamID.ToString();
                    newrow["On_ShiftID"] = objShiftID.ToString();
                }
                newrow["On_Operator"] = Adapter.Session.User;
                dsMain.Tables[0].Rows.Add(newrow); 

                bsMain.MoveFirst();//
                while (((System.Data.DataRowView)(bsMain.Current)).Row != newrow && bsMain.Position != dsMain.Tables[0].Rows.Count - 1)
                {
                    bsMain.MoveNext();
                }
                HotSypUseMagShowFrm frm = new HotSypUseMagShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsMain.Position, strSort, ref dsMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改信息
        private void dvM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dsMain.Tables[0].Rows.Count > 0)
            {
                bsMain.Position = e.RowIndex;
                HotSypUseMagShowFrm frm = new HotSypUseMagShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsMain.Position, strSort, ref dsMain);
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
            dvM.EndEdit();
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
            if (cmbVacTubeID.Text != "")
                strCurSql += " and  Hot_Syp_ID = '" + cmbVacTubeID.Text.ToString() + "'";
            strCurSql += " order by Input_Time desc,Hot_Syp_ID asc";

            cmdMain.Parameters[0].ConstantValue = strCurSql;
            dsMain.LoadData();
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
                strSort = ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("热弯管使用实绩", dvM);
        }

        private void HotSpyUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}