using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleFireShowFrm : Form
    {
        public IronLadleFireShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;

            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
            bsMain.Position = nPosition;

            return ShowDialog();
        }

        private void IronLadleFireDefendFrm_Load(object sender, EventArgs e)
        {
            cmbFireType.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbIronLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void dtFire_ValueChanged(object sender, EventArgs e)
        {
            double dstart = dtFireStart.Value.ToOADate();
            double dend = dtFireEnd.Value.ToOADate();

            double dTotal = Math.Round((dend - dstart) * 24, 2);
            txtFireLength.Text = dTotal.ToString();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}