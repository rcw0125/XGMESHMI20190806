using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;

namespace PlanMag
{
    public partial class TappingPlanQueryFrm : DockContent, IMESForm
    {
        public TappingPlanQueryFrm()
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
            dsInStore.SourceCondition = "1=2";
            DateTime dtS = Convert.ToDateTime(dtInStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtInStoreEndData.Text.Trim() + " 23:59:59");
            double dDateLength = Math.Round((dtInStoreEndData.Value.ToOADate() - dtInStoreData.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("���ѯʱ������һ�����ڵ����ݣ�", "��ʾ");
                return;
            }
            dsInStore.SourceCondition = "CreateDate between '" + dtS + "' and '" + dtE + "' order by CreateDate asc";
        }

        //�ؼ�����
        private void TappingPlanQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("���ּƻ���Ϣ", dvInStore);
        }

        private void TappingPlanQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}