using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace BaseDataMag
{
    public partial class FeedMapFrm : DockContent, IMESForm
    {
        public FeedMapFrm()
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
            //ˢ������
           
            bsFeed.EndEdit();
            dvFeed.EndEdit();
            dsFeed.UpdateData();
            
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsFeed.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FeedMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}