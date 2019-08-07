using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnergyMag
{
    public partial class ENConManualFrm : Form
    {
        public ENConManualFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        } 

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ENConManualFrm_Load(object sender, EventArgs e)
        {

        }
    }
}