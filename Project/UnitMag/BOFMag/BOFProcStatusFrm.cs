using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFProcStatusFrm : Form
    {
        public BOFProcStatusFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
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
        private void BOFProcStatusFrm_Load(object sender, EventArgs e)
        {
            txtNextHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}