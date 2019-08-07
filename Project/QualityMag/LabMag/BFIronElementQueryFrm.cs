using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.LabMag
{
    public partial class BFIronElementQueryFrm : DockContent, IMESForm
    {
        public BFIronElementQueryFrm()
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


        private void BFIronElementQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
            cmbPossition.Items.Add("");
            cmbSampleType.Items.Add("");
            for (int i = 0; i < dsSampleAddr.Tables[0].Rows.Count; i++)
            {
                cmbPossition.Items.Add(dsSampleAddr.Tables[0].Rows[i]["Code_Des"]);
            }
            for (int i = 0; i < dsSampleType.Tables[0].Rows.Count; i++)
            {
                cmbSampleType.Items.Add(dsSampleType.Tables[0].Rows[i]["Code_Des"]);
            }
        }

        private void cmbPossition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtElement.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsSampleAddr, cmbPossition.Text);
        }

        private void cmbSampleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSampleType.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsSampleType, cmbSampleType.Text);
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsIronElement.SourceCondition = "1=2";
            DateTime dtS = Convert.ToDateTime(dtInStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtInStoreEndData.Text.Trim() + " 23:59:59");
            double dDateLength = Math.Round((dtInStoreEndData.Value.ToOADate() - dtInStoreData.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            if (txtSampleType.Text == "")
            {
                if (txtElement.Text == "")
                {
                    dsIronElement.SourceCondition = "LogTime between '" + dtS + "' and '" + dtE + "' order by LogTime asc";
                }
                else
                {
                    dsIronElement.SourceCondition = "(LogTime between '" + dtS + "' and '" + dtE + "') and ( Sample_Address = '" + txtElement.Text + "') order by LogTime asc";
                }
            }
            else
            {
                if (txtElement.Text == "")
                {
                    dsIronElement.SourceCondition = "(LogTime between '" + dtS + "' and '" + dtE + "') and ( Sample_Type = '" + txtSampleType.Text + "') order by LogTime asc";
                }
                else
                {
                    dsIronElement.SourceCondition = "(LogTime between '" + dtS + "' and '" + dtE + "') and ( Sample_Address = '" + txtElement.Text + "') and ( Sample_Type = '" + txtSampleType.Text + "') order by LogTime asc";
                }
            }
            dsIronElement.LoadData();
        }

        //导出到Excel
        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (cmbSampleType.Text.Trim() != "")
                CommDataMag.CommonMethed.PutIntoExcel(cmbSampleType.Text.Trim(), dvIronElement);
            else
                CommDataMag.CommonMethed.PutIntoExcel("高炉铁样", dvIronElement);
        }

        private void dvElement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BFIronElementQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}