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
                MessageBox.Show("请选择真空槽上下部槽号！","提示");
                return;
            }

            cmdpUpID.ConstantValue = cmbUpID.Text.Trim();
            cmdpDownID.ConstantValue = cmbDownID.Text.Trim();
            if (cmdInstall.Execute() >= 0)
            {
                if (Convert.ToInt32(cmdInstall.Command.Return) > 0)
                {
                    MessageBox.Show("组装成功！", "提示");
                    this.Close();
                }
                else
                    MessageBox.Show("组装失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}