using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class AdditionShowFrm : Form
    {
        public AdditionShowFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
                Adapter.Session = session;
                dsAdditon.Tables[0].Rows.Add(dsAdditon.Tables[0].NewRow());
                this.ShowDialog();
         
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsAddition.EndEdit();
            string s = dsAdditon.Tables.ToString();
            string sRet = "";
            if (cmdNewDeSAdditionData.Execute() >= 0)
            {
                sRet = Convert.ToString(cmdNewDeSAdditionData.Command.Return);
                if (sRet == "1")
                    MessageBox.Show("新增成功！", "提示");
                else
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                    MessageBox.Show("新增失败！" + sRet + strReasultShow, "提示");
                }
            }
            else
            {
                MessageBox.Show("新增失败！" , "提示");
            }
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AdditionShowFrm_Load(object sender, EventArgs e)
        {
            dsDeSUnitID.LoadData();
            txtWeight.TextChanged += new EventHandler(txtWeight_TextChanged);
            cmbUnitID.SelectedValue = "";
            txtWeight.Text = "0";
            dtpBegin.Value = DateTime.Now;
            dtpStop.Value = DateTime.Now;
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Adapter.DeleteURIParameter("name");
                Adapter.set_URIParameters("name", cmbUnitID.SelectedValue.ToString());
                //Adapter.RefreshDataBindings();
                if (cmbUnitID.SelectedValue.ToString() == "S02")
                {
                    cmbMatCode.SelectedValue = l3txtMatCode1.Text;
                    cmbMatVendor.SelectedValue = l3txtMatVendor1.Text;
                }
                else if (cmbUnitID.SelectedValue.ToString() == "S03")
                {
                    cmbMatCode.SelectedValue = l3txtMatCode2.Text;
                    cmbMatVendor.SelectedValue = l3txtMatVendor2.Text;
                }
                else
                {
                    MessageBox.Show("请选择工位","提示");
                }
            }
            catch { }
        }
    }
}