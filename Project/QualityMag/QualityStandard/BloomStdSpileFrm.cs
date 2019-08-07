using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityStandard
{
    public partial class BloomStdSpileFrm : DockContent, IMESForm
    {
        public BloomStdSpileFrm()
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

        //数据加载
        private void BloomStdSpileFrm_Load(object sender, EventArgs e)
        {
            cmbSteelGradeIndex.Items.Clear();
            cmbSteelGradeIndex.Items.Add("");
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i][0].ToString());
            }
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBase.Tables[0].NewRow();
            dsBase.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dvBase.Rows.Count > 0)
                bsBase.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();

            dsBase.UpdateData();
            dsBase.LoadData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //炼钢记号查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cmbSteelGradeIndex.Text.Trim() == "")
                dsBase.SourceCondition = "SteelGradeIndex is not null ";
            else
            {
                dsBase.SourceCondition = "SteelGradeIndex like '%" + cmbSteelGradeIndex.Text.Trim() + "%'";
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + cmbSteelGradeIndex.Text.Trim() + "'";
                txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
            }
        }
        //导出到Excel
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢坯上垛标志维护信息", dvBase);
        }

        private void BloomStdSpileFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}