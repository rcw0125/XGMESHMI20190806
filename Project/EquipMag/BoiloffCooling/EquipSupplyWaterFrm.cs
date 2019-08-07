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
    public partial class EquipSupplyWaterFrm : DockContent, IMESForm
    {
        public EquipSupplyWaterFrm()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnergyDataManageFrm_Load(object sender, EventArgs e)
        {
            dtStartTime.Value = DateTime.Now;
            dtEndTime.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
            Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

            DataRow row = dsSupplyWater.Tables[0].NewRow();
            row["Time_Start"] = DateTime.Now;
            row["Time_Stop"] = DateTime.Now;
            row["Time_Blow"] = DateTime.Now;

            if (objShiftID != null && objTeamID != null)
            {
                row["Team"] = objTeamID.ToString();
                row["Shift"] = objShiftID.ToString();
            }

            row["Operator"] = Adapter.Session.User;
            dsSupplyWater.Tables[0].Rows.Add(row);
        }

        private void dvEnergyData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvSupplyWater.EndEdit();
            bsSupplyWater.EndEdit();            

            dsSupplyWater.UpdateData();

            btnQuery_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dvSupplyWater.Rows.Count > 0)
            {
                bsSupplyWater.RemoveCurrent();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsSupplyWater.L3DataAdapter = this.Adapter;
            dsSupplyWater.SourceCondition = "to_char(Time_Start,'yyyy-MM-dd hh24:mi') between '" + dtStartTime.Text.ToString() + "' and '" + dtEndTime.Text.ToString() + "' order by Time_Start asc";
        }
    }
}