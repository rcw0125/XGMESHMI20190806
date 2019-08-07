using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class PathInfoFrm : Form
    {
        public PathInfoFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,int nPosition,ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;
            bsMain.Position = nPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        private void PathInfoFrm_Load(object sender, EventArgs e)
        {
            txtTAPNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTPCNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBFID.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        
    }
}