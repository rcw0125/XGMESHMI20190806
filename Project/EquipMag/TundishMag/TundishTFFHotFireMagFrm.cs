using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.TundishMag
{
    public partial class TundishTFFHotFireMagFrm : DockContent, IMESForm
    {
        public TundishTFFHotFireMagFrm()
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

        //控件加载
        private void TundishTFFHotFireMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            cmbTundishID.Items.Clear();
            dsTundishID.SourceCondition = "TundishID is not null order by TundishID";
            for (int i = 0; i < dsTundishID.Tables[0].Rows.Count; i++)
            {
                cmbTundishID.Items.Add(dsTundishID.Tables[0].Rows[i][0].ToString());
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
            if (cmbTundishID.Text.Trim() == "")
            {
                dsFireInfo.SourceCondition = "Small_Start_Time between '" + dtS + "' and '" + dtE + "' order by Small_Start_Time asc";
            }
            else
            {
                dsFireInfo.SourceCondition = "TundishID = '" + cmbTundishID.Text.Trim() + "' and Small_Start_Time between '" + dtS + "' and '" + dtE + "' order by Small_Start_Time asc";
            }
        }

        //导出到EXL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("中包工作层烘烤实绩信息", dvFireInfo);
        }

        private void dvFireInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}