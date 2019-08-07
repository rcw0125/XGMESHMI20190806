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
    public partial class BigWaterGapQueryFrm : DockContent, IMESForm
    {
        public BigWaterGapQueryFrm()
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


        public void ShowDialogEx(AppSvrIF.Session session)
        {
            this.Adapter.Session = session;
            this.ShowDialog();
        }

        private void BigWaterGapQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;

            cmbCCMID.Items.Clear();
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
                cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsBase.SourceMethod = "";
            string strSql = "";
            strSql = "select a.*,b.SteelGrade from CCCM_BigWaterGap a,CCCM_BASE_DATA b where ";
            if (txtHeatID.Text.Length == 9)
            {
                dsBase.SourceMethod = strSql + " a.heatid = '" + txtHeatID.Text.Trim() + "' AND a.heatid = b.heatid  order by a.ChangeTime";
                return;
            }
            DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");

            strSql += " a.ChangeTime between '" + dtS + "' and '" + dtE + "'";

            if (cmbCCMID.Text.Length > 0)
                strSql += " and a.CCMID = '" + cmbCCMID.Text.Trim() + "'";

            if (txtHeatID.Text.Length < 9 && txtHeatID.Text.Length > 0)
                strSql += " and a.HeatID like '%" + txtHeatID.Text.Trim() + "%'";

            strSql += " AND a.heatid = b.heatid  order by a.ChangeTime";

            dsBase.SourceMethod = strSql;
        }

        private void dvCCMData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BigWaterGapQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("大包水口使用实绩", dvCCMData);
        }
    }
}