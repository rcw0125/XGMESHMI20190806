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
    public partial class CCMMakeProductFrm : DockContent, IMESForm
    {
        public CCMMakeProductFrm()
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

        private AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();

        private void CCMMakeProductFrm_Load(object sender, EventArgs e)
        {
            //[20090102Liao]
            cmbCasterID.Items.Clear();
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
            {
                cmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i][0].ToString());
            }
            cmbCasterID.SelectedIndex = 0;
            dsSend = (AppSvrHMI.L3DataSet)dsHeatData.Clone();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CCMHeatPathFrm Frm = new CCMHeatPathFrm();
            dsSend.Tables[0].Clear();
            int iRowIndex = dsHeatData.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsHeatData.Current)).Row);
            dsSend.Tables[0].ImportRow(dsHeatData.Tables[0].Rows[iRowIndex]);
            Frm.ShowDialogEx(Adapter.Session, dsSend);
            dsHeatData.L3DataAdapter = Adapter;
            dsHeatData.LoadData();
            dsHeatData.L3DataAdapter = null;
        }

        private void txtCuttingEvent_TextChanged(object sender, EventArgs e)
        {
            dsHeatData.L3DataAdapter = Adapter;
            dsHeatData.LoadData();
            dsHeatData.L3DataAdapter = null;
        }

        private void dvHeatData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvHeatData.Rows.Count < 1)
            {
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }

        //选择铸机号过滤炉次信息
        private void cmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dsHeatData.L3DataAdapter = Adapter;
                dsHeatData.LoadData();
                dsHeatData.L3DataAdapter = null;
                bsHeatData.Filter = "CasterID = '" + cmbCasterID.Text.Trim() + "'";
            }
            catch { }
        }

        private void dvHeatData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}