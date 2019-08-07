using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;

namespace EquipMag.EquipAdjust
{
    public partial class EquipAdjustSetFrm : DockContent, IMESForm
    {
        public EquipAdjustSetFrm()
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
            btnCancel_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dsAdjustSet.Tables[0].NewRow();
            dsAdjustSet.Tables[0].Rows.Add(row);
        }

        private ArrayList alLocation = new ArrayList();//缓存主键
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            alLocation.Clear();
            dvAdjustSet.EndEdit();
            bsAdjustSet.EndEdit();

            for (int i = 0; i < dvAdjustSet.RowCount; i++)
            {
                if (dvAdjustSet.Rows[i].Cells["locationDataGridViewTextBoxColumn"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + Convert.ToString(i + 1) + "行处所代码为空!", "提示");
                    return;
                }
                if (dvAdjustSet.Rows[i].Cells["locationDesDataGridViewTextBoxColumn"].Value.ToString() == "")
                {
                    MessageBox.Show("第" + Convert.ToString(i + 1) + "行处所描述为空!", "提示");
                    return;
                }
                if (alLocation.Contains(dvAdjustSet.Rows[i].Cells["locationDataGridViewTextBoxColumn"].Value.ToString() + dvAdjustSet.Rows[i].Cells["locationDesDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("第" + Convert.ToString(i + 1) + "行处所、处所描述重复!请检查", "提示");
                    return;
                }
                alLocation.Add(dvAdjustSet.Rows[i].Cells["locationDataGridViewTextBoxColumn"].Value.ToString() + dvAdjustSet.Rows[i].Cells["locationDesDataGridViewTextBoxColumn"].Value.ToString());
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

        private void dvAdjustSet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}