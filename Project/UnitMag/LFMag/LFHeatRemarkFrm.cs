using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFHeatRemarkFrm : Form
    {
        public LFHeatRemarkFrm()
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
        private void LFHeatRemarkFrm_Load(object sender, EventArgs e)
        {
            cmbHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbType.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtRemark.TextChanged += new EventHandler(pxControls_TextChanged);

            cmbHeatID.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }
    }
}