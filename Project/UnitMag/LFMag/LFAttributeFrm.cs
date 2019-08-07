using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFAttributeFrm : Form
    {
        public LFAttributeFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;
            txtLFID.Text = UnitID;
            return ShowDialog();
        }

        private void LFAttributeFrm_Load(object sender, EventArgs e)
        {
            dsLFUnit.SourceCondition = "NAME = '" + txtLFID.Text + "'";
            dsPoleVendor.LoadData();
            cmbPoleVendor.Text = dsLFUnit.Tables[0].Rows[0]["Pole_Vendor"].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsLFUnit.EndEdit();
            bool  blup = dsLFUnit.UpdateData();
            if (blup)
            {
                MessageBox.Show("属性设置成功！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("属性设置失败！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}