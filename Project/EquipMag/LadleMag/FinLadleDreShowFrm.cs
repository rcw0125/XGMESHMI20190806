using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class FinLadleDreShowFrm : Form
    {
        public FinLadleDreShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int nPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            (bsMain.Current as System.Data.DataRowView).DataView.Sort = strSort;
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
            bsMain.CancelEdit();
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void FinLadleDreShowFrm_Load(object sender, EventArgs e)
        {
            txtWaterGapBriWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBreatheBriWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBotWallRepMatWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSpiCastWast.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}