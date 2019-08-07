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
    public partial class ModelScrapStdFrm : DockContent, IMESForm
    {
        public ModelScrapStdFrm()
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
            DataRow newrow = dsMaterial_CodeRelation.Tables[0].NewRow();
            dsMaterial_CodeRelation.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsMaterial_CodeRelation.Position >= 0)
                bsMaterial_CodeRelation.RemoveCurrent();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvMaterial_CodeRelation.EndEdit();
            bsMaterial_CodeRelation.EndEdit();
            dsMaterial_CodeRelation.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsMaterial_CodeRelation.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void ModelScrapStdFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
        
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //[20090113Liao]
            string strMaterial_Code = cmbMaterial_Code.Text.Trim();
            
            
                dsMaterial_CodeRelation.SourceCondition = "Material_Code like '%" + strMaterial_Code + "%'";
      
        }


        private void ModelScrapStdFrm_Load(object sender, EventArgs e)
        {
            //加载模型名称
            for (int i = 0; i < dsMaterial_Code.Tables[0].Rows.Count; i++)
            {
                cmbMaterial_Code.Items.Add(dsMaterial_Code.Tables[0].Rows[i]["Material_Code"].ToString());
            }

            //
            //DataRow dr1 = dsFlag.Tables[0].NewRow();
            //DataRow dr2 = dsFlag.Tables[0].NewRow();
            DataTable dt = new DataTable();
           
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            dvMaterial_CodeRelation.EndEdit();
            bsMaterial_CodeRelation.EndEdit();
            for (int i = 0; i < dsMaterial_CodeRelation.Tables[0].Rows.Count;i++ )
            {
                if (dsMaterial_CodeRelation.Tables[0].Rows[i]["CheckFlag"].ToString()=="1")
                {
                    dsMaterial_CodeRelation.Tables[0].Rows[i]["First_Flag"] = 1;
                }
            }
            dsMaterial_CodeRelation.UpdateData();
            dsMaterial_CodeRelation.LoadData();
        }

        private void dvMaterial_CodeRelation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("废钢标准维护", dvMaterial_CodeRelation);
        }

       

       

    }
}


