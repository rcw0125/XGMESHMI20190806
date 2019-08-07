using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.BulkStore
{
    public partial class OutStoreQueryFrm : DockContent, IMESForm
    {
        public OutStoreQueryFrm()
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
            //DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            //DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            dsOutStore.SourceCondition = "to_char(LOGDATE,'yyyy-mm-dd')  =  '" + dtOutStoreData.Text + "' order by LOGDATE desc";
            OutType.LoadData();
        }

        //�ؼ�����
        private void OutStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("ɢ״�ϳ�����Ϣ", dvInStore);
        }

        private void OutStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}