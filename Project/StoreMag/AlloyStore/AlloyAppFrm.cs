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

        //ȡ��
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȷ��
        private void button2_Click(object sender, EventArgs e)
        {
            
            bsAlloyApp.EndEdit();
            dsAlloyApp.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdAlloyApp.Execute();
                String returnFlag = cmdAlloyApp.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("����ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���벻�ɹ����������Ϊ��" + returnFlag, "��ʾ");
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