using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LanceMag
{
    public partial class LanceMakeMagShowFrm : Form
    {
        public string makeid = "";
        public LanceMakeMagShowFrm()
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

        //确定
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

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void cmbLanceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanceID.SelectedValue == null)
                return;

            dsMakeID.Tables[0].Clear();
            dsMakeID.SourceCondition = "LanceID = '" + cmbLanceID.SelectedValue.ToString() + "'";
            dsMakeID.L3DataAdapter = Adapter;
            dsMakeID.L3DataAdapter = null;

            if (dsMakeID.Tables[0].Rows.Count < 1)
            {
                txtLanceHeadType.Text = "";
                dtAssemblyStartTime.Text = "";
                dtAssemblyEndTime.Text = "";

                return;
            }
            txtLanceHeadType.Text = dsMakeID.Tables[0].Rows[0]["Lance_Head_Type"].ToString();
            dtAssemblyStartTime.Text = dsMakeID.Tables[0].Rows[0]["Make_Start_Time"].ToString();
            dtAssemblyEndTime.Text = dsMakeID.Tables[0].Rows[0]["Make_End_Time"].ToString();
            txtMakeID.Text = dsMakeID.Tables[0].Rows[0]["MakeID"].ToString();
        }

        private void LanceMakeMagShowFrm_Load(object sender, EventArgs e)
        {
            cmbLanceID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtNozzleThroatDia.TextChanged += new EventHandler(pxControls_TextChanged);
            txtNozzleAngle.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTestWaterPressure.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);

            cmbLanceID.SelectedIndex = 0;
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}