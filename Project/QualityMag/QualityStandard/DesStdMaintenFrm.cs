using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityStandard
{
    public partial class DesStdMaintenFrm : DockContent, IMESForm
    {
        public DesStdMaintenFrm()
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
            DataRow newrow = dsDesStdMainten.Tables[0].NewRow();
            newrow["Valid_Date"] = System.DateTime.Now;
            dsDesStdMainten.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            bsDesStdMainten.RemoveCurrent();
            bsDesStdMainten.EndEdit();
            dsDesStdMainten.UpdateData();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvDesStdMainten.EndEdit();
            bsDesStdMainten.EndEdit();
            dsDesStdMainten.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsDesStdMainten.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void DesStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "Des_Proc_Mod like '%" + txtDesProcMod.Text.Trim() + "%'";
            dsDesStdMainten.SourceCondition = strSourceCondition;
        }

        private void dvDesStdMainten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}