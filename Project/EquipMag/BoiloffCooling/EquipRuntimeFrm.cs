using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.BoiloffCooling
{
    public partial class EquipRuntimeFrm : DockContent, IMESForm
    {
        public EquipRuntimeFrm()
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

        private void EnergyDataManageFrm_Load(object sender, EventArgs e)
        {
            dtStartTime.Value = DateTime.Now;
            dtEndTime.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsRuntime.L3DataAdapter = Adapter;
            dsRuntime.SourceCondition = "to_char(Catch_Time,'yyyy-MM-dd hh24:mi') between '" + dtStartTime.Text.ToString() + "' and '" + dtEndTime.Text.ToString() + "' order by Catch_Time asc";
        }

        private void dvRuntime_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}