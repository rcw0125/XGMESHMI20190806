using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeRepairShowFrm : Form
    {
        public VacTubeRepairShowFrm()
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

        private void cmbVacTubeName_TextChanged(object sender, EventArgs e)
        {
            if (cmbVacTubeName.SelectedValue == null || cmbVacTubeName.SelectedValue.ToString() == "0")
            {
                cmbVacTubeID.DataSource = null;
            }
            else if (cmbVacTubeName.SelectedValue.ToString() == "1")
            {
                cmbVacTubeID.DataSource = null;
                cmbVacTubeID.DataSource = bsTop;
                cmbVacTubeID.DisplayMember = "VacTube_ID";
                cmbVacTubeID.ValueMember = "VacTube_ID";
            }
            else if (cmbVacTubeName.SelectedValue.ToString() == "2")
            {
                cmbVacTubeID.DataSource = null;
                cmbVacTubeID.DataSource = bsLow;
                cmbVacTubeID.DisplayMember = "VacTube_ID";
                cmbVacTubeID.ValueMember = "VacTube_ID";
            }
            else
            {
                cmbVacTubeID.DataSource = null;
            }
           
        }

        private void VacTubeRepairShowFrm_Load(object sender, EventArgs e)
        {
           
        }

    }
}