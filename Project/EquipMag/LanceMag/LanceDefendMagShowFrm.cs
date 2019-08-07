using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LanceMag
{
    public partial class LanceDefendMagShowFrm : Form
    {

        public string makeid = "";
        public LanceDefendMagShowFrm()
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
            bsMain.EndEdit();
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void LanceDefendMagShowFrm_Load(object sender, EventArgs e)
        {
            txtNasalErosion.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void pxTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (pxTextBox1.Text == null)
                return;

            dsMakeID.Tables[0].Clear();
            dsMakeID.SourceCondition = "LanceID = '" + pxTextBox1.Text.ToString() + "'";
            dsMakeID.L3DataAdapter = Adapter;
            dsMakeID.L3DataAdapter = null;

            if (dsMakeID.Tables[0].Rows.Count>0)
            {
                makeid = dsMakeID.Tables[0].Rows[0]["makeid"].ToString();
            }
            //txtLanceType.Text = dsMakeID.Tables[0].Rows[0]["Lance_Head_Type"].ToString();
        }

    }
}