using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFStackMagFrm : Form
    {
        public BOFStackMagFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            try
            {
                if (session == null || UnitID.Length != 3)
                    return DialogResult.None;
                this.Text = UnitID + "--" + this.Text;

                cmdSetStack.Object = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\" + UnitID;
               
                Adapter.Session = session;

                DataRow newrow = dsStack.Tables[0].NewRow();
                newrow["BOFID"] = UnitID;
                dsStack.Tables[0].Rows.Add(newrow);
           
                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void BOFStackMagFrm_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("确认要炉衬维护么？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                
                cmdSetStack.Execute();
                String returnFlag = cmdSetStack.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("炉衬维护成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("炉衬维护不成功！", "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}