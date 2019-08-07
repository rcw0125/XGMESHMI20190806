using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.CodeMag
{
    public partial class CalWeightMaintenFrm : DockContent, IMESForm
    {
        public CalWeightMaintenFrm()
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


        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMain.Tables[0].NewRow();
            dsMain.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsMain.Position >= 0)
                bsMain.RemoveCurrent();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsMain.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dvCalWeightMainten.EndEdit();
            bsMain.EndEdit();
            dsMain.UpdateData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtLength.Text.Length > 0)
            {
                dsMain.SourceCondition = "Length = " + txtLength.Text;
            }
            else
            {
                dsMain.SourceCondition = "";
            }
        }

        private void CalWeightMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}