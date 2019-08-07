using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class DispatchLogFrm : Form
    {
        public DispatchLogFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsNote.LoadData();
            this.Close();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsNote.Clear();
            DataRow newrow = dsNote.Tables[0].NewRow();

            newrow["Note"] = rtxtNote.Text.ToString();
            dsNote.Tables[0].Rows.Add(newrow);
            dsNote.LoadData();
            string check = MessageBox.Show("ȷ��Ҫ¼�������Ϣô��", "��ʾ", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdNote.Execute();
                String returnFlag = cmdNote.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("¼�������Ϣ�ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¼�������Ϣ���ɹ���������룺" + returnFlag, "��ʾ");
                }
            }

        }

        //�������
        private void DispatchLogFrm_Load(object sender, EventArgs e)
        {
            rtxtNote.Text ="";
        }

    }
}