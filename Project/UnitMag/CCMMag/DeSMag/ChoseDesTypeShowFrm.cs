using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class ChoseDesTypeShowFrm : Form
    {
        public ChoseDesTypeShowFrm()
        {
            InitializeComponent();
        }

        private string IorII = "";
        private string MaterialID = "";
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData,string Unit)
        {
            Adapter.Session = session;
            MaterialID = dsData.Tables[0].Rows[0]["MaterialID"].ToString();
            txtTAPNo.Text = dsData.Tables[0].Rows[0]["TAP_No"].ToString();
            txtTPCNo.Text = dsData.Tables[0].Rows[0]["TPC_No"].ToString();
            IorII = Unit;
            this.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int iRet = 0;
            try
            {
                if (IorII == "S02")
                {
                    cmdDesType1.Parameters[0].ConstantValue = MaterialID;
                    cmdDesType1.Parameters[1].ConstantValue = cmbDesType.SelectedValue.ToString();
                    if (cmdDesType1.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdDesType1.Command.Return);
                        if (iRet > 0)
                        {
                            MessageBox.Show("选择脱硫类型成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show("选择脱硫类型失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("选择脱硫类型失败！", "提示");
                }
                else if (IorII == "S03")
                {
                    cmdDesType2.Parameters[0].ConstantValue = MaterialID;
                    cmdDesType2.Parameters[1].ConstantValue = cmbDesType.SelectedValue.ToString();
                    if (cmdDesType2.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdDesType2.Command.Return);
                        if (iRet > 0)
                        {
                            MessageBox.Show("选择脱硫类型成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show("选择脱硫类型失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("选择脱硫类型失败！", "提示");
                }
            }
            catch { }
        }

        private void ChoseDesTypeShowFrm_Load(object sender, EventArgs e)
        {
            cmbDesType.SelectedIndexChanged += new EventHandler(cmbDesType_SelectedIndexChanged);
            cmbDesType.SelectedValue = 2;
        }

        private void cmbDesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}