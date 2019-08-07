using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag
{
    public partial class EquipmentStatusQueryFrm : DockContent, IMESForm
    {
        public EquipmentStatusQueryFrm()
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

        private void EquipmentStatusQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            dsBase.SourceMethod = "select * from CBOF_Equipment_Status where 1=2";
            if (cmbUnit.Text == "")
            {
                MessageBox.Show("请选择机组！", "提示");
                return;
            }
            //if (cmbCCMID.Text == "")
            //{
            //    MessageBox.Show("请选择工位！","提示");
            //    return;
            //}
            string strSQL = "";
            if (cmbUnit.Text == "转炉")
            {
                strSQL = "select * from CBOF_Equipment_Status where log_time between '" + dtS + "' and '" + dtE + "'";
                if (cmbCCMID.Text != "")
                    strSQL += " and BOFID = '" + cmbCCMID.Text.Substring(2, 1) + "";
                strSQL += " order by log_time";
                //dsBase.SourceMethod = "select * from CBOF_Equipment_Status where BOFID = '" + cmbCCMID.Text.Substring(2, 1) + "' and log_time between '" + dtS + "' and '" + dtE + "' order by log_time";
                dvCCMData.Columns["BOFID"].Visible = true;
                dvCCMData.Columns["LFID"].Visible = false;
                dvCCMData.Columns["RHID"].Visible = false;
                dvCCMData.Columns["CCMID"].Visible = false;
            }
            else   if (cmbUnit.Text == "LF炉")
            {
                strSQL = "select * from CLF_Equipment_Status where log_time between '" + dtS + "' and '" + dtE + "'";
                if (cmbCCMID.Text != "")
                    strSQL += " and BOFID = '" + cmbCCMID.Text.Substring(2, 1) + "";
                strSQL += " order by log_time";
                //dsBase.SourceMethod = "select * from CLF_Equipment_Status where LFID = '" + cmbCCMID.Text.Substring(2, 1) + "' and log_time between '" + dtS + "' and '" + dtE + "' order by log_time";
                dvCCMData.Columns["BOFID"].Visible = false;
                dvCCMData.Columns["LFID"].Visible = true;
                dvCCMData.Columns["RHID"].Visible = false;
                dvCCMData.Columns["CCMID"].Visible = false;
            }
            else if (cmbUnit.Text == "RH炉")
            {
                strSQL = "select * from CRH_Equipment_Status where log_time between '" + dtS + "' and '" + dtE + "'";
                if (cmbCCMID.Text != "")
                    strSQL += " and BOFID = '" + cmbCCMID.Text.Substring(2, 1) + "";
                strSQL += " order by log_time";
                //dsBase.SourceMethod = "select * from CRH_Equipment_Status where RHID = '" + cmbCCMID.Text.Substring(2, 1) + "' and log_time between '" + dtS + "' and '" + dtE + "' order by log_time";
                dvCCMData.Columns["BOFID"].Visible = false;
                dvCCMData.Columns["LFID"].Visible = false;
                dvCCMData.Columns["RHID"].Visible = true;
                dvCCMData.Columns["CCMID"].Visible = false;
            }
            else if (cmbUnit.Text == "铸机")
            {
                strSQL = "select * from CCCM_Equipment_Status where log_time between '" + dtS + "' and '" + dtE + "'";
                if (cmbCCMID.Text != "")
                    strSQL += " and BOFID = '" + cmbCCMID.Text.Substring(2, 1) + "";
                strSQL += " order by log_time";

                //dsBase.SourceMethod = "select * from CCCM_Equipment_Status where CCMID = '" + cmbCCMID.Text.Substring(2, 1) + "' and log_time between '" + dtS + "' and '" + dtE + "' order by log_time";
                dvCCMData.Columns["BOFID"].Visible = false;
                dvCCMData.Columns["LFID"].Visible = false;
                dvCCMData.Columns["RHID"].Visible = false;
                dvCCMData.Columns["CCMID"].Visible = true;
            }
            dsBase.SourceMethod = strSQL;
            //dsBase.AcceptChanges();
        }

        private void dvCCMData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void EquipmentStatusQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUnit.Text == "转炉")
            {
                bsStatus.Filter = "code_group ='BOFUnitEquipStatus'";
                bsStatus.EndEdit();
                dsHeatID.SourceCondition = "code_group = 'BOF' order by code";
                dsHeatID.LoadData();
                cmbCCMID.Items.Clear();
                for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
                {
                    cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
                }

            }
            if (cmbUnit.Text == "LF炉")
            {
                bsStatus.Filter = "code_group ='LFUnitEquipStatus'";
                bsStatus.EndEdit();
                dsHeatID.SourceCondition = "code_group = 'LF' order by code";
                dsHeatID.LoadData();
                cmbCCMID.Items.Clear();
                for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
                {
                    cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
                }

            }
            if (cmbUnit.Text == "RH炉")
            {
                bsStatus.Filter = "code_group ='RHUnitEquipStatus'";
                bsStatus.EndEdit();
                dsHeatID.SourceCondition = "code_group = 'RH' order by code";
                dsHeatID.LoadData();
                cmbCCMID.Items.Clear();
                for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
                {
                    cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
                }

            }
            if (cmbUnit.Text == "铸机")
            {
                bsStatus.Filter = "code_group ='CasterUnitEquipStatus'";
                bsStatus.EndEdit();
                dsHeatID.SourceCondition = "code_group = 'Caster' order by code";
                dsHeatID.LoadData();
                cmbCCMID.Items.Clear();
                for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
                {
                    cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
                }

            }
        }

    }
}