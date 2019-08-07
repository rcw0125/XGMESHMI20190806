using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.CodeMag
{
    public partial class HeatExcepCodeMaintenFrm : DockContent, IMESForm
    {
        public HeatExcepCodeMaintenFrm()
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
            DataRow newrow = dsHeatExcepCodeMainten.Tables[0].NewRow();
            dsHeatExcepCodeMainten.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            bsHeatExcepCodeMainten.RemoveCurrent();
        }

        //确认
        private void btnOK_Click(object sender, EventArgs e)
        {
            dvHeatExcepCodeMainten.EndEdit();
            bsHeatExcepCodeMainten.EndEdit();
            dsHeatExcepCodeMainten.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsHeatExcepCodeMainten.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void HeatExcepCodeMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}