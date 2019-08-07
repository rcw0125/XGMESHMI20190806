using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.CCMMag
{
    public partial class CCMScrapDutyFrm : DockContent, IMESForm
    {
        public CCMScrapDutyFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ≥…‘±

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

        private void CCMScrapDutyFrm_Load(object sender, EventArgs e)
        {
            dtTime.Value = DateTime.Now;
            dsWasterData.SourceCondition = "1=2";
            dsWasterData.L3DataAdapter = Adapter;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strHeatID = txtHeatID.Text.Trim();

            DateTime dtS = Convert.ToDateTime(dtTime.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtTime.Text.Trim() + " 23:59:59");
            
            dsWasterData.SourceCondition = "1=2";

            if (strHeatID != "" && strHeatID.Length != 9)
                dsWasterData.SourceCondition = " Waster_Date between '" + dtS + "' and '" + dtE + "' and HeatID like '%" + strHeatID + "%' order by HeatID ";
            else if (strHeatID.Length == 9)
                dsWasterData.SourceCondition = " HeatID like '%" + strHeatID + "%' order by HeatID ";
            else
                dsWasterData.SourceCondition = " Waster_Date between '" + dtS + "' and '" + dtE + "' order by HeatID";
        }

        private void dvWasterData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strHeatID = "";
            try
            {
                bsWasterData.Position = e.RowIndex;
                strHeatID = dvWasterData.Rows[bsWasterData.Position].Cells["HeatID"].Value.ToString();
            }
            catch
            {
                strHeatID = "";
            }
            if (strHeatID != "")
            {
                CCMScrapDutyInfoFrm Frm = new CCMScrapDutyInfoFrm();
                Frm.ShowDialogEx(Adapter.Session, strHeatID);
                GC.Collect();
            }

        }

        private void dvWasterData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvWasterData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvWasterData, "HeatID", "Duty_Flag", "1");
        }

    }
}