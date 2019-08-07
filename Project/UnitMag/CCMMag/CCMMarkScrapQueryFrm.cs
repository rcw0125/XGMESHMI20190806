using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.CCMMag
{
    public partial class CCMMarkScrapQueryFrm : DockContent, IMESForm
    {
        public CCMMarkScrapQueryFrm()
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
            Adapter.Session = session;
            this.ShowDialog();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strCondition = "1=2";
            dsWaster.SourceCondition = strCondition;

            DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");

            if (txtHeatID.Text.Length != 9)
            {
                strCondition = " Waster_Date between '" + dtS + "' and '" + dtE + "' ";

                if (cmbCasterID.Text != "")
                    strCondition += " and CasterID = '" + txtHeatID.Text.Trim() + "'";

                if (txtHeatID.Text != "")
                    strCondition += " and HeatID like '%" + txtHeatID.Text.Trim() + "%' order by Waster_Date asc";

                strCondition += " order by Waster_Date asc";
            }
            else
                strCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
            dsWaster.SourceCondition = strCondition;
            //dsWaster.LoadData();
        }

        //控件加载
        private void CCMMarkScrapQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢坯甩废信息", dvInStore);
        }

        private void CCMMarkScrapQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}