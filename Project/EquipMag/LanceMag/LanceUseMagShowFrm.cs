using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LanceMag
{
    public partial class LanceUseMagShowFrm : Form
    {
        public string makeid = "";
        public string LANCE_HEAD_TYPE = "";
        public LanceUseMagShowFrm()
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

        private void LanceUseMagShowFrm_Load(object sender, EventArgs e)
        {
            cmbLanceID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCoolWaterFlow.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCoolWaterTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtOxygenPressure.TextChanged += new EventHandler(pxControls_TextChanged);
            txtOxygenFlow.TextChanged += new EventHandler(pxControls_TextChanged);
            txtFurnaceCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTotalLanceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);

            cmbLanceID.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //
            if (dsMakeID.Tables[0].Rows.Count > 0)
            {
                makeid = dsMakeID.Tables[0].Rows[0]["makeid"].ToString();
            }
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

        private void cmbLanceID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbLanceID.SelectedValue == null)
                return;

            dsMakeID.Tables[0].Clear();
            dsMakeID.SourceCondition = "LanceID = '" + cmbLanceID.SelectedValue.ToString() + "'";
            dsMakeID.L3DataAdapter = Adapter;
            //dsMakeID.L3DataAdapter = null;

            if (dsMakeID.Tables[0].Rows.Count > 0)
            {
                LANCE_HEAD_TYPE = dsMakeID.Tables[0].Rows[0]["LANCE_HEAD_TYPE"].ToString();
            }
           // txtLanceType.Text = dsMakeID.Tables[0].Rows[0]["Lance_Head_Type"].ToString();
        }

        
    }
}