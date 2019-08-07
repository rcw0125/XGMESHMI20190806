//Add by hyh 2012-03-29
//新增钢种标准维护界面
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace BaseDataMag
{
    public partial class SteelGradeStdMagFrm : DockContent, IMESForm
    {
        public SteelGradeStdMagFrm()
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
            DataRow drSteelGradeStd = dsSteelGradeStd.Tables[0].NewRow();
            dsSteelGradeStd.Tables[0].Rows.Add(drSteelGradeStd);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsSteelGradeStd.Position >= 0)
                bsSteelGradeStd.RemoveCurrent();
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvSteelGradeStd.EndEdit();
            bsSteelGradeStd.EndEdit();
            if (dsSteelGradeStd.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsSteelGradeStd.LoadData();
                return;
            }
            MessageBox.Show("操作失败！", "提示");
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsSteelGradeStd.LoadData();
        }

        //导出到EXCEL
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢种标准维护", dvSteelGradeStd);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dvSteelGradeStd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvSteelGradeStd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }
    }
}