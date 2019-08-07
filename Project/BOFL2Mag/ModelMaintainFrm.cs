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
    public partial class ModelMaintainFrm : DockContent, IMESForm
    {
        public ModelMaintainFrm()
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

        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            string strMesg = MessageBox.Show("确认删除有关模型名称为" + tscmbModelGradeIndex.Text.Trim() + "的所有标准信息", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (strMesg != "OK")
                return;

            bsBase.RemoveCurrent();
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsLime.RemoveCurrent();
            bsLime.EndEdit();
            dsLime.UpdateData();

            bsOxygen.RemoveCurrent();
            bsOxygen.EndEdit();
            dsOxygen.UpdateData();

            bsTemp.RemoveCurrent();
            bsTemp.EndEdit();
            dsTemp.UpdateData();

            bsTempJudge.RemoveCurrent();
            bsTempJudge.EndEdit();
            dsTempJudge.UpdateData();

            bsConverting.RemoveCurrent();
            bsConverting.EndEdit();
            dsConverting.UpdateData();

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体时
        private void ModelMaintainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tscmbModelGradeIndex.Text.Trim() != "")
            {
                dsModelGrade.SourceCondition = "ModelGradeIndex = '" + tscmbModelGradeIndex.Text.Trim() + "'";
                 
            }
            string strSourceCondition = "ModelGradeIndex = '" + tscmbModelGradeIndex.Text.Trim() + "'";
            string strModelGradeIndex = tscmbModelGradeIndex.Text.Trim();

            dsBase.SourceCondition = strSourceCondition;
            if (dsBase.Tables[0].Rows.Count < 1)
            {
                DataRow drBase = dsBase.Tables[0].NewRow();
                drBase["ModelGradeIndex"] = strModelGradeIndex;
                dsBase.Tables[0].Rows.Add(drBase);
            }

            dsLime.SourceCondition = strSourceCondition;
            if (dsLime.Tables[0].Rows.Count < 1)
            {
                DataRow drLime = dsLime.Tables[0].NewRow();
                drLime["ModelGradeIndex"] = strModelGradeIndex;
                dsLime.Tables[0].Rows.Add(drLime);
            }


            dsOxygen.SourceCondition = strSourceCondition;
            if (dsOxygen.Tables[0].Rows.Count < 1)
            {
                DataRow drOxygen = dsOxygen.Tables[0].NewRow();
                drOxygen["ModelGradeIndex"] = strModelGradeIndex;
                dsOxygen.Tables[0].Rows.Add(drOxygen);
            }
            
            
            dsTemp.SourceCondition = strSourceCondition;
            if (dsTemp.Tables[0].Rows.Count < 1)
            {
                DataRow drTemp = dsTemp.Tables[0].NewRow();
                drTemp["ModelGradeIndex"] = strModelGradeIndex;
                dsTemp.Tables[0].Rows.Add(drTemp);
            }

            dsTempJudge.SourceCondition = strSourceCondition;
            if (dsTempJudge.Tables[0].Rows.Count < 1)
            {
                DataRow drTempJudge = dsTempJudge.Tables[0].NewRow();
                drTempJudge["ModelGradeIndex"] = strModelGradeIndex;
                dsTempJudge.Tables[0].Rows.Add(drTempJudge);
            }

            dsConverting.SourceCondition = strSourceCondition;
            if (dsConverting.Tables[0].Rows.Count < 1)
            {
                DataRow drConverting = dsConverting.Tables[0].NewRow();
                drConverting["ModelGradeIndex"] = strModelGradeIndex;
                dsConverting.Tables[0].Rows.Add(drConverting);
            }       

        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsLime.EndEdit();
            dsLime.UpdateData();

            bsOxygen.EndEdit();
            dsOxygen.UpdateData();

            bsTemp.EndEdit();
            dsTemp.UpdateData();

            bsTempJudge.EndEdit();
            dsTempJudge.UpdateData();

            bsConverting.EndEdit();
            dsConverting.UpdateData();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModelMaintainFrm_Load(object sender, EventArgs e)
        {
            tscmbModelGradeIndex.Items.Clear();
            for (int i = 0; i < dsModelGradeIndex.Tables[0].Rows.Count; i++)
            {
                tscmbModelGradeIndex.Items.Add(dsModelGradeIndex.Tables[0].Rows[i][0]);
            }  

        }

        

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Adapter.RefreshDataBindings();
        }

        private void dvBulk_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

  

    



    

   
       
      

       

     

    }
}