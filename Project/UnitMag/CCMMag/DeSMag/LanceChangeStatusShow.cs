using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class LanceChangeStatusShow : Form
    {
        public LanceChangeStatusShow()
        {
            InitializeComponent();
        }

        private string strLanceNo = "";
        private string strStatus = "";
        public void ShowDialogEx(AppSvrIF.Session session,string LanceNo,string Status)
        {
            Adapter.Session = session;
            strLanceNo = LanceNo;
            strStatus = Status;
            lbLanceNo.Text = strLanceNo;
            cmbVendor.SelectedValue = Convert.ToInt32(strStatus);
            this.ShowDialog();
        }

        private void LanceChangeStatusShow_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //dsError.SourceCondition = "OWNER = 'DesignateIronLadle'";
            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceNo"] = strLanceNo;
            newrow["Status"] = cmbStatus.SelectedValue.ToString();
            dsLance.Tables[0].Rows.Add(newrow);
            string sRet = "";
            if (dsLance == null || dsLance.Tables[0].Rows.Count < 1)
                return;
            try
            {
                if (cmdChangeLanceStatus.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdChangeLanceStatus.Command.Return);
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
    }
}