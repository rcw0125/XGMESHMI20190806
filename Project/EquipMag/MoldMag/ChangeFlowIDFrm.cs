using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class ChangeFlowIDFrm : Form
    {
        public ChangeFlowIDFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strMoldID,string strCCMID)
        {
            Adapter.Session = session;
            txtMoldID.Text = strMoldID;
            txtCCMID.Text = strCCMID;
            //[20081230]
            return ShowDialog();
        }

        public string FlowID
        {
            get { return cmbFlowID.Text.Trim(); }
            set { cmbFlowID.Text = value.ToString(); }
        }

    }
}