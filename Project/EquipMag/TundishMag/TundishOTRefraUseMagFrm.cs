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
    public partial class TundishOTRefraUseMagFrm : DockContent, IMESForm
    {
        private string path = Application.StartupPath;

        public TundishOTRefraUseMagFrm()
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

        //界面加载
        private void TundishOTRefraUseMagFrm_Load(object sender, EventArgs e)
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

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsRefraUse.SourceCondition = "1=2";
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");

            if (cmbTundishID.Text.Trim() == "")
                dsRefraUse.SourceCondition = "Input_Time between '" + dtS + "' and '" + dtE + "' order by Input_Time,TundishID";
            else
                dsRefraUse.SourceCondition = "TundishID = '" + cmbTundishID.Text.Trim() + "' and Input_Time between '" + dtS + "' and '" + dtE + "' order by Input_Time,TundishID";
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("1、2#铸机中包耐材使用实绩信息", dvM);
        }
    }
}