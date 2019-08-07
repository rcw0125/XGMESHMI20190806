using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.LFMag
{
    public partial class LFHeatGearsQueryFrm : DockContent, IMESForm
    {
        public LFHeatGearsQueryFrm()
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

        private void LFHeatGearsQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
         
            dsBase.SourceCondition = " 1=2";
            string strSQL = "";
            if (txtHeatID.Text.Trim().Length == 9)
                strSQL = " HeatID = '" + txtHeatID.Text.Trim() + "'";
            else
            {
                strSQL = " LogTime between '" + dtS + "' and '" + dtE + "' ";

                if (txtHeatID.Text.Trim().Length < 9 && txtHeatID.Text.Trim().Length > 0)
                    strSQL += " and HeatID like '%" + txtHeatID.Text.Trim() + "%'";
                if (cmbUnitID.Text.Trim() != "")
                    strSQL += " and substr(TreatNo,1,1) =  '" + cmbUnitID.Text.Trim().Substring(2, 1) + "'";
            }
            strSQL += " order by TreatNo ,LogTime";
            dsBase.SourceCondition = strSQL;
        }

      
        private void LFHeatGearsQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("LF炉加热档位数据", dvBase);
        }

        private void dvBase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }
}