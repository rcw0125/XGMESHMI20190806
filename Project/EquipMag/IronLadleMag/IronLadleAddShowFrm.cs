using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleAddShowFrm : Form
    {
        public IronLadleAddShowFrm()
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
            string IronLadleNo = txtIronLadleNo.Text.Trim();
            //判断铁包号是否为"T99"形式
            if (IronLadleNo.Length == 3)
            {
                DataRow newrow = dsIronLadle.Tables[0].NewRow();
                newrow["IronLadleID"] = IronLadleNo;
                newrow["Status"] = "10";
                dsIronLadle.Tables[0].Rows.Add(newrow);
                if (dsIronLadle.UpdateData())
                {
                    MessageBox.Show("新增铁包成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增铁包失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("您输入的铁包号不符合规范，请检查！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}