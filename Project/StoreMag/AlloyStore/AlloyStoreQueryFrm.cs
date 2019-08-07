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
    public partial class AlloyStoreQueryFrm : DockContent, IMESForm
    {
        public AlloyStoreQueryFrm()
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

        

        

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("合金库存信息", dvStore);
        }

        private void AlloyStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cmbArea.Text == "")
            {
                bsStore.Filter = "";
                bsStore.EndEdit();
                dsStore.LoadData();
            }
            else if (cmbArea.Text == "合金高仓")
            {
                bsStore.Filter = "POSDIFF in ('A','B','C','D','E','F')";
                bsStore.EndEdit();
                dsStore.LoadData();
            }
            else if (cmbArea.Text == "袋状合金")
            {
                bsStore.Filter = "POSDIFF = 'Z'";
                bsStore.EndEdit();
                dsStore.LoadData();
            }
        }
    }
}