using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFTechicsExceptionFrm : Form
    {
        public LFTechicsExceptionFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void cmbHeatID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}