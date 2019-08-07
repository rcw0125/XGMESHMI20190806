using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

//using EDoor.WinFormsUI.Docking;
//using System.Threading;
//using HMIBase;
namespace XGMESMain
{
    public partial class frmMain : Form
    {

        public void CheckUpdate()
        {
            string exeFile = System.AppDomain.CurrentDomain.BaseDirectory + "/AppUpdate.exe";
            if (File.Exists(exeFile))
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = exeFile;
                info.Arguments = "Rcw";
                info.WindowStyle = ProcessWindowStyle.Normal;
                Process pro = Process.Start(info);
                if (pro.Start())
                {
                    pro.Close();

                }
            }

        }
        public frmMain()
        {
            InitializeComponent();
            CheckUpdate();
            toolStripStatusLabel3.Text = "程序版本："+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #region   ComputerTime
        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTime
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMiliseconds;
        }
        public class Win32
        {
            [DllImport("Kernel32.dll ")]
            public static extern bool SetSystemTime(ref   SystemTime SysTime);
            [DllImport("Kernel32.dll ")]
            public static extern void GetSystemTime(ref   SystemTime SysTime);
        }


        #endregion

        #region   时间同步
        ///   <summary> 
        ///   设置与服务器同步时间   
        ///   </summary> 
        public void SynchronousTime(string strdt)
        {
            try
            {
                #region   更改计算机时间

                SystemTime sysTime = new SystemTime();

                DateTime ServerTime = Convert.ToDateTime(strdt);

                sysTime.wYear = Convert.ToUInt16(ServerTime.Year);

                sysTime.wMonth = Convert.ToUInt16(ServerTime.Month);

                //处置北京时间   

                int nBeijingHour = ServerTime.Hour - 8;

                if (nBeijingHour <= 0)
                {
                    nBeijingHour += 24;

                    sysTime.wDay = Convert.ToUInt16(ServerTime.Day - 1);

                    sysTime.wDayOfWeek = Convert.ToUInt16(ServerTime.DayOfWeek - 1);
                }
                else
                {
                    sysTime.wDay = Convert.ToUInt16(ServerTime.Day);

                    sysTime.wDayOfWeek = Convert.ToUInt16(ServerTime.DayOfWeek);
                }

                sysTime.wHour = Convert.ToUInt16(nBeijingHour);

                sysTime.wMinute = Convert.ToUInt16(ServerTime.Minute);

                sysTime.wSecond = Convert.ToUInt16(ServerTime.Second);

                sysTime.wMiliseconds = Convert.ToUInt16(ServerTime.Millisecond);

                Win32.SetSystemTime(ref   sysTime);

                #endregion
            }
            catch
            {
                //产生错误则不引发异常。 
            }
        }
        #endregion

        private void OnLogin(object sender, EventArgs e)
        {
            ConnectionStringSettings conn = frmConfigConnection.GetCurrentConnection();
            if (conn == null)
            {
                MessageBox.Show("没有配置服务！请先配置服务的连接。");
                return;
            }
            string connstr = conn.ConnectionString;          
            connstr = connstr.Replace("1089", "2525");
            frmLogin login = new frmLogin();
            string account = ConfigurationManager.AppSettings["LastAccount"];
            string pwd = "";
            if (!login.Login(ref account, ref pwd, LoginFlags.loginNormal))
                return;

            int iRet = L3Session.Open(connstr, account, pwd);
            //int iRet = L3Session.Open(connstr, "10910", "xgmes");
            if (iRet != 0)
            {
                string msg = string.Format("连接服务{0}失败！错误代码：{1:X}", conn.Name, iRet);
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
                MessageBox.Show(msg, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //
                timer3.Enabled = true;
                timer2.Enabled = true;

                labelUser.Text = account;
               // ConfigurationManager.AppSettings["LastAccount"] = account;
                //获取Configuration对象
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["LastAccount"].Value = account;
                config.Save(ConfigurationSaveMode.Modified);

                
                menuLogout.Enabled = true;
                menuChangePassWord.Enabled = true;
                menuLogin.Enabled = false;

                //校对时间
                if (cmdGetServerTime.Execute() >= 0)
                {
                    string strdt = Convert.ToString(cmdGetServerTime.Command.Return);
                    if (strdt != "")
                        SynchronousTime(strdt);
                }
                //L3DataAdapter.ReCheckAccessRights();         
                //var ubof=L3Session.GetResourceRights("menuBOF");
                //if (ubof == 3)
                //{
                //    UnitMag.PublicResource.bofMenu = true;
                //}

                //var ulf = L3Session.GetResourceRights("menuLF");
                //if (ulf == 3)
                //{
                //    UnitMag.PublicResource.lfMenu = true;
                //}
                //var urh = L3Session.GetResourceRights("menuRH");
                //if (urh == 3)
                //{
                //    UnitMag.PublicResource.rhMenu = true;
                //}
                //var uccm = L3Session.GetResourceRights("menuCCM");
                //if (uccm == 3)
                //{
                //    UnitMag.PublicResource.ccmMenu = true;
                //}
                //var S = L3Session.GetResourceRights("menuBO");

                l3dbxWarning.L3DataAdapter = L3DataAdapter;
                
                l3dbxWarning.LoadData();

                dsTeamID.L3DataAdapter = this.L3DataAdapter;
                dsShiftID.L3DataAdapter = this.L3DataAdapter;
                l3DataBoxTeamID.L3DataAdapter = null;
                l3DataBoxShiftID.L3DataAdapter = null;

                l3DataBoxTeamID.L3DataAdapter = this.L3DataAdapter;
                l3DataBoxShiftID.L3DataAdapter = this.L3DataAdapter;

                //登录时，记录账号、IP等信息
                string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string strsql = "insert into TS_USER_LOGIN(userid,ip,pcname,flag,version) values ('";
                strsql += account + "','" + GetLocalIP() + "','" + GetComputerName() + "','" + existms() + "','" + version + "')";
                exeSql(L3DataAdapter, strsql);


                //add by hyh 2012-03-30  根据邢钢要求，定时修改密码，否则不应许登陆
                //try
                //{
                //    if (account.Equals("Administrator"))
                //        return;
                //    string strDateSpan = ConfigurationManager.AppSettings["PwdLockCycle"];
                //    string strCurTime = Convert.ToString(cmdGetServerTime.Command.Return);
                //    //获取上次修改密码时间
                //    cmdGetUserLastUpdPwdTime.Parameters[0].ConstantValue = account;
                //    if (pwd == "")
                //        pwd = "null";
                //    cmdGetUserLastUpdPwdTime.Parameters[1].ConstantValue = pwd;
                //    int iret = cmdGetUserLastUpdPwdTime.Execute();
                //    string strLastTime = Convert.ToString(cmdGetUserLastUpdPwdTime.Command.Return);
                //    DateTime dtCur = Convert.ToDateTime(strCurTime);
                //    DateTime dtLastTime = Convert.ToDateTime(strLastTime);
                //    TimeSpan ts = dtCur.Subtract(dtLastTime);
                //    double day = ts.TotalDays;
                //    int ttt = Convert.ToInt32(day);
                //    if (ts.TotalDays > Convert.ToDouble(strDateSpan))
                //    {
                //        MessageBox.Show("密码已过期，请联系管理员，并定期在" + strDateSpan + "天内修改密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        L3Session.Close();
                //    }
                //    else if (ttt > 54)
                //    {
                //        MessageBox.Show("距密码过期还有" + Convert.ToInt32(60 - Convert.ToInt32(day)) + "天，请及时修改密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
                //catch { return; }
                //end
            }
           
        }

        private string existms()
        {
            if (File.Exists(@"C:\Windows\ms\MyService.exe"))
            {
                return "是";
            }
            else
            {
                return "否";
            }
        }

        /// <summary>
        /// 使用session执行sql命令（update，insert）
        /// 返回0则成功，其他为错误代码
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string exeSql(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            try
            {
                if (adapter.Session == null || !adapter.Session.Opened)
                {
                    //MessageBox.Show("adapter连接没有打开，请重新登陆");
                    return null;
                }
                AppSvrIF.Command cmd = null;
                //创建sql命令
                int result = adapter.Session.CreateCommand(14, strSql, "", ref cmd);
                if (result == 0)
                {
                    //使用session执行sql命令
                    return adapter.Session.Execute(cmd).ToString();

                }
                else
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        public string GetComputerName()
        {
            try
            {
                return System.Environment.GetEnvironmentVariable("ComputerName");
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }
        }
        public  string GetLocalIP()
        {
            try
            {
                string ip = "";
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (IpEntry.AddressList[i].ToString().StartsWith("192.168.36") || IpEntry.AddressList[i].ToString().StartsWith("192.168.48") || (IpEntry.AddressList[i].ToString().StartsWith("192.168.2")))
                        {
                            return IpEntry.AddressList[i].ToString();
                        }
                        ip = IpEntry.AddressList[i].ToString();


                    }
                }
                return ip;
            }
            catch
            {
                return "";
            }

        }


        private void OnLogout(object sender, EventArgs e)
        {
            L3Session.Close();

            labelUser.Text = "未登录";
            menuLogin.Enabled = true;
            menuChangePassWord.Enabled = false;
            menuLogout.Enabled = false;

            l3DataBoxTeamID.Text = "";
            l3DataBoxShiftID.Text = "";

            L3DataAdapter.ReCheckAccessRights();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnManageService(object sender, EventArgs e)
        {
            frmConfigConnection dlg = new frmConfigConnection();
            dlg.ShowDialog();
        }

        private void OnOpenHelpCatelog(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, helpMain.HelpNamespace);
            }
            catch
            {
            }
        }

        private void OnOpenHelpIndex(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelpIndex(this, helpMain.HelpNamespace);
            }
            catch
            {
            }
        }

        private void OnOpenAboutDialog(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowAboutInfo();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (L3Session.Opened)
            //{
            //    //登录时，记录账号、IP等信息
            //    string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //    string strsql = "insert into TS_USER_LOGIN(userid,ip,pcname,flag,version) values ('";
            //    strsql += labelUser.Text + "','" + GetLocalIP() + "','" + GetComputerName() + "','退出','" + version + "')";
            //    exeSql(L3DataAdapter, strsql);
            //}
            L3Session.Close();
            L3Session.Dispose();
            CommDataMag.CommonMethed.FlushMemory();
        }

        //
        private int iTimeTick = 0;
        private void timerTick_Tick(object sender, EventArgs e)
        {
            if (iTimeTick > 10)
            {
                iTimeTick = 0;
                SubscibeShifTeam();
            }
            iTimeTick += 1;
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("yyyy-MM-dd HH:mm");
            OnLogin(null, null);
        }
        //预约班别班次
        private void SubscibeShifTeam()
        {
            if (!L3Session.Opened)
                return;

            AppSvrIF.Command cmdNull = new AppSvrIF.Command();
            cmdNull.Type = (int)AppSvrIF.CommandType.Empty;
            L3Session.Execute(cmdNull);
        }
        //班别
        private void l3DataBoxTeamID_TextChanged(object sender, EventArgs e)
        {
            lbTeamID.Text = "班别:";
            if (l3DataBoxTeamID.Text != "")
            {
                lbTeamID.Text += CommDataMag.CommonMethed.GetStrDescByCode(dsTeamID, l3DataBoxTeamID.Text.Trim());
            }
            else
            {
                lbTeamID.Text = "班别:";
            }
        }
        //班次
        private void l3DataBoxShiftID_TextChanged(object sender, EventArgs e)
        {
            lbShiftID.Text = "班次:";
            if (l3DataBoxShiftID.Text != "")
            {
                lbShiftID.Text += CommDataMag.CommonMethed.GetStrDescByCode(dsShiftID, l3DataBoxShiftID.Text.Trim());
            }
            else
            {
                lbShiftID.Text = "班次:";
            }
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //修改密码
        private void menuChangePassWord_Click(object sender, EventArgs e)
        {
            PassWordMagFrm passwordmagFrm = new PassWordMagFrm();
            passwordmagFrm.ShowDialogEx(L3DataAdapter.Session);
        }

        /************************自动换班**************************/
        private void ChangeShiftWarningRun()
        {
            //System.Threading.Thread ChangeSHiftThread = new System.Threading.Thread(new
            //    System.Threading.ThreadStart(ChangeShiftWarning));
            //ChangeSHiftThread.Start();
        }

        public int frmWidth = 0;
        public int frmHeight = 0;
        private void ChangeShiftWarning()
        {
            //MuniLeve = 1 * 10 * 2;
            //CheckForIllegalCrossThreadCalls = false;
            //if ((frm != null) && (!frm.IsDisposed))
            //    frm.Dispose();
            //frm = new XGMESMain.frmTipTeamIDChanged(this);
            //frm.ShowInTaskbar = false;
            //frmWidth = frm.Width;
            //frmHeight = frm.Height;
            //frm.Width = 0;
            //frm.Height = 0;
            //frm.Show();
            //frm.Top = this.Bottom - frmHeight;
            //frm.Left = this.Right - frmWidth;
            //frm.Visible = false;
            //frm.ShowDialog();
        }

        //private XGMESMain.frmTipTeamIDChanged frm;
        //int count = 0;
        int MuniLeve = 15 * 60 * 2;   //time 500  15分钟注销
        //int refresh = 0;
        public void wartimer2_Tick(object sender, EventArgs e)
        {
            //if (!frm.IsDisposed)
            //{
            //    frm.Width = frmWidth;
            //    frm.Height = frmHeight;
            //    frm.timerScan.Enabled = false;
            //    MuniLeve--;

            //    if (MuniLeve <= 0)  //等待15分钟　关闭提示
            //    {
            //        frm.timerScan.Enabled = false;
            //        frm.Dispose();
            //        return;
            //    }

            //    frm.labTime.Text = (Convert.ToInt32(MuniLeve / 2 / 60)).ToString();
            //    if (frm.labTime.Text == "0") frm.labTime.Text = "1";

            //    if (count <= 20)
            //    {
            //        frm.Opacity = 0.05 * count;
            //    }
            //    if (count > 20)
            //    {
            //        frm.Opacity = 2 - 0.05 * count;
            //    }
            //    count++;
            //    if (count == 41)
            //        count = 0;
            //    frm.Top = this.Bottom - frm.Height;
            //    frm.Left = this.Right - frm.Width;
            //    frm.Update();
            //    frm.timerScan.Enabled = true;

            //    refresh++;
            //    if (refresh > 4)
            //        refresh = 0;
            //}

        }


        private void L3DataAdapter_OnObjectPropChanged(string strObj, string strProp, object newVal, object oldVal)
        {
            //if (AppSvrIF.NameParser.CompareName(strObj, "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101")
            //    && (strProp == "TeamID"))
            //{
            //    if (timer1.Enabled)
            //    {
            //        timer1.Enabled = false;
            //    }

            //    if (lbChangShift.Text != "")       //关闭换班提示
            //        lbChangShift.Text = "";
            //    OnLogout(null,null); //注销    
            //    OnLogin(null, null);//登陆

            //}
            //if (AppSvrIF.NameParser.CompareName(strObj, "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101")
            //    && (strProp == "ShiftWarning"))
            //{
            //    timer1.Interval = 2000;
            //    timer1.Enabled = true;
            //}
        }

        //提示换班
        int iWarningChenged = 0;
        private void l3dbxWarning_TextChanged(object sender, EventArgs e)
        {
            iWarningChenged++;
            if (iWarningChenged > 1)
                timerScan.Enabled = true;
            //ChangeShiftWarningRun();
        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            if (!lbChangShift.Visible)
            {
                lbChangShift.Visible = true;
            }
            timerScan.Enabled = false;
            MuniLeve--;

            if (MuniLeve <= 0)  //等待15分钟　关闭提示
            {
                timerScan.Enabled = false;
                lbChangShift.Text = "";
                MuniLeve = 15 * 60 * 2;
                lbChangShift.Visible = false;
                return;
            }
            int iRemain = Convert.ToInt32(MuniLeve / 2 / 60);

            if (iRemain == 0)
            {
                lbChangShift.Text = "1分钟后MES客户端即将换班！";
            }
            lbChangShift.Text = iRemain + "分钟后MES客户端即将换班！";
            if (iRemain > 1)
            {
                this.lbChangShift.BackColor = Color.Yellow;
                this.lbChangShift.ForeColor = Color.Red;
            }
            else
            {
                this.lbChangShift.BackColor = Color.Red;
                this.lbChangShift.ForeColor = Color.Yellow;
            }
            timerScan.Enabled = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            var idoc = panelMain.ActiveDocument;
            int a = 1;
        }

        int count = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (L3Session.Opened)
                {
                    count = count + 2;
                    //登录时，记录账号、IP等信息
                    string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    string strsql = "insert into TS_USER_LOGIN(userid,ip,pcname,flag,version) values ('";
                    strsql += labelUser.Text + "','" + GetLocalIP() + "','" + GetComputerName() + "','"+count.ToString()+"','" + version + "')";
                    exeSql(L3DataAdapter, strsql);
                }
            }
            catch
            {

            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (L3Session.Opened)
                {
                    if (existms() == "否")
                    {
                        timer3.Enabled = false;
                        L3Session.Close();
                        labelUser.Text = "未登录";
                        menuLogin.Enabled = true;
                        menuChangePassWord.Enabled = false;
                        menuLogout.Enabled = false;
                        l3DataBoxTeamID.Text = "";
                        l3DataBoxShiftID.Text = "";
                        L3DataAdapter.ReCheckAccessRights();
                    }                                   
                }
                
            }
            catch
            {

            }
        }

        private void 设备点检月报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SbMag.sbyb yb = new SbMag.sbyb();
            yb.ShowDialog();
        }
    }
}