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
    public partial class ProduceSheetMaintenFrm : DockContent, IMESForm
    {
        public ProduceSheetMaintenFrm()
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
        ProduceSheetMaintenShowFrm Frm = new ProduceSheetMaintenShowFrm();

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsProduceSheetMainten.Tables[0].NewRow();
            dsProduceSheetMainten.Tables[0].Rows.Add(newrow);
            bsProduceSheetMainten.MoveFirst();
            while (((System.Data.DataRowView)(bsProduceSheetMainten.Current)).Row != newrow && bsProduceSheetMainten.Position != dsProduceSheetMainten.Tables[0].Rows.Count - 1)
            {
                bsProduceSheetMainten.MoveNext();
            }

            Frm.ShowDialogExL(Adapter, bsProduceSheetMainten.Position, strSort, dsProduceSheetMainten);
            //Frm.ShowDialogEx(bsProduceSheetMainten.Position, strSort, ref dsProduceSheetMainten);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsProduceSheetMainten.Position >= 0)
                bsProduceSheetMainten.RemoveCurrent();
            bsProduceSheetMainten.EndEdit();
            dsProduceSheetMainten.UpdateData();
        }

        //双击弹出修改
        private void dvProduceSheetMainten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bsProduceSheetMainten.Position = e.RowIndex;
            Frm.ShowDialogExL(Adapter, bsProduceSheetMainten.Position, strSort, dsProduceSheetMainten);
            //Frm.ShowDialogEx(bsProduceSheetMainten.Position, strSort, ref dsProduceSheetMainten);
        }


        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvProduceSheetMainten.EndEdit();
            bsProduceSheetMainten.EndEdit();
            dsProduceSheetMainten.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsProduceSheetMainten.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void ProduceSheetMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void ProduceSheetMaintenFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i]["SteelGradeIndex"].ToString());
            }
        }

        private void dvProduceSheetMainten_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsProduceSheetMainten.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tscmbSteelGradeIndex.Text.Trim() == "")
                dsProduceSheetMainten.SourceCondition = "SteelGradeIndex is not null ";
            else
            {
                dsProduceSheetMainten.SourceCondition = "SteelGradeIndex like '%" + tscmbSteelGradeIndex.Text.Trim() + "%'";
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + tscmbSteelGradeIndex.Text.Trim() + "'";
                if (dsSteelGrade != null && dsSteelGrade.Tables[0].Rows.Count > 0)
                    txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
            }
        }
    }
}