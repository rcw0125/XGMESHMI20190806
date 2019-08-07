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
    public partial class ExchangeSteelGradeMagFrm : DockContent, IMESForm
    {
        public ExchangeSteelGradeMagFrm()
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
        private void ExchangeSteelGradeMagFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMain.Tables[0].NewRow();
            dsMain.Tables[0].Rows.Add(newrow);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsMain.Position < 0)
                return;
            bsMain.RemoveCurrent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();

            if (dsMain.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK);
                dsMain.LoadData();
            }
            else
                MessageBox.Show("操作失败！", "提示", MessageBoxButtons.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsMain.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtSteelGrade.Text.Trim() == "")
                dsMain.SourceCondition = "SteelGrade is not null ";
            else
                dsMain.SourceCondition = "SteelGrade like '%" + txtSteelGrade.Text.Trim() + "%'";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //导出到Excel
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢种改钢对照关系维护信息", dvMain);
        }

        private void ExchangeSteelGradeMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}