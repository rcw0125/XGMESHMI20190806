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
    public partial class HotJudgeQueryFrm : DockContent, IMESForm
    {
        public HotJudgeQueryFrm()
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
            double dDateLength = Math.Round((dtHotJudgeEndData.Value.ToOADate() - dtHotJudgeData.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("���ѯʱ������һ�����ڵ����ݣ�", "��ʾ");
                return;
            }

            DateTime dtS = Convert.ToDateTime(dtHotJudgeData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtHotJudgeEndData.Text.Trim() + " 23:59:59");
            if (txtHeatID.Text == "")
            {
                if (cmbSteelGradeIndex.Text == "")
                {
                    dsHotJudge.SourceCondition = "HotJudge_Time between '" + dtS + "' and '" + dtE + "' order by HotJudge_Time asc";
                }
                else
                {
                    dsHotJudge.SourceCondition = "SteelGradeIndex like '%" + cmbSteelGradeIndex.Text.Trim() + "%' and HotJudge_Time between '" + dtS + "' and '" + dtE + "' order by HotJudge_Time asc";
                }
            }
            else
            {
                dsHotJudge.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
            }

        }

        //�ؼ�����
        private void InStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtHotJudgeData.Value = DateTime.Now;
            dtHotJudgeEndData.Value = DateTime.Now;
            //���ּǺż���
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i]["SteelGradeIndex"].ToString());
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ȼ������ж���Ϣ", dvInStore);
        }

        private void HotJudgeQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}