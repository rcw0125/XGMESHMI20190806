using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.EquipAdjust.EquipRunCheckManage
{
    public partial class EquipCoilCheckFrm : DockContent, IMESForm
    {
        public EquipCoilCheckFrm()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnergyDataManageFrm_Load(object sender, EventArgs e)
        {
            dsStatus.Tables[0].Rows.Add();
            dsStatus.Tables[0].Rows.Add();
            dsStatus.Tables[0].Rows[0]["ID"] = 0;
            dsStatus.Tables[0].Rows[1]["ID"] = 1;
            dsStatus.Tables[0].Rows[0]["Desc"] = "合格";
            dsStatus.Tables[0].Rows[1]["Desc"] = "不合格";

            dsAdjustSet.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dsAdjustSet.Tables[0].NewRow();
            row["Check_Date"] = DateTime.Now.ToString("yyyy-MM-dd");
            row["Operator"] = Adapter.Session.User;
            row["Status"] = 0;
            dsAdjustSet.Tables[0].Rows.Add(row);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvAdjustSet.EndEdit();
            bsAdjustSet.EndEdit();
            for (int i = 0; i < dvAdjustSet.RowCount; i++)
            {
                if (dvAdjustSet.Rows[i].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("铸机号不能为空!","提示");
                    return;
                } 
                if (dvAdjustSet.Rows[i].Cells[1].Value.ToString() == "")
                {
                    MessageBox.Show("流号不能为空!","提示");
                    return;
                } 
                if (dvAdjustSet.Rows[i].Cells["createTimeDataGridViewTextBoxColumn"].Value.ToString() == "")
                    dvAdjustSet.Rows[i].Cells["createTimeDataGridViewTextBoxColumn"].Value = DateTime.Now;
            }
            dsAdjustSet.UpdateData();
            dsAdjustSet.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsAdjustSet.LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dvAdjustSet.Rows.Count > 0)
            {
                bsAdjustSet.RemoveCurrent();
            }
        }

        private void dvAdjustSet_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dvAdjustSet.RowCount > 0)
            {
                dsAdjustStd.Tables[0].Clear();
                dsAdjustStd.LoadData();
                if (dvAdjustSet.CurrentRow.Cells[0].Value.ToString() != "" && dvAdjustSet.CurrentRow.Cells[1].Value.ToString() != "")
                {
                    dsAdjustStd.SourceCondition = "AdjustType = '1' and UnitID = '" +
                        dvAdjustSet.CurrentRow.Cells[0].Value.ToString() + "' and AdjustObject = '" +
                        dvAdjustSet.CurrentRow.Cells[1].Value.ToString() + "'";

                    if (dsAdjustStd.Tables[0].Rows.Count > 0)
                        dvAdjustSet.CurrentRow.Cells["elecIntensityStdDataGridViewTextBoxColumn"].Value = dsAdjustStd.Tables[0].Rows[0]["Standard"].ToString();
                    else
                        dvAdjustSet.CurrentRow.Cells["elecIntensityStdDataGridViewTextBoxColumn"].Value = "";
                }
            }
        }

        private void dvAdjustSet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}