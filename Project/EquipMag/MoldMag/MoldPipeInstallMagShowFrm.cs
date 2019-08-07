using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class MoldPipeInstallMagShowFrm : Form
    {
        public MoldPipeInstallMagShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int iPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsInstall.DataSource = null;
            bsInstall.DataSource = dsData;
            bsInstall.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsInstall.Current)).DataView.Sort = strSort;
            bsInstall.Position = iPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsInstall.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsInstall.CancelEdit();
            this.Close();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void MoldPipeInstallMagShowFrm_Load(object sender, EventArgs e)
        {
            cmbMoldID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCopperID.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}
