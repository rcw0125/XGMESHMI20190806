using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class SteelDivFrm : Form
    {
        public SteelDivFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsDiv.Tables[0].Clear();
            dsDiv.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
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
            bsDiv.EndEdit();
            dsDiv.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ�ָ�¯��ô��", "��ʾ",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdDiv.Execute();
                String returnFlag = cmdDiv.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�ָ�¯�β��ɹ���" + strReasultShow, "��ʾ");
                }
            }
        }

    }
}