using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BulkStore
{
    public partial class BulkAppFrm : Form
    {
        public BulkAppFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            dsBulkApp.Tables[0].Rows.Add();

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
            
            bsBulkApp.EndEdit();
            dsBulkApp.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBulkApp.Execute();
                String returnFlag = cmdBulkApp.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("����ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���벻�ɹ���" , "��ʾ");
                }
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void BulkAppFrm_Load(object sender, EventArgs e)
        {
            cmbBulkAppUnitID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbBulkName.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBulkWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbBulkAppUnitID.SelectedIndex = 0;
            cmbBulkName.SelectedIndex = 0;
        }

        private void BulkAppFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}