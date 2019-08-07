using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QualityMag.LabMag
{
    public partial class AdviceInfoFrm : Form
    {
        public AdviceInfoFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;

            bsAdvice.DataSource = null;
            bsAdvice.DataSource = dsData;
            bsAdvice.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsAdvice.Current)).DataView.Sort = strSort;
            bsAdvice.Position = nPosition;

            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsAdvice.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsAdvice.CancelEdit();
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AdviceInfoFrm_Load(object sender, EventArgs e)
        {
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCutCount.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbCutPosition.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbCutSize.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}