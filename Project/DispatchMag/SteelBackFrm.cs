using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class SteelBackFrm : Form
    {
        public SteelBackFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            //2008-12-30
            string strCheckFlag = dsData.Tables[0].Rows[0]["Back_Flag"].ToString();
            if (strCheckFlag == "1")
            {
                MessageBox.Show("��ǰ����\"�Ѿ��������\"��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DialogResult.None;
            }

            Adapter.Session = session;
            dsBack.Tables[0].Clear();
            dsBack.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            return ShowDialog();
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBack.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫ���͸�ˮô��", "��ʾ",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBack.Execute();
                String returnFlag = cmdBack.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���͸�ˮ���ɹ���" + strReasultShow, "��ʾ");
                }
            }
        }

        private void SteelBackFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}