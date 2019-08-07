using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFHeatRemarkFrm : Form
    {
        public BOFHeatRemarkFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        private void BOFHeatRemarkFrm_Load(object sender, EventArgs e)
        {
            rtxtRemark.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbTypeID.TextChanged += new EventHandler(pxControls_TextChanged);

            cmbHeatID.SelectedIndex = 0;
            cmbTypeID.SelectedIndex = 0;
        }
    }
}