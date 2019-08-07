using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class IronSlagApplyInfo : Form
    {
        public IronSlagApplyInfo()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            try
            {
                Adapter.Session = session;

                bsSampleApply.DataSource = null;
                bsSampleApply.DataSource = dsData;
                bsSampleApply.DataMember = dsData.Tables[0].TableName;

                ((System.Data.DataRowView)(bsSampleApply.Current)).DataView.Sort = strSort;
                bsSampleApply.Position = nPosition;


                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void IronSlagApply_Load(object sender, EventArgs e)
        {
            dsTapNo.LoadData();
        }

        private void cmbSamplyAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSamplyAddress.SelectedValue == null || cmbSamplyAddress.SelectedValue.ToString() == "")
                return;
            string strBFID = cmbSamplyAddress.SelectedValue.ToString().Substring(1, 1);
            mtxtTapNo.Mask = "1" + strBFID + "9999999";

            if (dsTapNo == null && dsTapNo.Tables[0].Rows.Count < 1)
            {
                mtxtTapNo.Text = "";
                return;
            }
            DataRow[] drArray = dsTapNo.Tables[0].Select("BFID = '" + strBFID + "'");
            if (drArray.Length < 1)
            {
                mtxtTapNo.Text = "";
                return;
            }
            mtxtTapNo.Text = drArray[0]["TAPNO"].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsSampleApply.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsSampleApply.CancelEdit();
            this.Close();
        }
    }
}