using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.BloomStore
{
    public partial class OutStoreQueryFrm : DockContent, IMESForm
    {
        public OutStoreQueryFrm()
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

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            if (txtHeatID.Text.Length != 9)
            {
                double dDateLength = Math.Round((dtOutStoreEndData.Value.ToOADate() - dtOutStoreData.Value.ToOADate() + 1), 0);
                if (dDateLength > 7)
                {
                    MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                    return;
                }
                if (txtHeatID.Text == "")
                {
                    if (cmbCasterID.Text == "")
                    {
                        dsOutStore.SourceMethod = "select * from VIEW_BLOOM_OUTPUT_LOG where LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
                    }
                    else
                    {
                        dsOutStore.SourceMethod = "select * from VIEW_BLOOM_OUTPUT_LOG where LOGDATE between '" + dtS + "' and '" + dtE + "' and CasterID = '"+cmbCasterID.Text+"' order by LOGDATE desc";
                    }
                }
                else
                {
                    dsOutStore.SourceMethod = "select * from VIEW_BLOOM_OUTPUT_LOG where MaterialID = '" + txtHeatID.Text.Trim() + "' and  LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
                }
            }
            else
            {
                dsOutStore.SourceMethod = "select * from VIEW_BLOOM_OUTPUT_LOG where MaterialID = '" + txtHeatID.Text.Trim() + "'";
            }
            
            dsOutStore.LoadData();
        }

        //控件加载
        private void OutStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢坯出库信息", dvInStore);
        }

        private void OutStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}