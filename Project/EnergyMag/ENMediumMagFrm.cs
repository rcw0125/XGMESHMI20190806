using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EnergyMag
{
    public partial class ENMediumMagFrm : DockContent, IMESForm
    {
        public ENMediumMagFrm()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            dsBase.UpdateData();
            dsBase.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }
   
    }
}