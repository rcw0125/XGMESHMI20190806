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
    public partial class RHStdInCtrEleFrm : DockContent, IMESForm
    {
        public RHStdInCtrEleFrm()
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

        private string strSort = "";
        private StdInCtrEleShowFrm frm = new StdInCtrEleShowFrm();

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsInCtrEle.Tables[0].NewRow();
            dsInCtrEle.Tables[0].Rows.Add(newrow);


            bsInCtrEle.MoveFirst();
            while (((System.Data.DataRowView)(bsInCtrEle.Current)).Row != newrow && bsInCtrEle.Position != dsInCtrEle.Tables[0].Rows.Count - 1)
            {
                bsInCtrEle.MoveNext();
            }

            frm.ShowDialogEx(Adapter.Session, bsInCtrEle.Position, strSort, ref dsInCtrEle);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsInCtrEle.Position >= 0)
            bsInCtrEle.RemoveCurrent();
        }


        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsInCtrEle.RejectChanges();
            dsInCtrEle.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //双击弹出修改
        private void dvInCtrEle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bsInCtrEle.Position = e.RowIndex;
            frm.ShowDialogEx(Adapter.Session, bsInCtrEle.Position, strSort, ref dsInCtrEle);
        }

        //关闭窗体
        private void RHStdInCtrEleFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void RHStdInCtrEleFrm_Load(object sender, EventArgs e)
        {
            cmbSteelGradeIndex.Items.Clear();
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i][0]);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cmbSteelGradeIndex.Text.Trim() == "")
                dsInCtrEle.SourceCondition = "SteelGradeIndex is not null ";
            else
            {
                dsInCtrEle.SourceCondition = "SteelGradeIndex like '%" + cmbSteelGradeIndex.Text.Trim() + "%'";
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + cmbSteelGradeIndex.Text.Trim() + "'";
                if (dsSteelGrade .Tables [0].Rows .Count ==0 )
                {
                    txtSteelGrade.Text = "";
                }
                else {
                 
                    txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
                }
            }
        }

        //确认
        private void btnOK_Click(object sender, EventArgs e)
        {
            bsInCtrEle.EndEdit();
            dsInCtrEle.UpdateData();
        }

        private void dvInCtrEle_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsInCtrEle.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("RHl炉内控钢成份管理", dvInCtrEle);
        }
    }
}