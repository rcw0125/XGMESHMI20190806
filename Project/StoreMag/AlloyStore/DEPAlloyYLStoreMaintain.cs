using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.AlloyStore
{
    public partial class DEPAlloyYLStoreMaintain : DockContent, IMESForm
    {
        public DEPAlloyYLStoreMaintain()
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

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
                bsGroundPublic.EndEdit();
                bsPublic.EndEdit();
                dsPublic.UpdateData();
                dsGroundPublic.UpdateData();
                dsPublic.LoadData();
                dsGroundPublic.LoadData();
                MessageBox.Show("保存成功");


 
        }


        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsPublic.LoadData();
     
            dsGroundPublic.LoadData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AlloyAndAreaRHMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void AlloyYLStoreMaintain_Load(object sender, EventArgs e)
        {
        
            dsPublic.LoadData();
            dsGroundPublic.LoadData();
        }

        private void dvPublic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}