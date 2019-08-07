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
    public partial class EmployeeMagFrm : DockContent, IMESForm
    {
        public EmployeeMagFrm()
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
        //private string strCodeGroup = "";

        private void EmployeeMagFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBase.Tables[0].NewRow();
            //newrow["Code_Group"] = dsBase.Tables[0].Rows[0]["Code_Group"];
            //newrow["Code_Group_Des"] = dsBase.Tables[0].Rows[0]["Code_Group_Des"];
            //newrow["Code_Function_Group"] = dsBase.Tables[0].Rows[0]["Code_Function_Group"];
            dsBase.Tables[0].Rows.Add(newrow);
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsBase.Position >= 0)
            {
                bsBase.RemoveCurrent();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit(); 

            bool flag = dsBase.UpdateData();
            if (flag)
            {
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
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

        

        private void dvBase_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (dvBase.Rows.Count < 1)
            //{
            //    btnAdd.Enabled = false;
            //    btnDel.Enabled = false;
            //}
            //else
            //{
            //    btnAdd.Enabled = true;
            //    btnDel.Enabled = true;
            //}
        }

        private void EmployeeMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtOperator.Text.Trim() == "")
            {
                if (txtOperatorName.Text.Trim() == "")
                {
                    dsBase.SourceCondition = "";
                }
                else
                {
                    dsBase.SourceCondition = "Operator_Name like '%" + txtOperatorName.Text.Trim() + "%'";
                }
            }
            else
            {
                if (txtOperatorName.Text.Trim() == "")
                {
                    dsBase.SourceCondition = "Operator like '%" + txtOperator.Text.Trim() + "%'";
                }
                else
                {
                    dsBase.SourceCondition = "Operator_Name like '%" + txtOperatorName.Text.Trim() + "%' and Operator like '%" + txtOperator.Text.Trim() + "%'";
                }
            }
        }
    }
}