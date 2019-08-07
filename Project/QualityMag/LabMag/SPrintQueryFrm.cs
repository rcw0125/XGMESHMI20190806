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
    public partial class SPrintQueryFrm : DockContent, IMESForm
    {
        public SPrintQueryFrm()
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


        private void SPrintQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            cmbPossition.Items.Add("");
            for (int i = 0; i < dsSampleAddr.Tables[0].Rows.Count; i++)
                cmbPossition.Items.Add(dsSampleAddr.Tables[0].Rows[i]["Code_Des"]);
        }

        private void cmbPossition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSPrint.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsSampleAddr, cmbPossition.Text);
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsSPrint.SourceCondition = "1=2";
           
            //double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate()), 0);
            //if (dDateLength > 31)
            //{
            //    MessageBox.Show("请查询时间间隔在两周以内的数据！", "提示");
            //    return;
            //}

            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            if (txtSPrint.Text == "")
                dsSPrint.SourceCondition = "LogTime between '" + dtS + "' and '" + dtE + "' order by LogTime asc";
            else
                dsSPrint.SourceCondition = "(LogTime between '" + dtS + "' and '" + dtE + "') and ( Sample_Address = '" + txtSPrint.Text + "') order by LogTime asc";
            //dsSPrint.LoadData();
        }

        //导出到Excel
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("低倍硫样信息", dvSPrint);
        }

        private void dvSPrint_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void SPrintQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dt_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate()), 0);
            //    if (dDateLength <= 7)
            //        return;
            //    if (sender.Equals(dtStart))
            //        dtEnd.Value = dtEnd.Value.AddDays(7 - dDateLength);
            //    else
            //        dtStart.Value = dtStart.Value.AddDays(7 - dDateLength);
            //}
            //catch
            //{
            //    dtStart.Value = DateTime.Now;
            //    dtEnd.Value = DateTime.Now;
            //}
        }
    }
}