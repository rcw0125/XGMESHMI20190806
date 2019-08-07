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
    public partial class SteelGradeIndexRelationFrm : DockContent, IMESForm
    {
        public SteelGradeIndexRelationFrm()
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
            DataRow newrow = dsSteelGradeIndexRelation.Tables[0].NewRow();
            dsSteelGradeIndexRelation.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsSteelGradeIndexRelation.Position >= 0)
                bsSteelGradeIndexRelation.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvSteelGradeIndexRelation.EndEdit();
            bsSteelGradeIndexRelation.EndEdit();
            dsSteelGradeIndexRelation.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsSteelGradeIndexRelation.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void SteelGradeIndexRelationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
        
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //[20090113Liao]
            string strSteelGradeIndex = cmbSteelGradeIndex.Text.Trim();
            string strSteelGrade = txtSteelGrade.Text.Trim();
            if (strSteelGradeIndex == "")
            {
                if (strSteelGrade == "")
                    dsSteelGradeIndexRelation.SourceCondition = "";
                else
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGrade like '%" + strSteelGrade + "%'";
            }
            else
            {
                if (strSteelGrade == "")
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGradeIndex like '%" + strSteelGradeIndex + "%'";
                else
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGradeIndex like '%" + strSteelGradeIndex + "%' and SteelGrade like '%" + strSteelGrade + "%'";
            }
        }


        private void SteelGradeIndexRelationFrm_Load(object sender, EventArgs e)
        {
            //加载炼钢记号
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i]["SteelGradeIndex"].ToString());
            }

            //
            //DataRow dr1 = dsFlag.Tables[0].NewRow();
            //DataRow dr2 = dsFlag.Tables[0].NewRow();
            DataTable dt = new DataTable();
            dsFlag.Tables.Add(dt);
            dsFlag.Tables[0].Columns.Add("USEFLAG");
            dsFlag.Tables[0].Columns.Add("USEFLAG_DES");
            dsFlag.Tables[0].Rows.Add(new string[] { "0", "在用" });
            dsFlag.Tables[0].Rows.Add(new string[] { "1", "禁用" });
            dsFlag.Tables[0].Rows.Add(new string[] { "", "未定义" });

            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataSource = dsFlag;
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DisplayMember = "Table1.USEFLAG_DES";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).ValueMember = "Table1.USEFLAG";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataPropertyName = "Use_Flag";
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            dvSteelGradeIndexRelation.EndEdit();
            bsSteelGradeIndexRelation.EndEdit();
            for (int i = 0; i < dsSteelGradeIndexRelation.Tables[0].Rows.Count;i++ )
            {
                if (dsSteelGradeIndexRelation.Tables[0].Rows[i]["CheckFlag"].ToString()=="1")
                {
                    dsSteelGradeIndexRelation.Tables[0].Rows[i]["First_Flag"] = 1;
                }
            }
            dsSteelGradeIndexRelation.UpdateData();
            dsSteelGradeIndexRelation.LoadData();
        }

        private void dvSteelGradeIndexRelation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("炼钢记号钢种对照关系维护", dvSteelGradeIndexRelation);
        }

       

    }
}