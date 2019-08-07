using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace BaseDataMag
{
    public partial class AddressWireRelationMagFrm : DockContent, IMESForm
    {
        public AddressWireRelationMagFrm()
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

        private void AddressWireRelationMagFrm_Load(object sender, EventArgs e)
        {
            dsUnitID.SourceMethod = "select Code from CBase_All_Code where (Code_Group = 'LF' or Code_Group = 'RH' or Code_Group = 'Side') and Code is not null order by Code";

            cmbUnitID.Items.Clear();
            cmbUnitID.Items.Add("");
            for (int i = 0; i < dsUnitID.Tables[0].Rows.Count; i++)
            {
                cmbUnitID.Items.Add(dsUnitID.Tables[0].Rows[i]["Code"].ToString());
            }
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnitID.Text != "")
            {
                dsBase.SourceCondition = "UnitID = '" + cmbUnitID.Text.Trim() + "' order by PLC_Address, WireID";
            }
            else
            {
                dsBase.SourceCondition = "UnitID is not null order by PLC_Address,UnitID , WireID";
            }
        }

        private void dvBase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AddressWireRelationMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}