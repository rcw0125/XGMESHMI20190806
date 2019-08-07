using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class LadleInnerBuildMagShowFrm : Form
    {
        public LadleInnerBuildMagShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strSort, int iPosition,ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            cmbLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbLadleID.SelectedIndex = 0;

            bsBuildInfo.DataSource = null;
            bsBuildInfo.DataSource = dsData;
            bsBuildInfo.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsBuildInfo.Current)).DataView.Sort = strSort;
            bsBuildInfo.Position = iPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBuildInfo.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsBuildInfo.CancelEdit();
            this.Close();
        }

        private void LadleInnerBuildMagShowFrm_Load(object sender, EventArgs e)
        {
            txtLadleInnerUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAtoLigCastWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHardFiAdiBoaWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSpinelCastWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAlMgBrickWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtMgFirecalyWast.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        
    }
}