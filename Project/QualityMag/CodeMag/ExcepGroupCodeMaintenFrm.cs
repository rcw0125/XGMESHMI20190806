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
    public partial class ExcepGroupCodeMaintenFrm : DockContent, IMESForm
    {
        public ExcepGroupCodeMaintenFrm()
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
            DataRow newrow = dsExcepGroupCodeMainten.Tables[0].NewRow();
            dsExcepGroupCodeMainten.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            bsExcepGroupCodeMainten.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvExcepGroupCodeMainten.EndEdit();
            bsExcepGroupCodeMainten.EndEdit();
            dsExcepGroupCodeMainten.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsExcepGroupCodeMainten.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcepGroupCodeMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}