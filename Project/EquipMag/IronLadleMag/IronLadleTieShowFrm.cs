using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleTieShowFrm : Form
    {
        public IronLadleTieShowFrm()
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

        private void IronLadleTieDefendFrm_Load(object sender, EventArgs e)
        {
            cmbIronLadleID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtConsumption.TextChanged += new EventHandler(pxControls_TextChanged);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChanged);
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

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}