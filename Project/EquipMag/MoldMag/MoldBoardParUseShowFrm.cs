using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class MoldBoardParUseShowFrm : Form
    {
        public MoldBoardParUseShowFrm()
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

        private void MoldBoardParUseShowFrm_Load(object sender, EventArgs e)
        {
            txtLugSteelMea.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbMoldID.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCurUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtTotalUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCurPullMea.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTotalPullMea.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        ////上线20081228Liao
        //private void ckbOnLine_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckbOnLine.Checked)
        //    {
        //        dtOnLine.Enabled = true;
        //        dtOnLine.Value = DateTime.Now;

        //        if (ckbOffLine.Checked)
        //        {
        //            ckbOffLine.Checked = false;
        //            dtOffLine.Enabled = false;
        //            dtOffLine.Value = Convert.ToDateTime("1899-12-30");
        //        }
        //    }
        //    else
        //    {
        //        dtOnLine.Enabled = false;
        //        dtOnLine.Value = Convert.ToDateTime("1899-12-30");
        //    }
        //}

        ////下线20081228Liao
        //private void ckbOffLine_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckbOffLine.Checked)
        //    {
        //        dtOffLine.Enabled = true;
        //        dtOffLine.Value = DateTime.Now;
        //        cmbStopReason.Enabled = true;

        //        if (ckbOnLine.Checked)
        //        {
        //            ckbOnLine.Checked = false;
        //            dtOnLine.Enabled = false;
        //            dtOnLine.Value = Convert.ToDateTime("1899-12-30");
        //        }
        //    }
        //    else
        //    {
        //        dtOffLine.Enabled = false;
        //        dtOffLine.Value = Convert.ToDateTime("1899-12-30");
        //        cmbStopReason.Enabled = false;
        //        cmbStopReason.Text = "";
        //    }
        //}
        
    }
}