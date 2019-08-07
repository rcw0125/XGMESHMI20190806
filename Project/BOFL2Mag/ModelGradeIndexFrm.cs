using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace BOFL2Mag
{
    public partial class ModelGradeIndexFrm : DockContent, IMESForm
    {
        public ModelGradeIndexFrm()
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
            DataRow newrow = dsModelGradeIndexRelation.Tables[0].NewRow();
            dsModelGradeIndexRelation.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsModelGradeIndexRelation.Position >= 0)
                bsModelGradeIndexRelation.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvModelGradeIndexRelation.EndEdit();
            bsModelGradeIndexRelation.EndEdit();
            dsModelGradeIndexRelation.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsModelGradeIndexRelation.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void ModelGradeIndexFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
        
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //[20090113Liao]
            string strModelGradeIndex = cmbModelGradeIndex.Text.Trim();
            
            
                dsModelGradeIndexRelation.SourceCondition = "ModelGradeIndex like '%" + strModelGradeIndex + "%'";
      
        }


        private void ModelGradeIndexFrm_Load(object sender, EventArgs e)
        {
            //加载模型名称
            for (int i = 0; i < dsModelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbModelGradeIndex.Items.Add(dsModelGradeIndex.Tables[0].Rows[i]["ModelGradeIndex"].ToString());
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
           

            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataSource = dsFlag;
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DisplayMember = "Table1.USEFLAG_DES";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).ValueMember = "Table1.USEFLAG";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataPropertyName = "Use_Flag";
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            dvModelGradeIndexRelation.EndEdit();
            bsModelGradeIndexRelation.EndEdit();
            for (int i = 0; i < dsModelGradeIndexRelation.Tables[0].Rows.Count;i++ )
            {
                if (dsModelGradeIndexRelation.Tables[0].Rows[i]["CheckFlag"].ToString()=="1")
                {
                    dsModelGradeIndexRelation.Tables[0].Rows[i]["First_Flag"] = 1;
                }
            }
            dsModelGradeIndexRelation.UpdateData();
            dsModelGradeIndexRelation.LoadData();
        }   

    }
}


