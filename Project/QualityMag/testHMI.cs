using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag
{
    public partial class testHMI : DockContent, IMESForm
    {
        public testHMI()
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
        private void steelGradeIndexChanged()
        {
            string strSteelGradeIndex;
            strSteelGradeIndex = txtSteelGradeIndex.Text;
            string sql;
            sql = "select steelgrade,protocol from CQA_SteelGradeIndex_R where steelgradeindex='" + strSteelGradeIndex + "'";
            dsGrid.SourceMethod = sql;
        }

        
        private void txtSteelGradeIndex_TextChanged_1(object sender, EventArgs e)
        {
            steelGradeIndexChanged();
        }
    }
}