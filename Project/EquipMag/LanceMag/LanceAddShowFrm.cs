using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.LanceMag
{
    public partial class LanceAddShowFrm : Form
    {
        public LanceAddShowFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbBOFID.Text == "")
            {
                MessageBox.Show("请选择使用转炉！", "提示");
                return;
            }
            if (txtLanceNoA.Text.Length != 4)
            {
                MessageBox.Show("您输入的氧枪号不符合规范，请检查！", "提示");
                return;
            }

            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceID"] = txtLanceNoA.Text;
            newrow["Status"] = "05";
            newrow["Lance_Head_Type"] = txtLanceHeadType.Text;
            dsLance.Tables[0].Rows.Add(newrow);
            if (dsLance.UpdateData())
            {
                MessageBox.Show("新增氧枪成功！", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("新增氧枪失败！请检查是否该氧枪已存在", "提示");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBOFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBOFID.Text == "1#转炉")
            {
                txtLanceNoA.Mask = "YB99";
                txtLanceHeadType.Text = "Φ180";
            }
            if (cmbBOFID.Text == "2#转炉" || cmbBOFID.Text == "3#转炉")
            {
                txtLanceNoA.Mask = @"Y\A99";
                txtLanceHeadType.Text = "Φ168";
            }
            if (cmbBOFID.Text == "4#转炉")
            {
                txtLanceNoA.Mask = @"Y\C99";
                txtLanceHeadType.Text = "Φ219";
            }
        }
    }
}