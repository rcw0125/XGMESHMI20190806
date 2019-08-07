using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.MoldMag
{
    public partial class MoldAddShowFrm : Form
    {
        public MoldAddShowFrm()
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
            if (txtMoldID.Text.Length == 5)
            {
                
                DataRow newrow = dsMold.Tables[0].NewRow();
                newrow["MoldID"] = txtMoldID.Text.Trim();
                newrow["Status"] = "01";
                newrow["Break_Face_Mea"] = cmbBreakFaceMea.Text.Trim();
                //add by hyh 2012-06-11
                newrow["UnitID"] = CmbUnitID.Text.Trim();
                //END
                dsMold.Tables[0].Rows.Add(newrow);
                if (dsMold.UpdateData())
                {
                    MessageBox.Show("新增结晶器成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增结晶器失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("您输入的结晶器号不符合规范，请检查！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBreakFaceMea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBreakFaceMea.Text == "8")
            {
                txtMoldID.Mask = @"J\0899";
            }
            if (cmbBreakFaceMea.Text == "9")
            {
                txtMoldID.Mask = @"J\0\999";
            }
            if (cmbBreakFaceMea.Text == "12")
            {
                txtMoldID.Mask = @"J1299";
            }
            if (cmbBreakFaceMea.Text == "16")
            {
                txtMoldID.Mask = @"J1699";
            }
            if (cmbBreakFaceMea.Text == "18")
            {
                txtMoldID.Mask = @"J1899";
            }
            if (cmbBreakFaceMea.Text == "09")
            {
                txtMoldID.Mask = @"J\9\999";
            }
        }
    }
}