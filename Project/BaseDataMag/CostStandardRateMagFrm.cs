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
    public partial class SteelGradeStandardMagFrm : DockContent, IMESForm
    {
        public SteelGradeStandardMagFrm()
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
        private void CostStandardRateMagFrm_Load(object sender, EventArgs e)
        {
            //dsCostStandardRate.SourceMethod = "";
            //string strCodeSQL = "";
            //strCodeSQL += "     SELECT *                                    ";
            //strCodeSQL += "       FROM CCost_Standard_Rate                  ";
            //strCodeSQL += "   order by Cost_Item,Cost_Center                ";

            //dsCostStandardRate.SourceMethod = strCodeSQL;
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsCostStandardRate.Tables[0].NewRow();
            dsCostStandardRate.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCostStandardRate.Position >= 0)
                bsCostStandardRate.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCostStandardRate.EndEdit();
            bsCostStandardRate.EndEdit();
            if (dsCostStandardRate.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsCostStandardRate.LoadData();
                return;
            }
            MessageBox.Show("操作失败！", "提示");
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsCostStandardRate.LoadData();
        }

        //打印
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("标准费率信息", dvCostStandardRate);
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
        private void CostStandardRateMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}