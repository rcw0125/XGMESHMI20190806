using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.BulkStore
{
    public partial class BulkAndAreaMapFrm : DockContent, IMESForm
    {
        public BulkAndAreaMapFrm()
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


        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBOF.EndEdit();
            bsBOF.EndEdit();
            dsBOF.UpdateData();
            dsBOF.LoadData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBOF.LoadData();
        }

        private void dvBOF_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvBOF_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BulkAndAreaMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}