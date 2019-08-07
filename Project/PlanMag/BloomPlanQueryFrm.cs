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
    public partial class BloomPlanQueryFrm : DockContent, IMESForm
    {
        public BloomPlanQueryFrm()
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
            DateTime dtE = Convert.ToDateTime(dtInStoreEndData.Text.Trim() + " 23:59:59");
            if (txtPlanOrdID.Text.Trim() != "")
            {
                dsBloomPlan.SourceMethod = "select * from VIEW_PLAN_ORDER where planid = '" + txtPlanOrdID.Text.Trim() + "'";
                dsBloomPlan.LoadData();
            }
            else
            {
                dsBloomPlan.SourceCondition = "CreateDate between '" + dtS + "' and '" + dtE + "' order by CreateDate asc";
                dsBloomPlan.SourceMethod = "select * from VIEW_PLAN_ORDER where request_date between '" + dtS + "' and '" + dtE + "' order by request_date";
            }
        }

        //�ؼ�����
        private void BloomPlanQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�����ƻ�����ִ�������Ϣ", dvInStore);
        }

        private void BloomPlanQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}