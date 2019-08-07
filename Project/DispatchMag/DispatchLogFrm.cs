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

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsNote.Clear();
            DataRow newrow = dsNote.Tables[0].NewRow();

            newrow["Note"] = rtxtNote.Text.ToString();
            dsNote.Tables[0].Rows.Add(newrow);
            dsNote.LoadData();
            string check = MessageBox.Show("确认要录入记事信息么？", "提示", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdNote.Execute();
                String returnFlag = cmdNote.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("录入记事信息成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("录入记事信息不成功！错误代码：" + returnFlag, "提示");
                }
            }

        }

        //窗体加载
        private void DispatchLogFrm_Load(object sender, EventArgs e)
        {
            rtxtNote.Text ="";
        }

    }
}