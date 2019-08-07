using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace XGMESMain
{
    public partial class frmConfigConnection : Form
    {
        public frmConfigConnection()
        {
            InitializeComponent();
        }
        
        public static ConnectionStringSettings[] GetConnections()
         
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection connSec = cfg.ConnectionStrings;
            if (connSec == null)
                return null;

            ConnectionStringSettings[] conns = new ConnectionStringSettings[connSec.ConnectionStrings.Count];
            for (int i = 0; i < connSec.ConnectionStrings.Count; i++)
            {
                conns[i] = connSec.ConnectionStrings[i];
            }

            return conns;
        }

        public static ConnectionStringSettings GetCurrentConnection()
        {
            try
            {
                string name = ConfigurationManager.AppSettings["CurMESServer"];
                ConnectionStringSettings[] conns = GetConnections();
                if (conns == null)
                    return null;
                foreach (ConnectionStringSettings conn in conns)
                {
                    if (conn.Name == name)
                        return conn;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public static bool SelectCurrentConnection(string name)
        {
            ConnectionStringSettings[] conns = GetConnections();
            if (conns == null)
                return false;
            foreach (ConnectionStringSettings conn in conns)
            {
                if (conn.Name == name)
                {   // Found
                    ConfigurationManager.AppSettings["CurMESServer"] = name;
                    return true;
                }
            }
            return false;
        }

        public static bool SaveConnection(string name, string connstr, bool bAsCurrent)
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection connSec = cfg.ConnectionStrings;
            if (connSec == null)
                return false;

            bool bRet = true;
            try
            {
                connSec.ConnectionStrings.Remove(name);
                connSec.ConnectionStrings.Add(new ConnectionStringSettings(name, connstr, "MES"));
                cfg.Save();
            }
            catch
            {
                bRet = false;
            }
            if (!bRet)
                return false;

            if (bAsCurrent)
                bRet = SelectCurrentConnection(name);

            return bRet;
        }

        private void frmConfigConnection_Load(object sender, EventArgs e)
        {
            // Read all available connections
            ConnectionStringSettings[] conns = GetConnections();
            for (int i = 0; conns != null && i < conns.Length; i++)
            {
                ConnectionStringSettings conn = conns[i];
                if (conn.ProviderName == "MES")
                {
                    cmbNames.Items.Add(conn.Name);
                }
            }

            // Get current connection
            ConnectionStringSettings cur = GetCurrentConnection();
            if (cur != null)
            {
                cmbNames.SelectedIndex = cmbNames.FindStringExact(cur.Name);
                cmbNames_SelectionChangeCommitted(cmbNames, new EventArgs());
            }
        }

        private void tbPort_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int iPort = int.Parse(tbPort.Text, System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite);
            }
            catch
            {
                ERR.SetError(tbPort, "请输入正确的端口号！必须为数字");
                e.Cancel = true;
                return;
            }
            e.Cancel = false;
        }

        private void tbPort_Validated(object sender, EventArgs e)
        {
            ERR.SetError(tbPort, "");
        }

        private void cmbNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = cmbNames.SelectedIndex < 0 ? "" : cmbNames.Items[cmbNames.SelectedIndex].ToString();
            string connstr = "";
            // Try to find the connection by using this name
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection sec = cfg.ConnectionStrings;
            if (sec != null)
            {
                try
                {
                    connstr = sec.ConnectionStrings[name].ConnectionString;
                }
                catch
                {
                    string msg = string.Format("服务连接\"{0}\"未找到！", name);
                    MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbNames.Items.RemoveAt(cmbNames.SelectedIndex);
                    return;
                }
            }

            Regex regex = new Regex(@"(?<address>(\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b)|([\w.]+)):(?<port>\d+)");
            Match match = regex.Match(connstr);
            if (match == null || match.Length < 1)
            {
                string msg = string.Format("配置中的连接字符串有错误!\r\n{0}", connstr);
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbAddress.Text = match.Groups["address"].Value;
            tbPort.Text = match.Groups["port"].Value;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cmbNames.SelectedItem == null)
                return;
            string name = cmbNames.SelectedItem.ToString();

            if (MessageBox.Show("确实要删除此连接配置吗？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection sec = cfg.ConnectionStrings;
                if (sec != null)
                {
                    sec.ConnectionStrings.Remove(name);
                    cmbNames.Items.Remove(cmbNames.SelectedItem);
                    cfg.Save();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //frmLogin login = new frmLogin();
            string account = "Administrator";
            string pwd = "";
            //if (!login.Login(ref account, ref pwd, LoginFlags.loginNormal))
            //    return;

            string connstr = string.Format("{0}:{1}", tbAddress.Text, tbPort.Text);
            connstr = connstr.Replace("1089", "2525");
            int iRet = L3Session.Open(connstr, account, pwd);
            if (iRet == 0)
            {
                MessageBox.Show("连接测试成功!");
                L3Session.Close();
            }
            else
            {
                string msg = string.Format("连接测试失败！错误码：0x{0:X}", iRet);
                if (msg.Contains("A0001400"))
                {
                    msg = "服务器无效或已死机！";
                }
                else if (msg.Contains("A0000402"))
                {
                    msg = "密码错误！";
                }
                else if (msg.Contains("A0000400"))
                {
                    msg = "用户名不存在！";
                }
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string connstr = string.Format("{0}:{1}", tbAddress.Text, tbPort.Text);
            SaveConnection(cmbNames.Text, connstr, true);
        }

        private void cmbNames_Validating(object sender, CancelEventArgs e)
        {
            if (cmbNames.Text.Trim() == "")
            {
                ERR.SetError(cmbNames, "请输入连接名称");
                e.Cancel = true;
            }
        }

        private void cmbNames_Validated(object sender, EventArgs e)
        {
            ERR.SetError(cmbNames, "");
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddress.Text.Trim() == "")
            {
                ERR.SetError(tbAddress, "请输入地址！");
                e.Cancel = true;
            }
        }

        private void tbAddress_Validated(object sender, EventArgs e)
        {
            ERR.SetError(tbAddress, "");
        }
    }
}