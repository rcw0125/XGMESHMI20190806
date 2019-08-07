using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag
{
    public partial class ProductGradeQueryFrm : DockContent, IMESForm
    {
        public ProductGradeQueryFrm()
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
            this.Adapter.Session = session;
            this.ShowDialog();
        }

        private void ProductGradeQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void dvCCMData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void ProductGradeQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();// 清楚记录
        }

         //查询按钮
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }









    }
}