using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace PlanMag
{
    public partial class DispAccountFrm : DockContent, IMESForm
    {
        public DispAccountFrm()
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
            Adapter.Session = session;
            this.ShowDialog();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "";
            DateTime dtS = Convert.ToDateTime(dtNoteData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtNoteEndData.Text.Trim() + " 23:59:59");
            if (cmbAccountType.Text == "")
            {
                strSourceCondition = "ProductDate >= '" + dtNoteData.Text.Trim() + "' and ProductDate <= '" + dtNoteEndData.Text.Trim() + "'" ;//between '" + dtS + "' and '" + dtE + "' order by ProductDate desc";
            } 
            else
            {
                strSourceCondition = "ProductDate >= '" + dtNoteData.Text.Trim() + "' and  ProductDate <='" + dtNoteEndData.Text.Trim() + "' and AccountType = '" + txtAccountType.Text.Trim() + "' order by ProductDate desc";
            }
            //dsNotte.SourceCondition = strSourceCondition;
            dsDispAccount.SourceCondition = strSourceCondition;
        }

        //控件加载
        private void DispAccountFrm_Load(object sender, EventArgs e)
        {
            dtNoteData.Value = DateTime.Now;
            dtNoteEndData.Value = DateTime.Now;
            for (int i = 0; i < dsAccountType.Tables[0].Rows.Count; i++)
            {
                cmbAccountType.Items.Add(dsAccountType.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void cmbShiftID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAccountType.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsAccountType, cmbAccountType.SelectedItem.ToString());
            dvDispAccount.Columns["AccountCount"].HeaderText = cmbAccountType.Text + "次数";
            if (cmbAccountType.Text == "回炉")
            {
                dvDispAccount.Columns["AccountAmount"].Visible = true;
                dvDispAccount.Columns["AccountAmount"].HeaderText = cmbAccountType.Text + "吨数";
            }
            else
            {
                dvDispAccount.Columns["AccountAmount"].Visible = false;
            }

            dvDispAccount.Columns["AccountReason"].HeaderText = cmbAccountType.Text + "原因";
            dvDispAccount.Columns["Responsibility_Organ"].HeaderText = cmbAccountType.Text + "责任单位";
        }
                
        private void DispAccountFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsDispAccount.Tables[0].NewRow();
            newrow["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd");
            newrow["ProductDate"] = DateTime.Now.ToString("yyyy-MM-dd");
            newrow["AccountType"] = txtAccountType.Text.Trim();
            newrow["AccountCount"] = 0;
            newrow["AccountAmount"] = 0;
            dsDispAccount.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsDispAccount.RemoveCurrent();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsDispAccount.LoadData();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvDispAccount.EndEdit();
            bsDispAccount.EndEdit();
           bool returnflag =  dsDispAccount.UpdateData();
           if (returnflag)
           {
               MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
           }
           else
           {
               MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
           }
           dsDispAccount.LoadData();
        }

        private void dvDispAccount_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}


              
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
   
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             