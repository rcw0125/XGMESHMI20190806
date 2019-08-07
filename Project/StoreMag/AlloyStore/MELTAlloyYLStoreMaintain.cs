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
    public partial class MELTAlloyYLStoreMaintain : DockContent, IMESForm
    {
        public MELTAlloyYLStoreMaintain()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
                bsGroundPublic.EndEdit();
                bsPublic.EndEdit();
                dsPublic.UpdateData();
                dsGroundPublic.UpdateData();
                dsPublic.LoadData();
                dsGroundPublic.LoadData();
                MessageBox.Show("����ɹ�");


 
        }


        //ȡ��
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