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
    public partial class EquipAdjustParaStdFrm : DockContent, IMESForm
    {
        public EquipAdjustParaStdFrm()
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
            dsAdjustSet.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dsAdjustSet.Tables[0].NewRow();
            dsAdjustSet.Tables[0].Rows.Add(row);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvAdjustSet.EndEdit();
            bsAdjustSet.EndEdit();
            ArrayList al = new ArrayList();
            string strMain = "";//自定义伪主键
            for (int i = 0; i < dvAdjustSet.RowCount; i++)
            {
                if (dvAdjustSet.Rows[i].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("分类不能为空!", "提示");
                    return;
                }
                if (dvAdjustSet.Rows[i].Cells[1].Value.ToString() == "")
                {
                    MessageBox.Show("工位不能为空!", "提示");
                    return;
                }
                if (dvAdjustSet.Rows[i].Cells[3].Value.ToString() == "")
                {
                    MessageBox.Show("项目不能为空!", "提示");
                    return;
                }
                strMain = dvAdjustSet.Rows[i].Cells[0].Value.ToString() + dvAdjustSet.Rows[i].Cells[1].Value.ToString()
                        + dvAdjustSet.Rows[i].Cells[2].Value.ToString() + dvAdjustSet.Rows[i].Cells[3].Value.ToString();
                if (al.Contains(strMain))
                {
                    MessageBox.Show("有相同标准存在!请检查","提示");
                    return;                    
                }
                al.Add(strMain);                
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