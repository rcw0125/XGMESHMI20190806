using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace UnitMag.TAPMag
{
    public partial class TAPHeatFinalDataFrm : DockContent, IMESForm
    {
        public TAPHeatFinalDataFrm()
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

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsHeatData.L3DataAdapter = Adapter;
            string strSourceCondition;
            strSourceCondition = "to_char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "'";
            if (txtHeatID.Text.Trim() == "")
            {
                if (cmbTapID.Text.Length > 0)
                {
                    strSourceCondition = strSourceCondition + " and substr(HeatID,2,1) = '" + cmbTapID.Text.Substring(2, 1) + "'";
                }
                strSourceCondition = strSourceCondition + " order by HeatID";
            }
            else
            {
                if (cmbTapID.Text.Length > 0)
                {
                    strSourceCondition = strSourceCondition + " and substr(HeatID,2,1) = '" + cmbTapID.Text.Substring(2, 1) + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%'";
                }
                else
                {
                    strSourceCondition = strSourceCondition + " and HeatID like '%" + txtHeatID.Text.Trim() + "%'";
                }
                strSourceCondition = strSourceCondition + " order by HeatID";
            }
            dsHeatData.SourceCondition = strSourceCondition;
        }

        private void TAPHeatFinalDataFrm_Load(object sender, EventArgs e)
        {
            dtData.Value = DateTime.Now;
            cmbTapID.Items.Clear();
            for (int i = 0; i < dsUnitID.Tables[0].Rows.Count; i++)
            {
                cmbTapID.Items.Add(dsUnitID.Tables[0].Rows[i]["Code"].ToString());
            }
        }

        private void dvHeatData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strHeatID = dvHeatData.Rows[e.RowIndex].Cells[HeatID.Index].Value.ToString();

            bool check = false;
            if (cbxUpdate.Checked)
            {
                if (Convert.ToBoolean(dvHeatData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                {
                    check = false;
                }
                else
                { 
                    check = true;
                }
            }

            TapHeatInfoFrm Frm = new TapHeatInfoFrm();
            Frm.ShowDialogEx(Adapter.Session, check, strHeatID);
            GC.Collect();
        }

        private void dvHeatData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvHeatData, "HeatID", "Locked", "1");
        }

        private void dvHeatData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //实绩确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dvHeatData.CurrentRow.Cells["Locked"].Value.ToString() == "0" && dvHeatData.SelectedRows.Count == 1)
            {
                dvHeatData.CurrentRow.Cells["Locked"].Value = 1;
                dvHeatData.EndEdit();
                bsHeatData.EndEdit();
                dsHeatData.UpdateData();
            }
        }
    }
}