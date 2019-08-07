using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyAppFrm : Form
    {
        public AlloyAppFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            dsAlloyApp.Tables[0].Rows.Add();

            return ShowDialog();
        }

        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认
        private void button2_Click(object sender, EventArgs e)
        {
            
            bsAlloyApp.EndEdit();
            dsAlloyApp.AcceptChanges();
            string check = MessageBox.Show("确认要申请么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdAlloyApp.Execute();
                String returnFlag = cmdAlloyApp.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("申请成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("申请不成功！错误代码为：" + returnFlag, "提示");
                }
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AlloyAppFrm_Load(object sender, EventArgs e)
        {
            cmbAlloyAppUnitID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbAlloyCode.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAlloyAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbAlloyAppUnitID.SelectedIndex = 0;
            cmbAlloyCode.SelectedIndex = 0;
        }

        private void AlloyAppFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}