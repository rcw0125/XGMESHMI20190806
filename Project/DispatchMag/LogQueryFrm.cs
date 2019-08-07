using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class LogQueryFrm : DockContent, IMESForm
    {
        public LogQueryFrm()
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

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "";
            DateTime dtS = Convert.ToDateTime(dtNoteData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtNoteEndData.Text.Trim() + " 23:59:59");
            if (cmbShiftID.Text == "")
            {
                strSourceCondition = "CREATEDATE between '" + dtS + "' and '" + dtE + "' order by CREATEDATE asc";
            } 
            else
            {
                strSourceCondition = "CREATEDATE between '" + dtS + "' and '" + dtE + "' and SHIFTID = '" + txtShiftID.Text.Trim() + "' order by CREATEDATE asc";
            }
            dsNotte.SourceCondition = strSourceCondition;
        }

        //控件加载
        private void LogQueryFrm_Load(object sender, EventArgs e)
        {
            dtNoteData.Value = DateTime.Now;
            dtNoteEndData.Value = DateTime.Now;
            for (int i = 0; i < dsShiftID.Tables[0].Rows.Count; i++)
            {
                cmbShiftID.Items.Add(dsShiftID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void cmbShiftID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtShiftID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsShiftID, cmbShiftID.SelectedItem.ToString());
        }

        //导出到EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("调度记事信息", dvInStore);
        }

        private void LogQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
            Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
            DataRow newrow = dsNotte.Tables[0].NewRow();
            newrow["CreateDate"] = DateTime.Now;
            newrow["TeamID"] = objTeamID.ToString();
            newrow["ShiftID"] = objShiftID.ToString();
            dsNotte.Tables[0].Rows.Add(newrow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsNote.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsNotte.LoadData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvInStore.EndEdit();
            bsNote.EndEdit();
            bool returnflag = dsNotte.UpdateData();
            if (returnflag)
            {
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
            dsNotte.LoadData();
        }
    }
}