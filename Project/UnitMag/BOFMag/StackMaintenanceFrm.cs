using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.BOFMag
{
    public partial class StackMaintenanceFrm : DockContent, IMESForm
    {
        public StackMaintenanceFrm()
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

        private void StackMaintenanceFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            //cmbTeamID.Items.Clear();
            //for (int i = 0; i < dsTeamID.Tables[0].Rows.Count; i++)
            //    cmbTeamID.Items.Add(dsTeamID.Tables[0].Rows[i]["Code_Des"].ToString());
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsData.SourceCondition = "1=2";
                DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
                DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
                dsData.SourceCondition = "ProductionDate between '" + dtS + "' and '" + dtE + "' order by ProductionDate ,Team";
            }
            catch { dsData.SourceCondition = "1=2"; }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("炉衬维护信息", dvData);
        }

        private void dvData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        

    }
}