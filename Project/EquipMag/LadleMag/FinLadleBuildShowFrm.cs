using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class FinLadleBuildShowFrm : Form
    {
        public FinLadleBuildShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strSort, int nPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session; 
            cmbLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbLadleID.SelectedIndex = 0; 
            
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

        private void FinLadleBuildShowFrm_Load(object sender, EventArgs e)
        {
            txtLadleAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLadleInnerUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWaterGapBriWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBreatheBriWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBotProRefrWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBotWokeRefrWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWallRefrWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSlagLineRefeWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBotWallRepMatWast.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSpiCastWast.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
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
    }
}