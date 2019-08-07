using EDoor.WinFormsUI.Docking;
using HMIBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class ccmReScrapFrm : DockContent, IMESForm
    {
        public ccmReScrapFrm()
        {
            InitializeComponent();
        }
        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion
        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }
        private void ccmReScrapFrm_Load(object sender, EventArgs e)
        {
            string strsql = " select  materialid from cbloom_data   where status<=9 and status >5   ";
            strsql += " and materialid in (select heatid from cccm_base_data where productiondate > sysdate-0.5)";
            var dtheatid = MESTool.GetData(Adapter, strsql);
            if (dtheatid != null && dtheatid.Rows.Count > 0)
            {
                for (int i = 0; i < dtheatid.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dtheatid.Rows[i][0].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            if (comboBox1.Text.Trim() == "")
            {
                return;
            }
            if (MessageBox.Show(comboBox1.Text.Trim()+"炉次确定要做甩废吗", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                string strsql =  "call waster('" + comboBox1.Text.Trim() + "')";
                MESTool.exeSql(Adapter, strsql);
                string note = "ip地址" + GetLocalIP() + ",重新甩废炉号：" + comboBox1.Text.Trim();
                strsql = " insert into TS_sys_log(note) values('"+note+"')";
                MESTool.exeSql(Adapter, strsql);
                MessageBox.Show("操作成功！");
                this.Close();
            }

             
          
        }


        public string GetLocalIP()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
