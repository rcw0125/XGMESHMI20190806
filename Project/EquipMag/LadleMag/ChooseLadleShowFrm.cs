using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class ChooseLadleShowFrm : Form
    {
        public ChooseLadleShowFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsPlan.DataSource = null;
            bsPlan.DataSource = dsData;
            bsPlan.DataMember = dsData.Tables[0].TableName;

            bsPlan.MoveFirst();

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsPlan.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}