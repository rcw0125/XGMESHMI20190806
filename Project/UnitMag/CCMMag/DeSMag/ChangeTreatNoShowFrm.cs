using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class ChangeTreatNoShowFrm : Form
    {
        public ChangeTreatNoShowFrm()
        {
            InitializeComponent();
        }
        private string IorII = "";//AppSvrHMI.L3DataSet dsData
        public void ShowDialogEx(AppSvrIF.Session session,string Unit)
        {
            Adapter.Session = session;
            //txtTAPNo.Text = dsData.Tables[0].Rows[0]["TAP_No"].ToString();
            //txtTPCNo.Text = dsData.Tables[0].Rows[0]["TPC_No"].ToString();
            IorII = Unit;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int iRet = 0;
            try
            {
                if (IorII == "S02")
                {
                    cmdChangeTreatNo1.Parameters[0].ConstantValue = txtTreatNo.Text.Trim();
                    if (cmdChangeTreatNo1.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdChangeTreatNo1.Command.Return);
                        if (iRet > 0)
                        {
                            MessageBox.Show("修改成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show("修改失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("修改失败！", "提示");
                }
                else if (IorII == "S03")
                {
                    cmdChangeTreatNo2.Parameters[0].ConstantValue = txtTreatNo.Text.Trim();
                    if (cmdChangeTreatNo2.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdChangeTreatNo2.Command.Return);
                        if (iRet > 0)
                        {
                            MessageBox.Show("修改成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show("修改失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("修改失败！", "提示");
                }
                else
                {
                    MessageBox.Show("没有工位信息！", "提示");
                    this.Close();
                }
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTreatNo_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ChangeTreatNoShowFrm_Load(object sender, EventArgs e)
        {
            txtTreatNo.TextChanged += new EventHandler(txtTreatNo_TextChanged);
        }
    }
}