using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XGMESMain
{
    public enum LoginFlags : int
    {
        loginNormal = 0,
        loginDisableAccount = 1,
        loginHideAccount = 2,
    }

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public bool Login(ref string account, ref string pwd, LoginFlags flags)
        {
            ////modify by hyh 为调试方便所用，上线前需删除
            //account = "10910";
            //pwd = "1";
            ////end
            tbAccount.Text = account;
            tbPWD.Text = pwd;
            this.ActiveControl = tbPWD;
            tbPWD.Focus();
            switch (flags)
            {
                case LoginFlags.loginDisableAccount:
                    {
                        tbAccount.Enabled = false;
                    }
                    break;
                case LoginFlags.loginHideAccount:
                    {
                        tbAccount.Visible = false;
                    }
                    break;
            }

            if (ShowDialog() != DialogResult.OK)
                return false;
          
            account = tbAccount.Text;
            pwd = tbPWD.Text;
            return true;
        }



    }
}