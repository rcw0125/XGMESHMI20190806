using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFFeedIronFrm : Form
    {
        public BOFFeedIronFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //¯�ζ���
        private void btnFeedIron_Click(object sender, EventArgs e)
        {

        }

        //����
        private void btnAddMat_Click(object sender, EventArgs e)
        {

        }

        //����
        private void btnOx_Click(object sender, EventArgs e)
        {

        }

        //����
        private void btnTemp_Click(object sender, EventArgs e)
        {

        }

        //���ֽ���
        private void btnTapEnd_Click(object sender, EventArgs e)
        {

        }
    }
}