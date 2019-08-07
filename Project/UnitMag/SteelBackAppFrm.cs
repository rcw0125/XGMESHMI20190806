using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public partial class SteelBackAppFrm : Form
    {
        public SteelBackAppFrm()
        {
            InitializeComponent();
        }
        private string curUnitID = "";
        private string Class_URI = "";
        //private string BaseURI = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            curUnitID = UnitID;
            //把当前机组的炉号取出[2009-02-28Liao]
            string strMessage = "当前没有作业炉号,申请失败！";
            
            int nUnitType = Convert.ToInt16((UnitID.Substring(1, 1)));
            switch (nUnitType)
            {
                case 4:
                        Class_URI = CommDataMag.CommonData.LF_CLASS_URI + UnitID;
                    break;
                case 5:
                        Class_URI = CommDataMag.CommonData.RH_CLASS_URI + UnitID;
                    break;
                case 6:
                        Class_URI = CommDataMag.CommonData.CCM_CLASS_URI + UnitID;
                        strMessage = "大包到达岗位没有满足条件的钢水,申请失败！";
                    break;
                default: break;
            }

            dsHeatID.SourceURI = Class_URI;
            dsHeatID.LoadData();
            if (dsHeatID.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show(strMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.None;
            }
            cbxHeatID.Items.Clear();
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
            {
                cbxHeatID.Items.Add(dsHeatID.Tables[0].Rows[i][0].ToString());
            }
            cbxHeatID.SelectedIndex = 0;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("确认返送申请？", "提示", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check != "OK") return;

            if (cbxReason.SelectedValue == null || cbxHeatID.Text.Trim() == "")
            {
                MessageBox.Show("请选择返送原因和炉号！");
                return;
            }

            cmdApply.Object = Class_URI;
            cmdApply.Method = "SteelBackApp";
            cmdApply.Parameters.Clear();

            int nUnitType = Convert.ToInt16((curUnitID.Substring(1, 1)));
            int nUnitID = Convert.ToInt16((curUnitID.Substring(2, 1)));
            cmdApply.Parameters.Clear();
            if (nUnitType < 4)
            {
                MessageBox.Show("申请工位不允许！");
                return;
            }
            if (nUnitType > 3 && nUnitType < 6)
            {
                AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter1);
                AppSvrHMI.L3CommandParameter l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter2);
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
                cmdApply.Parameters[1].ConstantValue = cbxHeatID.Text.Trim();
            }
            else
            {
                AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter1);
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
            }
            cmdApply.Object = Class_URI;
            int iRet = cmdApply.Execute();
            if (iRet != 0 || (Convert.ToInt16(cmdApply.Command.Return)) == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdApply.Command.ErrorCode));
                //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdApply.Command.ErrorCode, iRet));
                MessageBox.Show("失败！" + strReasultShow);
            }
            else
            {
                MessageBox.Show("申请成功，等待调度返送！");
                Close();
            }
            return;
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void SteelBackAppFrm_Load(object sender, EventArgs e)
        {
            cbxReason.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}