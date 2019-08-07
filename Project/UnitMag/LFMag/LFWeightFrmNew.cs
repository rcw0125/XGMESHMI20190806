using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFWeightFrmNew : Form
    {
        public LFWeightFrmNew()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((cmdDesignate.Execute() >= 0) && (Convert.ToBoolean(cmdDesignate.Command.Return)))
            {
                MessageBox.Show("����ָ���ɹ���", "��ʾ");
            }
            else
            {
                MessageBox.Show("����ָ��ʧ�ܣ�", "��ʾ");
            }
        }

        private void btnSetWeight_Click(object sender, EventArgs e)
        {
            if ((cmdSetWeight.Execute() >= 0) && (Convert.ToBoolean(cmdSetWeight.Command.Return)))
            {
                MessageBox.Show("���������ɹ���", "��ʾ");
                this.Close();
            }
            else
            {
                MessageBox.Show("��������ʧ�ܣ�", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvSteels_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvSteels.Rows.Count < 1)
            {
                btnDesignate.Enabled = false;
                btnSetWeight.Enabled = false;
            }
            else
            {
                btnDesignate.Enabled = true;
                btnSetWeight.Enabled = true;
            }
        }

    }
}