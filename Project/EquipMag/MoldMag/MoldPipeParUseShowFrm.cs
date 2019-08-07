using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class MoldPipeParUseShowFrm : Form
    {
        public MoldPipeParUseShowFrm()
        {
            InitializeComponent(); 
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsUseInfo.DataSource = null;
            bsUseInfo.DataSource = dsData;
            bsUseInfo.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsUseInfo.Current)).DataView.Sort = strSort;
            bsUseInfo.Position = nPosition;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsUseInfo.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsUseInfo.CancelEdit();
            this.Close();
        }

        private void cmbCastID_TextChanged(object sender, EventArgs e)
        {
            if (cmbCastID.SelectedValue == null || cmbCastID.SelectedValue.ToString() == "")
            {
                cmbMoldID.DataSource = null;
                return;
            }
            string strCastID = cmbCastID.SelectedValue.ToString();
            switch (strCastID)
            {
                case "S61":
                case "S62":
                    cmbMoldID.DataSource = null;
                    cmbMoldID.DataSource = dsJ06;
                    cmbMoldID.DisplayMember = "L3DataTable.MoldID";
                    cmbMoldID.ValueMember = "L3DataTable.MoldID";
                    break;
                case "S63":
                case "S64":
                    cmbMoldID.DataSource = null;
                    cmbMoldID.DataSource = dsJ09;
                    cmbMoldID.DisplayMember = "L3DataTable.MoldID";
                    cmbMoldID.ValueMember = "L3DataTable.MoldID";
                    break;
                default:
                    cmbMoldID.DataSource = null;
                    break;
            }
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void MoldPipeParUseShowFrm_Load(object sender, EventArgs e)
        {
            cmbCastID_TextChanged(sender, e);
            cmbMoldID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCopperID.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCurUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtTotalUseCount.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCurPullMea.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTotalPullMea.TextChanged += new EventHandler(pxControls_TextChanged);
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