using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QualityMag.QualityStandard
{
    public partial class NewAndOldSteelGrade : Form
    {
        public bool isCopy = false;
        public string newSteelGrade = "";

        //private string 

        public NewAndOldSteelGrade()
        {
            InitializeComponent();
        }

        public DialogResult showDialogForSteel(AppSvrIF.Session session, AppSvrHMI.L3DataSet ds)
        {
            // lblOldSteelGrade.Text = oldSteel;
            lblOldSteelGrade.Text = ds.Tables[0].Rows[0]["SteelGradeIndex"].ToString();//钢种记号
            lblSteelGrade.Text = ds.Tables[0].Rows[0]["SteelGrade"].ToString();//钢种
            lblSteelGroup.Text = ds.Tables[0].Rows[0]["Grade_Group_Code"].ToString();//钢组
            lblNC1.Text = ds.Tables[0].Rows[0]["NC_ZYX1"].ToString();//NC1
            lblNC2.Text = ds.Tables[0].Rows[0]["NC_ZYX2"].ToString();//NC2
            lblProtel.Text = ds.Tables[0].Rows[0]["Protocol"].ToString();//协议

            if (ds.Tables[0].Rows[0]["Use_Flag"].ToString() == "1")
            {
                lblUseFlag.Text = "禁用";　　//制造标准
            }
            else if (ds.Tables[0].Rows[0]["Use_Flag"].ToString() == "0")
            {
                lblUseFlag.Text = "在用";
            }
            else
                lblUseFlag.Text = "未定义";

            Adapter.Session = session;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // DialogResult = DialogResult.OK;
            if (txtNewSteelGrrade.Text == "" || txtNewSteelGrrade.Text == null)
                return;
            if (MessageBox.Show("确认要执行此操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                newSteelGrade = txtNewSteelGrrade.Text.Trim();
                isCopy = true;
                this.Close();
            }
            else
                return;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newSteelGrade = "";
            isCopy = false;
            this.Close();
        }




    }
}