using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.BloomStore
{
    public partial class TransQueryFrm : DockContent, IMESForm
    {
        public TransQueryFrm()
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

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            dsTrans.SourceCondition = "Trans_Date between '" + dtS + "' and '" + dtE + "' order by Trans_Date desc";
            dsTrans.L3DataAdapter = Adapter;
            dsTrans.L3DataAdapter = null;
        }

        //�ؼ�����
        private void TransQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("����ת����Ϣ", dvInStore);
        }

        private void TransQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}