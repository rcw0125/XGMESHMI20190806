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
    public partial class CasterStdProdProcFrm : DockContent, IMESForm
    {
        public CasterStdProdProcFrm()
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
            DataRow newrow = dsProdProc.Tables[0].NewRow();
            dsProdProc.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            bsProdProc.RemoveCurrent();
            bsProdProc.EndEdit();
            dsProdProc.UpdateData();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvProdProc.EndEdit();
            bsProdProc.EndEdit();
            dsProdProc.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsProdProc.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void CasterStdProdProcFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CasterStdProdProcFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
            {
                cmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i]["SteelGradeIndex"].ToString());
            }
        }

        private void cmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, cmbCasterID.SelectedItem.ToString());
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cmbSteelGradeIndex.Text.Trim() != "")
            {
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + cmbSteelGradeIndex.Text.Trim() + "'";
                txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
            }
            string strSourceCondition = "";
            if (cmbCasterID.Text == "" && cmbSteelGradeIndex.Text != "")
            {
                strSourceCondition = "SteelGradeIndex =  like '%" + cmbSteelGradeIndex.Text.Trim() + "%'";
            } 
            else if(cmbSteelGradeIndex.Text == "" && cmbCasterID.Text != "")
            {
                strSourceCondition = "CasterID = '" + txtCasterID.Text.Trim() + "'";
            }
            else if (cmbCasterID.Text == "" && cmbSteelGradeIndex.Text == "")
            {
                strSourceCondition = "SteelGradeIndex is not null ";
            }
            else
            {
                strSourceCondition = "CasterID = '" + txtCasterID.Text.Trim() + "'" + " and SteelGradeIndex like '%" + cmbSteelGradeIndex.Text.Trim() + "%'";
            }
            
            dsProdProc.SourceCondition = strSourceCondition;
        }

        private void CasterStdProdProcFrm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}