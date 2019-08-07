using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class TappedFrm : Form
    {
        public TappedFrm()
        {
            InitializeComponent();
        }

        public string LadleID
        {
            get { return this.cmbLadle.Text; }
        }
        public string Destination
        {
            get { return this.cmbDestination.Text; }
        }

        public double Weight
        {
            get { return double.Parse(this.tbWeight.Text); }
            set { tbWeight.Text = value.ToString(); }
        }

        public double ReturnSteelWeight
        {
            get { return double.Parse(this.txtReturnSteelWeight.Text); }
            set { txtReturnSteelWeight.Text = value.ToString(); }
        } 

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1, 0);
        }

        private void TappedFrm_Load(object sender, EventArgs e)
        {
            cmbLadle.TextChanged += new EventHandler(pxControls_TextChanged);
            tbWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            txtReturnSteelWeight.Text = "0";
            cmbDestination.Text = "×ªÂ¯(Ì¼¸Ö)";
            txtReturnSteelWeight.TextChanged += new EventHandler(pxControls_TextChanged);
        }

 


    }
}