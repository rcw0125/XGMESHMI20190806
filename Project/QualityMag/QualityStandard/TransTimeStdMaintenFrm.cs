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
    public partial class TransTimeStdMaintenFrm : DockContent, IMESForm
    {
        public TransTimeStdMaintenFrm()
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


        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTransTime.Tables[0].NewRow();
            dsTransTime.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsTransTime.Position >= 0)
                bsTransTime.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvTransTime.EndEdit();
            bsTransTime.EndEdit();
            dsTransTime.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsTransTime.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void TransTimeStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "1=2";
            dsTransTime.SourceCondition = strSourceCondition;

            strSourceCondition = "1=1";

            if (txtStartUnit.Text.Trim() != "")
                strSourceCondition = " Start_Unit = '" + txtStartUnit.Text.Trim() + "'";
            
            if (txtEndUnit.Text.Trim() != "")
            {
                if (strSourceCondition != "")
                    strSourceCondition += " and End_Unit = '" + txtEndUnit.Text.Trim() + "'";
                else
                    strSourceCondition += " End_Unit = '" + txtEndUnit.Text.Trim() + "'";
            }
            strSourceCondition += " order by Start_Unit,End_Unit";

            dsTransTime.SourceCondition = strSourceCondition;
        }

        private void TransTimeStdMaintenFrm_Load(object sender, EventArgs e)
        {
            cmbStartUnit.Items.Add("");
            cmbEndUnit.Items.Add("");

            for (int i = 0; i < dsUnitName.Tables[0].Rows.Count; i++)
            {
                cmbStartUnit.Items.Add(dsUnitName.Tables[0].Rows[i]["CODE_DES"].ToString());
                cmbEndUnit.Items.Add(dsUnitName.Tables[0].Rows[i]["CODE_DES"].ToString());
            }
        }

        private void cmbStartUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartUnit.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsUnitName, cmbStartUnit.SelectedItem.ToString());
        }

        private void cmbEndUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndUnit.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsUnitName, cmbEndUnit.SelectedItem.ToString());
        }

        private void dvTransTime_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }
}