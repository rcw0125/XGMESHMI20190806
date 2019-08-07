using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class NewLanceShow : Form
    {
        public NewLanceShow()
        {
            InitializeComponent();
        }
        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();

        }
        private void NewLanceShow_Load(object sender, EventArgs e)
        {
            //自动设置最大喷枪号
            try
            {
                cmdGetLanceNo.Execute();
                string MaxLanceNo = cmdGetLanceNo.Command.Return.ToString();
                //txtLanceNo.Mask = @"\" + MaxLanceNo.Substring(0, 1) + @"\" + MaxLanceNo.Substring(1, 1)  + "000";//@"\" + MaxLanceNo.Substring(5, 1) + @"\" + MaxLanceNo.Substring(6, 1);
                txtLanceNo.Text = MaxLanceNo;
            }
            catch { }
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //新增一行
            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceNo"] = txtLanceNo.Text;
            newrow["LanceVendor"] = cmbVendor.Text;
            dsLance.Tables[0].Rows.Add(newrow);
            //dsError.SourceCondition = "OWNER = 'DesignateIronLadle'";
            string sRet = "";
            if (dsLance == null || dsLance.Tables[0].Rows.Count < 1)
                return;
            try
            {
                if (cmdNewLance.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdNewLance.Command.Return);
                    if (sRet == "1")
                    {
                        MessageBox.Show("新增成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("新增失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("新增失败！", "提示");
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}