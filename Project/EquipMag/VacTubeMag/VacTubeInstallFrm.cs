using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeInstallFrm : Form
    {
        public VacTubeInstallFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        private void VacTubeInstallFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbUpID.Text.Trim() == "" || cmbDownID.Text.Trim() == "")
            {
                MessageBox.Show("��ѡ����ղ����²��ۺţ�","��ʾ");
                return;
            }

            cmdpUpID.ConstantValue = cmbUpID.Text.Trim();
            cmdpDownID.ConstantValue = cmbDownID.Text.Trim();
            if (cmdInstall.Execute() >= 0)
            {
                if (Convert.ToInt32(cmdInstall.Command.Return) > 0)
                {
                    MessageBox.Show("��װ�ɹ���", "��ʾ");
                    this.Close();
                }
                else
                    MessageBox.Show("��װʧ�ܣ�", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}