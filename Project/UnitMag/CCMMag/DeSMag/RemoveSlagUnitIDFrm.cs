using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class RemoveSlagUnitIDFrm : Form
    {
        public RemoveSlagUnitIDFrm()
        {
            InitializeComponent();
        }
        private string IorII = "";
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData,string Unit)
        {
            Adapter.Session = session;
            txtTAPNo.Text = dsData.Tables[0].Rows[0]["TAP_No"].ToString();
            txtTPCNo.Text = dsData.Tables[0].Rows[0]["TPC_No"].ToString();
            IorII = Unit;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sRet = "";
            string strReasultShow = "";
            cmdRemoveSlag1.Parameters[0].ConstantValue = txtTAPNo.Text + txtTPCNo.Text;
            cmdRemoveSlag1.Parameters[1].ConstantValue = "7";
            try
            {
                string AorB = "";
                if (rbtnA.Checked)
                    AorB = "A";
                else if ((rbtnB.Checked))
                    AorB = "B";
                else
                {
                    MessageBox.Show("请选择工位！", "提示");
                    return;
                }

                if (IorII == "S02")
                {
                    cmdRemoveSlag1.Parameters[2].ConstantValue = AorB;
                    if (cmdRemoveSlag1.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdRemoveSlag1.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("捞渣开始成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("捞渣开始失败！" + sRet + strReasultShow, "提示");
                        }
                    }
                    else
                        MessageBox.Show("捞渣开始失败！", "提示");
                }
                else if (IorII == "S03")
                {
                    cmdRemoveSlag2.Parameters[2].ConstantValue = AorB;
                    if (cmdRemoveSlag2.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdRemoveSlag2.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("捞渣开始成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("捞渣开始失败！" + sRet + strReasultShow, "提示");
                        }
                    }
                    else
                        MessageBox.Show("捞渣开始失败！", "提示");
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

        private void RemoveSlagUnitIDFrm_Load(object sender, EventArgs e)
        {
            if (IorII == "S02")
            {
                rbtnA.Text = "1#工位";
                rbtnB.Text = "2#工位";
            }
            if (IorII == "S03")
            {
                rbtnA.Text = "3#工位";
                rbtnB.Text = "4#工位";
            }
        }
    }
}