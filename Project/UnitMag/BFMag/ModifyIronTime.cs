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

namespace UnitMag.BFMag
{
    public partial class ModifyIronTime : DockContent, IMESForm
    {
        public ModifyIronTime()
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

        public void loadData()
        {
            string strsql = "select distinct tap_no,production_date as logtime from cbfiron where production_date >sysdate-1.1 order by production_date desc";
            var dtiron = MESTool.GetData(Adapter, strsql);
            dataGridView1.DataSource = dtiron;
        }

     
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["collogtime"].Value);
            textBox1.Text = dataGridView1.CurrentRow.Cells["coltap"].Value.ToString();
        }

        private void ModifyIronTime_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update cbfiron set production_date = TO_DATE('2020-06-23 15:33:32', 'yyyy-MM-dd HH24:MI:SS') where tap_no = '160050461'
            if (MessageBox.Show(textBox1.Text + "铁次确定要修正出铁时间吗", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string strsql = "update cbfiron set production_date = TO_DATE('"+dateTimePicker2.Text+"', 'yyyy-MM-dd HH24:MI:SS') where tap_no = '"+textBox1.Text+"'";
                MESTool.exeSql(Adapter, strsql);
                string note = "ip地址" + GetLocalIP() + ",铁次号：" + textBox1.Text+",原来时间："+ Convert.ToDateTime(dataGridView1.CurrentRow.Cells["collogtime"].Value).ToString("yyyy-MM-dd HH:mm:ss")+"更改为："+ dateTimePicker2.Text;
                strsql = " insert into TS_sys_log(note) values('" + note + "')";
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
    }
}