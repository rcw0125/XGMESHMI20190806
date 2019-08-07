using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;

namespace BaseDataMag
{
    public partial class CostMediumMagFrm : DockContent, IMESForm
    {
        public CostMediumMagFrm()
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

        /*
         * 2009-08-07 新增介质消耗窗体 sun
         */ 
        private void CostMediumMagFrm_Load(object sender, EventArgs e)
        {
            //dsCostMedium.SourceMethod = "";
            //string strCodeSQL = "";
            //strCodeSQL += "     SELECT *                                    ";
            //strCodeSQL += "       FROM CCost_Medium_Consume_Std             ";
            //strCodeSQL += "   order by Medium,Cost_Center                   ";

            //dsCostMedium.SourceMethod = strCodeSQL;
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsCostMedium.Tables[0].NewRow();
            dsCostMedium.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCostMedium.Position >= 0)
                bsCostMedium.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCostMedium.EndEdit();
            bsCostMedium.EndEdit();
            if (dsCostMedium.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsCostMedium.LoadData();
                return;
            }
            MessageBox.Show("操作失败！", "提示");
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsCostMedium.LoadData();
        }

        //打印
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("介质消耗定额信息", dvCostMedium);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //容错
        private void dvMatPrice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //关闭窗体时释放
        private void CostMediumMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}