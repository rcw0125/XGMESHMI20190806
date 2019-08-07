using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public partial class ModifyLadleGradeFrm : Form
    {
        public ModifyLadleGradeFrm()
        {
            InitializeComponent();
        }

        private string strUnitID = "";
        private string strUnitMagUri = "";//执行方法Uri
        private string strAreaClass = "";//获取处理号，炉号，包况类名
        private string strProcessClass = ""; //过程处理

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            if (UnitID.Length != 3)
                return DialogResult.None;
            
            strUnitID = UnitID;
            if (UnitID.Substring(1, 1) == "4")//LF
            {
                strUnitMagUri = CommDataMag.CommonData.LF_CLASS_URI + strUnitID;
                strAreaClass = CommDataMag.CommonData.LF_CLASS_AREA_URI + strUnitID;
                strProcessClass = @"XGMESLogic\LFMag\CLF_Process_Data\";//LF过程处理
            }
            else if (UnitID.Substring(1, 1) == "5")//RH
            {
                strUnitMagUri = CommDataMag.CommonData.RH_CLASS_URI + strUnitID;
                strAreaClass = CommDataMag.CommonData.RH_CLASS_AREA_URI + strUnitID;
                strProcessClass = @"XGMESLogic\RHMag\CRH_Process_Data\";//RH过程处理
            }
            else
                return DialogResult.None;

            this.Text = strUnitID + "--" + this.Text;
            cmdModify.Object = strUnitMagUri;
            return ShowDialog();
        }

        private void ModifyLadleGradeFrm_Load(object sender, EventArgs e)
        {
            rbtnA.Checked = true;
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            string strArea = "A";
            string strTreatNo = "";
            string strHeatID = "";
            string strLadleNo = "";
            string strLadleGrade = "";

            if (!(rbtnA.Checked))
                strArea = "B";

            object objTreatNo = null;
            object objHeatID = null;
            object objLadleNo = null;
            object objLadleGrade = null;
            Adapter.Session.Get(strAreaClass + strArea, "TreatNo", ref objTreatNo);
            if (objTreatNo != null)
            {
                strTreatNo = objTreatNo.ToString();
                Adapter.Session.Get(strProcessClass + strTreatNo, "HeatID", ref objHeatID);
                Adapter.Session.Get(strProcessClass + strTreatNo, "LadleNo", ref objLadleNo);
                Adapter.Session.Get(strProcessClass + strTreatNo, "Ladle_Grade", ref objLadleGrade);

                if (objHeatID != null)
                    strHeatID = objHeatID.ToString();
                if (objLadleNo != null)
                    strLadleNo = objLadleNo.ToString();
                if (objLadleGrade != null)
                    strLadleGrade = objLadleGrade.ToString();
            }

            txtTreatNo.Text = strTreatNo;
            txtHeatid.Text = strHeatID;
            txtLadleNo.Text = strLadleNo;
            cmbLadleGrade.Text = strLadleGrade;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTreatNo.Text == "")
            {
                MessageBox.Show("处理号为空,不能修改包况！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbLadleGrade.Text == "") 
            {
                MessageBox.Show("没有选择包况！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (txtLadleNo.Text == "")
                if (MessageBox.Show("钢包号为空,确认只修改实绩中的包况？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() != "Yes")
                    return;
            
            cmdpTreatNo.ConstantValue = txtTreatNo.Text;
            cmdpLadleGrade.ConstantValue = cmbLadleGrade.Text.Trim(); ;

            if (cmdModify.Execute() >= 0)
            {
                int iRet = (int)cmdModify.Command.Return;
                if (iRet < 1)
                {
                    MessageBox.Show("修改实绩中钢包包况失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("修改钢包包况成功！", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
                MessageBox.Show("修改钢包包况失败！", "提示", MessageBoxButtons.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}