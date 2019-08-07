using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class ChangeLanceShowFrm : Form
    {
        public ChangeLanceShowFrm()
        {
            InitializeComponent();
        }
        private string IorII = "";
        public void ShowDialogEx(AppSvrIF.Session session,string Unit)
        {
            Adapter.Session = session;
            IorII = Unit;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string SRet = "";
            string UnitID = "";
            if (rbtA.Checked)
                UnitID = "A";
            else if (rbtB.Checked)
                UnitID = "B";
            else
            {
                MessageBox.Show("��ѡ��λ��","��ʾ");
                return;
            }
            try
            {
                if (IorII == "S02")
                {
                    cmdChangeLanceNo1.Parameters[0].ConstantValue = cmbLanceNo.Text.Trim();
                    cmdChangeLanceNo1.Parameters[1].ConstantValue = UnitID;
                    if (cmdChangeLanceNo1.Execute() >= 0)
                    {
                        SRet = cmdChangeLanceNo1.Command.Return.ToString();
                        if (SRet == "1")
                        {
                            MessageBox.Show("�޸ĳɹ���", "��ʾ");
                            this.Close();
                        }
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, SRet);
                            MessageBox.Show("�޸�ʧ�ܣ�" + SRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ");
                }
                else if (IorII == "S03")
                {
                    cmdChangeLanceNo2.Parameters[0].ConstantValue = cmbLanceNo.Text.Trim();
                    cmdChangeLanceNo2.Parameters[1].ConstantValue = UnitID;
                    if (cmdChangeLanceNo2.Execute() >= 0)
                    {
                        SRet = cmdChangeLanceNo2.Command.Return.ToString();
                        if (SRet == "1")
                        {
                            MessageBox.Show("�޸ĳɹ���", "��ʾ");
                            this.Close();
                        }
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, SRet);
                            MessageBox.Show("�޸�ʧ�ܣ�" + SRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ");
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

        private void ChangeLanceShowFrm_Load(object sender, EventArgs e)
        {
            if(IorII == "S02")
            {
                rbtA.Text = "1#��λ";
                rbtB.Text = "2#��λ";
            }
            if (IorII == "S03")
            {
                rbtA.Text = "3#��λ";
                rbtB.Text = "4#��λ";
            }
        }

        //private void txtLanceNo_TextChanged(object sender, EventArgs e)
        //{
        //    btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        //}
    }
}