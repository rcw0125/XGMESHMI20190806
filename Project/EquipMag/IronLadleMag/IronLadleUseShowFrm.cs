using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleUseShowFrm : Form
    {
        public IronLadleUseShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,int nPosition,string strSort,ref AppSvrHMI.L3DataSet dsData)
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
            this.Close();
        }

        private void IronLadleUseDefendFrm_Load(object sender, EventArgs e)
        {
            cmbIronLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWallTEMP.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBottomTEMP.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAge.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void cmbStopReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStopReason.SelectedValue != null && cmbStopReason.SelectedValue.ToString() == CommDataMag.CommonData.CIRONLADLE_STOPREASON_TEMP)//包壁或包底温度过高
            {
                dtThrow.Enabled = true;
                txtThrow.Text = dtThrow.Text;
            }
            else
            {
                txtThrow.Text = null;
                dtThrow.Enabled = false;
            }
        }

        private void dtThrow_ValueChanged(object sender, EventArgs e)
        {
            if (dtThrow.Enabled)
            {
                txtThrow.Text = dtThrow.Text;
            }
            else
            {
                txtThrow.Text = null;
            }
        }

        private void cmbIronLadleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbIronLadleID.Text == null || cmbIronLadleID.Text == "")
            //    return;
            //cmdGetAge.Execute();
            //int iAge = Convert.ToInt16(cmdGetAge.Command.Return) + 1;
            //txtAge.Text = iAge.ToString();
        }

        private void txtThrow_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dtThrow.Value = Convert.ToDateTime(txtThrow.Text);
            }
            catch
            { }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}