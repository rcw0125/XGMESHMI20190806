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
    public partial class EquipCleaningDataFrm : DockContent, IMESForm
    {
        public EquipCleaningDataFrm()
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

            dsCode.Tables[0].Rows.Add("101", "1#汽包排污事件");
            dsCode.Tables[0].Rows.Add("102", "2#汽包排污事件");
            dsCode.Tables[0].Rows.Add("103", "3#汽包排污事件");
            dsCode.Tables[0].Rows.Add("104", "4#汽包排污事件");
            dsCode.Tables[0].Rows.Add("105", "1#烟道排污事件");
            dsCode.Tables[0].Rows.Add("106", "2#烟道排污事件");
            dsCode.Tables[0].Rows.Add("107", "3#烟道排污事件");
            dsCode.Tables[0].Rows.Add("108", "4#烟道排污事件");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsCleaningData.SourceCondition = "1=2";


                DateTime dtS = Convert.ToDateTime(dtStartTime.Text);
                DateTime dtE = Convert.ToDateTime(dtEndTime.Text + " 23:59:59");

                string strID = "";
                string strCondition = "Desc = '" + cmbTagName.Text + "'";
                DataRow[] DataRowTempTotal = dsCode.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                    strID = DataRowTemp["ID"].ToString();

                if (strID != "")
                    dsCleaningData.SourceCondition = "Catch_Time between '" + dtS + "' and '" + dtE + "' and TagName like '" + strID + "%'  order by Catch_Time,TagName";
                else
                    dsCleaningData.SourceCondition = "Catch_Time between '" + dtS + "' and '" + dtE + "' order by Catch_Time,TagName";
            }
            catch { }
        }

        private void dvCleaningData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}