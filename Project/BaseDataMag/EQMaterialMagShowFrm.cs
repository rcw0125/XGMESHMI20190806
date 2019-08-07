using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseDataMag
{
    public partial class EQMaterialMagShowFrm : Form
    {
        public EQMaterialMagShowFrm()
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


        private void EQMaterialMagShowFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void cmbGroupDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGroupDes = cmbGroupDes.Text;

            switch (strGroupDes)
            {
                case "钢包":
                    txtGroupCode.Text = "LadleFac";
                    break;
                case "中包":
                    txtGroupCode.Text = "TundishFac";
                    break;
                case "结晶器":
                    txtGroupCode.Text = "MoldFac";
                    break;
                case "氧枪":
                    txtGroupCode.Text = "LanceFac";
                    break;
                case "真空槽管":
                    txtGroupCode.Text = "VacTubeFac";
                    break;
                default:
                    txtGroupCode.Text = "";
                    break;
            }
        }

        private void txtGroupCode_TextChanged(object sender, EventArgs e)
        {
            string strGroupCode = txtGroupCode.Text;
            switch (strGroupCode)
            {
                case "IronLadleFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsIronLadeFac;

                    break;
                case "LadleFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsLadleFac;
                    break;
                case "TundishFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsTundishFac;
                    break;
                case "MoldFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsMoldFac;
                    break;
                case "LanceFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsLanceFac;
                    break;
                case "VacTubeFac":
                    cmbMatName.DataSource = null;
                    cmbMatName.DisplayMember = "Code_Des";
                    cmbMatName.ValueMember = "Code_Des";
                    cmbMatName.DataSource = bsVacTubeFac;
                    break;
                default:
                    break;
            }
        }

    }
}