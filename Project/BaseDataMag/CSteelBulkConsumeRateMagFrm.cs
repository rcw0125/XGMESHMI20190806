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
using System.Data.OleDb;

namespace BaseDataMag
{
    public partial class CSteelBulkConsumeRateMagFrm : DockContent, IMESForm
    {
        public CSteelBulkConsumeRateMagFrm()
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

        private void CSteelBulkConsumeRateMagFrm_Load(object sender, EventArgs e)
        {
            dsUnitCode.SourceMethod = "";
            string strCodeSQL = "";
            strCodeSQL += "     SELECT DISTINCT (code), code_des                        ";
            strCodeSQL += "       FROM cbase_all_code                                   ";
            strCodeSQL += "      WHERE    code_group = 'Steel_Bulk_Consume_Rate'        ";
            strCodeSQL += "        AND code IS NOT NULL                                 ";
            strCodeSQL += "   ORDER BY code_des                                         ";

            dsUnitCode.SourceMethod = strCodeSQL;

        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsUnitConsume.Tables[0].NewRow();
            newrow["Unit_Consume"] = 0;
            dsUnitConsume.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            dvUnitConsume.EndEdit();
            bsUnitConsume.EndEdit();
            if (bsUnitConsume.Position >= 0)
                bsUnitConsume.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUnitConsume.EndEdit();
            bsUnitConsume.EndEdit();
            if (dsUnitConsume.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsUnitConsume.LoadData();
                return;
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsUnitConsume.LoadData();
        }

        //打印
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢铁料散装料指标单耗管理", dvUnitConsume);
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
        private void CSteelBulkConsumeRateMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}