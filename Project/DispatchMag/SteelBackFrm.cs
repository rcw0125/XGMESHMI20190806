using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class SteelBackFrm : Form
    {
        public SteelBackFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            //2008-12-30
            string strCheckFlag = dsData.Tables[0].Rows[0]["Back_Flag"].ToString();
            if (strCheckFlag == "1")
            {
                MessageBox.Show("当前申请\"已经处理完毕\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DialogResult.None;
            }

            Adapter.Session = session;
            dsBack.Tables[0].Clear();
            dsBack.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            return ShowDialog();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBack.EndEdit();
            string check = MessageBox.Show("确认要返送钢水么？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBack.Execute();
                String returnFlag = cmdBack.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("返送钢水不成功！" + strReasultShow, "提示");
                }
            }
        }

        private void SteelBackFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}