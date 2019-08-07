using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.TundishMag
{
    public partial class TundishAddShowFrm : Form
    {
        public TundishAddShowFrm()
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
            if (txtTundishNo.Text.Length == 4)
            {
                DataRow newrow = dsTundish.Tables[0].NewRow();
                newrow["TundishID"] = txtTundishNo.Text;
                newrow["Status"] = "10";
                if (cmbTundishType.Text == "")
                {
                    MessageBox.Show("请选择中包类型！", "提示");
                    return;
                }
                if(cmbTundishType.Text == "1#、2#机")
                {
                    newrow["TundishType"] = 1;
                }
                if(cmbTundishType.Text == "3#、4#机")
                {
                    newrow["TundishType"] = 2;
                }
                if (cmbTundishType.Text == "5#机")
                {
                    newrow["TundishType"] = 3;
                }
                //杨前 20110312 增加7#机对应TundishType=4
                if (cmbTundishType.Text == "7#机")
                {
                    newrow["TundishType"] = 4;
                }
                //add by hyh 2012-06-08
                //杨前 20110312 增加7#机对应TundishType=4
                if (cmbTundishType.Text == "6#机")
                {
                    newrow["TundishType"] = 5;
                }
                //end
                dsTundish.Tables[0].Rows.Add(newrow);
                if (dsTundish.UpdateData())
                {
                    MessageBox.Show("新增中包成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增中包失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("您输入的中包号不符合规范，请检查！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}