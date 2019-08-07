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
    public partial class InStoreQueryFrm : DockContent, IMESForm
    {
        public InStoreQueryFrm()
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
            DateTime dtS = Convert.ToDateTime(dtInStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtInStoreData.Text.Trim() + " 23:59:59");
            dsInStore.SourceCondition = "LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
            dsInStore.LoadData();
        }

        //�ؼ�����
        private void InStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("ɢ״�������Ϣ", dvInStore);
        }

        private void InStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}