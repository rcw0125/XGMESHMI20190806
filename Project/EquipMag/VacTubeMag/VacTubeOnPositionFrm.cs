using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeOnPositionFrm : Form
    {
        public VacTubeOnPositionFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            dsOnPosition.Tables[0].Rows.Add();
            Adapter.Session = session;

            return ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsOnPosition.EndEdit();
            dsOnPosition.AcceptChanges();
            cmdOnPosition.Execute();
            if (Convert.ToBoolean(cmdOnPosition.Command.Return))
            {
                MessageBox.Show("操作成功！", "提示！");
                this.Close();
            }
            else
                MessageBox.Show("操作失败！", "提示！");
        }

        //名称改变
        private void cmbVacTubeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbVacTubeName.SelectedValue == null || cmbVacTubeName.SelectedValue.ToString() == "")
            //    return;
           
            //if (cmbVacTubeName.SelectedValue.ToString() == "1")
            //{
            //    cmbVacTubeID.DataSource = null;
            //    cmbVacTubeID.DataSource = bsTop;
            //    cmbVacTubeID.DisplayMember = "VacTube_Id";
            //    cmbVacTubeID.ValueMember = "VacTube_Id";
            //}
            //else if (cmbVacTubeName.SelectedValue.ToString() == "2")
            //{
            //    cmbVacTubeID.DataSource = null;
            //    cmbVacTubeID.DataSource = bsLow;
            //    cmbVacTubeID.DisplayMember = "VacTube_Id";
            //    cmbVacTubeID.ValueMember = "VacTube_Id";
            //}
            //else if (cmbVacTubeName.SelectedValue.ToString() == "3")
            //{
            //    cmbVacTubeID.DataSource = null;
            //    cmbVacTubeID.DataSource = bsHot;
            //    cmbVacTubeID.DisplayMember = "VacTube_Id";
            //    cmbVacTubeID.ValueMember = "VacTube_Id";
            //}
           
        }

        private void cmbVacTubeName_TextChanged(object sender, EventArgs e)
        {
            if (cmbVacTubeName.SelectedValue == null || cmbVacTubeName.SelectedValue.ToString() == "")
                return;

            if (cmbVacTubeName.SelectedValue.ToString() == "1")
            {
                cmbVacTubeID.DataSource = null;
                cmbVacTubeID.DataSource = bsTop;
                cmbVacTubeID.DisplayMember = "VacTube_Id";
                cmbVacTubeID.ValueMember = "VacTube_Id";
            }
            else if (cmbVacTubeName.SelectedValue.ToString() == "2")
            {
                cmbVacTubeID.DataSource = null;
                cmbVacTubeID.DataSource = bsLow;
                cmbVacTubeID.DisplayMember = "VacTube_Id";
                cmbVacTubeID.ValueMember = "VacTube_Id";
            }
            else if (cmbVacTubeName.SelectedValue.ToString() == "3")
            {
                cmbVacTubeID.DataSource = null;
                cmbVacTubeID.DataSource = bsHot;
                cmbVacTubeID.DisplayMember = "VacTube_Id";
                cmbVacTubeID.ValueMember = "VacTube_Id";
            }
            else
            {
                cmbVacTubeID.DataSource = null;
            }
        }
    }
}