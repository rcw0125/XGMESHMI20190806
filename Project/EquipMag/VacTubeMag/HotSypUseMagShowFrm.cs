using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class HotSypUseMagShowFrm : Form
    {
        public HotSypUseMagShowFrm()
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

        private void HotSypUseMagShowFrm_Load(object sender, EventArgs e)
        {
           
        }

        // ±≥§
        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            double dLength = 0;
            if (dtOnTime.Value.Date > dtOnTime.MinDate && dtOffTime.Value.Date > dtOffTime.MinDate)
                dLength = Math.Round(dtOffTime.Value.ToOADate() - dtOnTime.Value.ToOADate(), 1);
            else
                dLength = 0;
            txtLength.Text = dLength.ToString();
        }

        // Ÿ√¸
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float fOnAge = txtOnAge.Text.Trim().Length < 1 ? 0 : float.Parse(txtOnAge.Text.Trim());
                float fCurAge = txtCurAge.Text.Trim().Length < 1 ? 0 : float.Parse(txtCurAge.Text.Trim());
                float fTotalAge = fOnAge + fCurAge;
                txtTotalAge.Text = Math.Round(fTotalAge, 0).ToString();
            }
            catch { }
        }
    }
}