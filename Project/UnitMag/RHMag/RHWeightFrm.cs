using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHWeightFrm : Form
    {
        public RHWeightFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            if (UnitID.Length != 3)
                return DialogResult.None;

            return ShowDialog();
        }

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSetWeight_Click(object sender, EventArgs e)
        {
            if (txtHeatID.Text.Length < 1)
                return;

            float fweight = float.Parse(txtWeight.Text.Trim());
            if (fweight < 0)
                return;

            if ((cmdSetWeight.Execute() >= 0) && (Convert.ToBoolean(cmdSetWeight.Command.Return)))
            {
                MessageBox.Show("设置重量成功！", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("设置重量失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvSteels_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvSteels.Rows.Count < 1)
                btnSetWeight.Enabled = false;
            else
                btnSetWeight.Enabled = true;
        }
    }
}