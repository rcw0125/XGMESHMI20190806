using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.EquipAdjust
{
    public partial class EquipAdjustDetailFrm : Form
    {
        public EquipAdjustDetailFrm()
        {
            InitializeComponent();
        }

        private DataSet dsData = new DataSet();
        public DialogResult ShowDialogEx(AppSvrIF.Session session,ref DataSet ds)
        {
            Adapter.Session = session;

            dsData = ds;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsData.Tables[0].Rows[0]["Load_B_Std"] = txtLoad_B_Std.Text.ToString();
            dsData.Tables[0].Rows[0]["Load_B_Act"] = txtLoad_B_Act.Text.ToString();
            dsData.Tables[0].Rows[0]["Load_B_Dif"] = txtLoad_B_Dif.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_B_Std"] = txtUnLoad_B_Std.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_B_Act"] = txtUnLoad_B_Act.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_B_Dif"] = txtUnLoad_B_Dif.Text.ToString();
            dsData.Tables[0].Rows[0]["Load_A_Std"] = txtLoad_A_Std.Text.ToString();
            dsData.Tables[0].Rows[0]["Load_A_Act"] = txtLoad_A_Act.Text.ToString();
            dsData.Tables[0].Rows[0]["Load_A_Dif"] = txtLoad_A_Dif.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_A_Std"] = txtUnLoad_A_Std.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_A_Act"] = txtUnLoad_A_Act.Text.ToString();
            dsData.Tables[0].Rows[0]["UnLoad_A_Dif"] = txtUnLoad_A_Dif.Text.ToString();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinLadleDreShowFrm_Load(object sender, EventArgs e)
        {
            txtLoad_B_Std.Text = dsData.Tables[0].Rows[0]["Load_B_Std"].ToString();
            txtLoad_B_Act.Text = dsData.Tables[0].Rows[0]["Load_B_Act"].ToString();
            txtLoad_B_Dif.Text = dsData.Tables[0].Rows[0]["Load_B_Dif"].ToString();
            txtUnLoad_B_Std.Text = dsData.Tables[0].Rows[0]["UnLoad_B_Std"].ToString();
            txtUnLoad_B_Act.Text = dsData.Tables[0].Rows[0]["UnLoad_B_Act"].ToString();
            txtUnLoad_B_Dif.Text = dsData.Tables[0].Rows[0]["UnLoad_B_Dif"].ToString();
            txtLoad_A_Std.Text = dsData.Tables[0].Rows[0]["Load_A_Std"].ToString();
            txtLoad_A_Act.Text = dsData.Tables[0].Rows[0]["Load_A_Act"].ToString();
            txtLoad_A_Dif.Text = dsData.Tables[0].Rows[0]["Load_A_Dif"].ToString();
            txtUnLoad_A_Std.Text = dsData.Tables[0].Rows[0]["UnLoad_A_Std"].ToString();
            txtUnLoad_A_Act.Text = dsData.Tables[0].Rows[0]["UnLoad_A_Act"].ToString();
            txtUnLoad_A_Dif.Text = dsData.Tables[0].Rows[0]["UnLoad_A_Dif"].ToString();
        }
    }
}