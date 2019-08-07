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
    public partial class UnitRouteFrm : DockContent, IMESForm
    {
        public UnitRouteFrm()
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
            DataRow newrow = dsUnitRoute.Tables[0].NewRow();
            dsUnitRoute.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            bsUnitRoute.RemoveCurrent();
            bsUnitRoute.EndEdit();
            dsUnitRoute.UpdateData();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUnitRoute.EndEdit();
            bsUnitRoute.EndEdit();
            dsUnitRoute.UpdateData();
            dsUnitRoute.LoadData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsUnitRoute.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void UnitRouteFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void UnitRouteFrm_Load(object sender, EventArgs e)
        {
        }

        private void dvUnitRoute_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}