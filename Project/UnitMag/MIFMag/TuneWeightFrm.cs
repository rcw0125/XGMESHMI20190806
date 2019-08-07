using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class TuneWeightFrm : Form
    {
        public TuneWeightFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strMIFID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //存铁调整
        private void btnTuneWeight_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}