using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class LanceChangeAgeShow : Form
    {
        public LanceChangeAgeShow()
        {
            InitializeComponent();
        }

        private string strLanceNo = "";
        private string strAge = "";
        public void ShowDialogEx(AppSvrIF.Session session,string LanceNo,string Age)
        {
            Adapter.Session = session;
            strLanceNo = LanceNo;
            strAge = Age;
            lbLanceNo.Text = strLanceNo;
            txtLanceAge.Text = strAge;
            this.ShowDialog();
        }

        private void LanceChangeAgeShow_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //dsError.SourceCondition = "OWNER = 'DesignateIronLadle'";
            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceNo"] = strLanceNo;
            newrow["LanceAge"] = txtLanceAge.Text.Trim();
            dsLance.Tables[0].Rows.Add(newrow);
            string sRet = "";
            if (dsLance == null || dsLance.Tables[0].Rows.Count < 1)
                return;
            try
            {
                if (cmdChangeLanceAge.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdChangeLanceAge.Command.Return);
                    if (sRet == "1")
                    {
                        MessageBox.Show("修改成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("修改失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("修改失败！", "提示");
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LanceChangeAgeShow_Load_1(object sender, EventArgs e)
        {
            txtLanceAge.TextChanged += new EventHandler(txtLanceAge_TextChanged);
        }

        private void txtLanceAge_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}