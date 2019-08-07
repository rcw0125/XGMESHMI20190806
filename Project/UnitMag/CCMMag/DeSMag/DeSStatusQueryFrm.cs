using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.DeSMag
{
    public partial class DeSStatusQueryFrm : DockContent, IMESForm
    {
        public DeSStatusQueryFrm()
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

        private void DeSStatusQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            dsEquStatus.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string sql = "";
            if (cmbDeSID.Text == "I部脱硫")
            {
                dsDeSStatus.SourceCondition = "Log_Time between '" + dtS + "' and '" + dtE + "' and DeSID = 1 order by Log_Time desc";
            }
            else if (cmbDeSID.Text == "II部脱硫")
            {
                dsDeSStatus.SourceCondition = "Log_Time between '" + dtS + "' and '" + dtE + "' and DeSID = 2 order by Log_Time desc";
            }
            else
            {
                dsDeSStatus.SourceCondition = "Log_Time between '" + dtS + "' and '" + dtE + "' order by Log_Time desc";
            }
            dsDeSStatus.LoadData();
        }

        private void dvDeSStatus_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnInExl_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("设备状态信息", dvDeSStatus);
        }
    }
}