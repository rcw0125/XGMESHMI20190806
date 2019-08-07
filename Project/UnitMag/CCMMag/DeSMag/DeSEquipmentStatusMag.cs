using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class DeSEquipmentStatusMag : Form
    {
        public DeSEquipmentStatusMag()
        {
            InitializeComponent();
        }

        private string id = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            id = UnitID;
            if(UnitID == "S02")
            lbDeSID.Text = "I部脱硫";
            else
            lbDeSID.Text = "II部脱硫";
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sRet = "";
            if (id == "S02")
            {
                cmdSetStatus1.Parameters[0].ConstantValue = cmbStatus.SelectedValue.ToString();
                cmdSetStatus1.Parameters[1].ConstantValue = txtReason.Text;
                if (cmdSetStatus1.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdSetStatus1.Command.Return);
                    if (sRet == "1")
                    {
                        MessageBox.Show("修改成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("修改失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("修改失败！", "提示");
            }
            if (id == "S03")
            {
                cmdSetStatus2.Parameters[0].ConstantValue = cmbStatus.SelectedValue.ToString();
                cmdSetStatus2.Parameters[1].ConstantValue = txtReason.Text;
                if (cmdSetStatus2.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdSetStatus2.Command.Return);
                    if (sRet == "1")
                    {
                        MessageBox.Show("修改成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("修改失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("修改失败！", "提示");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void DeSEquipmentStatusMag_Load(object sender, EventArgs e)
        {
            txtReason.TextChanged += new EventHandler(txtReason_TextChanged);
        }
    }
}