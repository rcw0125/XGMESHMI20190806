using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XGMESMain
{
    public partial class PassWordMagFrm : Form
    {
        public PassWordMagFrm()
        {
            InitializeComponent();
        }

        private string strAccount = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void PassWordMagFrm_Load(object sender, EventArgs e)
        {
            strAccount = Adapter.Session.User;//获取用户账户
            txtAccount.Text = strAccount;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassWordNew.Text.Trim() != txtPassWordNewConfirm.Text.Trim())
            {
                MessageBox.Show("新密码与确认密码不一致,请重新输入！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppSvrIF.Command cmd = new AppSvrIF.Command();
            cmd.Type = (Int32)AppSvrIF.CommandType.ChangePWD;
            cmd.URI = strAccount;
            cmd.AddParameter(txtPassWordOld.Text.Trim(), AppSvrIF.ParamDir.In);
            cmd.AddParameter(txtPassWordNew.Text.Trim(), AppSvrIF.ParamDir.In);
            int iRet = Adapter.Session.Execute(cmd);
            if (iRet >= 0)
            {
                if (Convert.ToBoolean(cmd.Return))
                {
                    bool bRes = recordUpdPwdInfo(Adapter.Session.User, txtPassWordNew.Text);
                    if (bRes)
                        MessageBox.Show("密码修改成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("密码修改成功！但对于密码定时锁存在一个问题。", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("密码修改失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool recordUpdPwdInfo(string strId,string strPwd)
        {
            cmdUpdRecord.Parameters[0].ConstantValue = strId;
            cmdUpdRecord.Parameters[1].ConstantValue = strPwd;
            cmdUpdRecord.Adapter = Adapter;
            if (cmdUpdRecord.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdUpdRecord.Command.Return);
                if (iRet == 0)
                    return true;
                else
                    return false;

            }
            else
                return false;
        }
    }
}