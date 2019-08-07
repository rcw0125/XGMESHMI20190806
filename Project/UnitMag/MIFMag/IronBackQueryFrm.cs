using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.MIFMag
{
    public partial class IronBackQueryFrm : DockContent, IMESForm
    {
        public IronBackQueryFrm()
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
       
        private void IronBackQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsBFIron.SourceCondition = "1=2";
                DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
                DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
                dsBFIron.SourceCondition = "Back_Time between '" + dtS + "' and '" + dtE + "' order by Back_Time ,Back_Team";
            }
            catch { dsBFIron.SourceCondition = "1=2"; }
        }                                                                                          

        private void dvBFIron_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

   
        private void btnBFIromOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("铁水回退炼铁厂信息", dvBFIron);
        }
    }
}
