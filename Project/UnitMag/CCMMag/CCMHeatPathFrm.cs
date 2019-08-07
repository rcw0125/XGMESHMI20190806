using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMHeatPathFrm : Form
    {
        public CCMHeatPathFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsHeatData.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsHeatData.EndEdit();

            if ((rbtnOnline.Checked) && (cbxPath.Text.Trim() == ""))
            {
                MessageBox.Show("请选择去向！");
                return;
            }
            if ((rbtnOffline.Checked) && (cbxReason.Text.Trim() == ""))
            {
                MessageBox.Show("请选择下线理由！");
                return;
            }

            cmdPath.Object = "XGMESLogic\\QualityMag\\CQA_HeatSufaceAssume_Mag\\QA_HeatSufaceAssume_Mag";
            if ((rbtnOffline.Checked) && (!rbtnOnline.Checked))
            {
                cmdPath.Method = "BloomOffLine";
            }
            else if ((!rbtnOffline.Checked) && (rbtnOnline.Checked))
            {
                cmdPath.Method = "BloomHotSend";
            }
            else
            {
                MessageBox.Show("请选择去向！");
                return;
            }

            if (MessageBox.Show("确认出坯？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() != "Yes")
                return;
            
            cmdPath.Parameters.Clear();
            dsHeatData.AcceptChanges();
            AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            cmdPath.Parameters.Add(l3CommandParameter1);
            cmdPath.Parameters[0].SourceObject = dsHeatData;

            int iRet = cmdPath.Execute();
            String returnFlag = cmdPath.Command.Return.ToString();
            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
            if (iRet != 0 || Convert.ToInt16(cmdPath.Command.Return) < 0)
            {
                MessageBox.Show("失败！" + strReasultShow);
                //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdPath.Command.ErrorCode, iRet));
            }
            else
            {
                MessageBox.Show("出坯成功！","提示");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnOffline_CheckedChanged(object sender, EventArgs e)
        {
            cbxReason.Enabled = rbtnOffline.Checked;
            cbxPath.Enabled = rbtnOnline.Checked;
            if (rbtnOffline.Checked)
            {
                cbxPath.SelectedIndex = -1;
            }
            else
            {
                cbxReason.SelectedIndex = -1;
            }
        }

    }
}