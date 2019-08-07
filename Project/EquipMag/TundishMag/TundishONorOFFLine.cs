using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.TundishMag
{
    public partial class TundishONorOFFLine : Form
    {
        public TundishONorOFFLine()
        {
            InitializeComponent();
        }
        private bool bONLine = true;

        public DialogResult ShowDialogEx(AppSvrIF.Session session, bool bOnLine, string strTundishID, string strTundishNO, string strCCMID)
        {
            dtTime.Value = DateTime.Now;

            Adapter.Session = session;
            bONLine = bOnLine;
            if (!bOnLine)
                this.Text = "�а�����";
            if (strTundishID == "" || strCCMID == "")
                return DialogResult.None;
            txtTundishID.Text = strTundishID;
            txtTundishNO.Text = strTundishNO;
            txtCCMID.Text = strCCMID;
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (bONLine)
            {
                cmdOnLine.Parameters[0].ConstantValue = txtTundishID.Text.Trim();
                cmdOnLine.Parameters[1].ConstantValue = txtTundishNO.Text.Trim();
                cmdOnLine.Parameters[2].ConstantValue = dtTime.Value.ToString();
                if (cmdOnLine.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdOnLine.Command.Return) > 0)
                    {
                        MessageBox.Show("�а����߳ɹ���", "��ʾ", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("�а�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("�а�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
            else
            {
                cmdOFFLine.Parameters[0].ConstantValue = txtTundishID.Text.Trim();
                cmdOFFLine.Parameters[1].ConstantValue = txtTundishNO.Text.Trim();
                cmdOFFLine.Parameters[2].ConstantValue = dtTime.Value.ToString();
                if (cmdOFFLine.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdOFFLine.Command.Return) > 0)
                    {
                        MessageBox.Show("�а����߳ɹ���", "��ʾ", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("�а�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("�а�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}