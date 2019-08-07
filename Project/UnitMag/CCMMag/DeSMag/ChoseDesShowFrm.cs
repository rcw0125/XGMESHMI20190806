using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class ChoseDesShowFrm : Form
    {
        public ChoseDesShowFrm()
        {
            InitializeComponent();
        }

        private string IorII = "";
        private string sMaterialID = "";

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData,string Unit)
        {
            Adapter.Session = session;
            txtTAPNo.Text = dsData.Tables[0].Rows[0]["TAP_No"].ToString();
            txtTPCNo.Text = dsData.Tables[0].Rows[0]["TPC_No"].ToString();
            sMaterialID = dsData.Tables[0].Rows[0]["MaterialID"].ToString();
            IorII = Unit;
            this.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sRet = "";
            try
            {
                if (IorII == "S02")
                {
                    cmdIronsDeparture1.Parameters[0].ConstantValue = sMaterialID;
                    cmdIronsDeparture1.Parameters[1].ConstantValue = cmbDes.SelectedValue.ToString();
                    if (cmdIronsDeparture1.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdIronsDeparture1.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("设置成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("设置失败！" , "提示");
                        }
                    }
                    else
                        MessageBox.Show("设置失败！", "提示");
                }
                else if (IorII == "S03")
                {
                    cmdIronsDeparture2.Parameters[0].ConstantValue = sMaterialID;
                    cmdIronsDeparture2.Parameters[1].ConstantValue = cmbDes.SelectedValue.ToString();
                    if (cmdIronsDeparture2.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdIronsDeparture2.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("设置成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("设置失败！", "提示");
                        }
                    }
                    else
                        MessageBox.Show("设置失败！", "提示");
                }
            }
            catch { }
        }

        private void cmbDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ChoseDesShowFrm_Load(object sender, EventArgs e)
        {
            cmbDes.SelectedIndexChanged += new EventHandler(cmbDes_SelectedIndexChanged);
        }

    }
}