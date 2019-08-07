using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityJudge
{
    public partial class HotJudgeFrm : DockContent, IMESForm
    {
        public HotJudgeFrm()
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

        HotJudgeQueryFrm HotJudegQuery = new HotJudgeQueryFrm();
        private string strSoure = "Status = 6 order by MaterialID";

        private void HotJudgeFrm_Load(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvBloom);

            dtProduceDate.Value = DateTime.Now;

            cmbCCMID.Items.Clear();
            for (int i = 0; i < dsCCMID.Tables[0].Rows.Count; i++)
            {
                cmbCCMID.Items.Add(dsCCMID.Tables[0].Rows[i][0].ToString());
            }
        }

        //热检质量判定查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsBloom.SourceCondition = "1=2";
                //if (cmbCCMID.Text.Trim() != "")
                //    dsBloom.SourceCondition = "to_char(Produce_Date,'yyyy-mm-dd') = '" + dtProduceDate.Text.Trim() + "'  and CasterID = '" + cmbCCMID.Text.Trim() + "' and " + strSoure;
                //else
                //    dsBloom.SourceCondition = "to_char(Produce_Date,'yyyy-mm-dd') = '" + dtProduceDate.Text.Trim() + "' and " + strSoure;

                if (cmbCCMID.Text.Trim() != "")
                    dsBloom.SourceCondition = "CasterID = '" + cmbCCMID.Text.Trim() + "' and " + strSoure;
                else
                    dsBloom.SourceCondition = strSoure;
            }
            catch { }
        }



        private void btnHotJudge_Click(object sender, EventArgs e)
        {
            if (dsBloom.Tables[0].Rows.Count == 0)
                return;
            DataSet dsData = dsBloom.Clone();

            dsData.Tables[0].ImportRow(dsBloom.Tables[0].Rows[dsBloom.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsBloom.Current)).Row)]);
            if (dsData.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("请选择至少待热检判定的炉批.");
                return;
            }
            HotJudgeDefendFrm Frm = new HotJudgeDefendFrm();
            Frm.ShowDialogEx(Adapter.Session, (AppSvrHMI.L3DataSet)dsData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvBloom_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dsBloom.Tables[0].Rows.Count == 0)
                return;
            DataSet dsData = dsBloom.Clone();

            dsData.Tables[0].ImportRow(dsBloom.Tables[0].Rows[dsBloom.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsBloom.Current)).Row)]);
            if (dsData.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("请选择至少待热检判定的炉批.");
                return;
            }
            HotJudgeDefendFrm Frm = new HotJudgeDefendFrm();
            Frm.ShowDialogEx(Adapter.Session, (AppSvrHMI.L3DataSet)dsData);
        }

        private void dvBloom_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dsBloom.Tables[0].Rows.Count < 1)
                btnHotJudge.Enabled = false;
            else
                btnHotJudge.Enabled = true;
        }
        private void dvBloom_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void HotJudgeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}