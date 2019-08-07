using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class PreRemoveSlagUnitIDFrm : Form
    {
        public PreRemoveSlagUnitIDFrm()
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
            cmdPreRemoveSlag1.Parameters[0].ConstantValue = txtTAPNo.Text + txtTPCNo.Text;
            cmdPreRemoveSlag1.Parameters[1].ConstantValue = "3";
            try
            {
                string AorB = "";
                if (rbtnA.Checked)
                    AorB = "A";
                else if ((rbtnB.Checked))
                    AorB = "B";
                else
                {
                    MessageBox.Show("��ѡ��λ��", "��ʾ");
                    return;
                }

                if (IorII == "S02")
                {
                    cmdPreRemoveSlag1.Parameters[2].ConstantValue = AorB;
                    if (cmdPreRemoveSlag1.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdPreRemoveSlag1.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("Ԥ������ʼ�ɹ���", "��ʾ");
                            this.Close();
                        }
                        else
                        {
                            strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("Ԥ������ʼʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("Ԥ������ʼʧ�ܣ�", "��ʾ");
                }
                else if (IorII == "S03")
                {
                    cmdPreRemoveSlag2.Parameters[2].ConstantValue = AorB;
                    if (cmdPreRemoveSlag2.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdPreRemoveSlag2.Command.Return);
                        if (sRet == "1")
                        {
                            MessageBox.Show("Ԥ������ʼ�ɹ���", "��ʾ");
                            this.Close();
                        }
                        else
                        {
                            strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("Ԥ������ʼʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("Ԥ������ʼʧ�ܣ�", "��ʾ");
                }
                else
                {
                    MessageBox.Show("û�й�λ��Ϣ��", "��ʾ");
                    this.Close();
                }
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreRemoveSlagUnitIDFrm_Load(object sender, EventArgs e)
        {
            if (IorII == "S02")
            {
                rbtnA.Text = "1#��λ";
                rbtnB.Text = "2#��λ";
            }
            if (IorII == "S03")
            {
                rbtnA.Text = "3#��λ";
                rbtnB.Text = "4#��λ";
            }
        }
    }
}