using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class DeSIronSheetFrm : Form
    {
        public DeSIronSheetFrm()
        {
            InitializeComponent();
        }

        private string sBFNo = "";
        private string sTAPNo = "";
        private string sTPCNo = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session,string TAPNo,string TPCNo)
        {   
            Adapter.Session = session;
            sBFNo = TAPNo.Substring(0, 1).ToString();
            sTAPNo = TAPNo;
            sTPCNo = TPCNo;
            lbBFID.Text = sBFNo;
            lbTapNo.Text = sTAPNo;
            lbTpcNo.Text = sTPCNo;
            return ShowDialog();
        }

        private void DeSIronSheetFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsSend.Tables[0].Rows.Clear();
            DataRow newrow = dsSend.Tables[0].NewRow();
            newrow["TAP_No"] = lbTapNo.Text.Trim();
            newrow["TPC_No"] = lbTpcNo.Text.Trim();
            if(radioButton1.Checked)
                newrow["Mode"] = 1;
            else if (radioButton2.Checked)
                newrow["Mode"] = 2;
            else
            {
                MessageBox.Show("请选择试样类别！", "提示");
                return;
            }
            dsSend.Tables[0].Rows.Add(newrow);
            dsSend.AcceptChanges();
            cmdSend.Parameters[0].SourceObject = dsSend;
            if (cmdSend.Execute() >= 0)
            {
                int iRet = (int)cmdSend.Command.Return;
                if (iRet > 0)
                {
                    MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else { MessageBox.Show("操作失败！", "提示", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("操作失败！", "提示", MessageBoxButtons.OK); }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}