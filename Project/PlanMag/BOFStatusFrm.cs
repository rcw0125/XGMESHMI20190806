using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class BOFStatusFrm : Form
    {
        public BOFStatusFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx ( AppSvrIF.Session session  )
        {
            Adapter.Session = session;
            this.ShowDialog();
        }
        
        //È·ÈÏ
        private void btnConfirm_Click ( object sender , EventArgs e )
        {
            dvBOFStatus.EndEdit();
            bsBOFStatus.EndEdit();
            dsBOFStatus.UpdateData();
        }

        //ÍË³ö
        private void btnExit_Click ( object sender , EventArgs e )
        {
            this.Close();
        }

        private void dvBOFStatus_DataError ( object sender , DataGridViewDataErrorEventArgs e )
        {
        }

        private void BOFStatusFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}