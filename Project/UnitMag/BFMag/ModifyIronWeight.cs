﻿using EDoor.WinFormsUI.Docking;
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
    public partial class ModifyIronWeight : DockContent, IMESForm
    {
        public ModifyIronWeight()
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
            // select materialid,production_date as logtime,gross_weight,curr_tare,net_weight from cbfiron where production_date >sysdate-1.1 order by production_date desc
            string strsql = "select materialid,production_date as logtime,gross_weight,curr_tare,net_weight from cbfiron where production_date >sysdate-1.1 order by production_date desc";
            var dtiron = MESTool.GetData(Adapter, strsql);
            dataGridView1.DataSource = dtiron;
        }

     
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["collogtime"].Value);
            textBox1.Text = dataGridView1.CurrentRow.Cells["coltap"].Value.ToString();
            txtgrossWeight.Text=Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["colgrossWeight"].Value),2).ToString();
            txttareWeight.Text = Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["coltareWeight"].Value), 2).ToString();
            txtnetWeight.Text = Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["colnetWeight"].Value), 2).ToString();
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
            if (MessageBox.Show(textBox1.Text + "铁次确定要修正重量吗", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string lastgross = Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["colgrossWeight"].Value), 2).ToString();
                string lasttare = Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["coltareWeight"].Value), 2).ToString();
                string lastnet = Math.Round(Convert.ToDouble(dataGridView1.CurrentRow.Cells["colnetWeight"].Value), 2).ToString();

                string curgross = Math.Round(Convert.ToDouble(txtgrossWeight.Text), 2).ToString();
                string curtare = Math.Round(Convert.ToDouble(txttareWeight.Text), 2).ToString();
                string curnet = Math.Round(Convert.ToDouble(txtnetWeight.Text), 2).ToString();

                string updatesql = "";
                string logtext = "ip地址" + GetLocalIP()+",铁次号:"+textBox1.Text + ",";
                if (lastgross != curgross)
                {
                    updatesql += "gross_weight="+ Convert.ToDouble(curgross);
                    logtext += "毛重原来是："+lastgross+",改为："+curgross;
                }
                if (lasttare != curtare)
                {
                    if (updatesql == "")
                    {
                        updatesql += "curr_tare="+ Convert.ToDouble(curtare);
                    }
                    else
                    {
                        updatesql += ",curr_tare=" + Convert.ToDouble(curtare);
                    }
                    logtext += "皮重原来是：" + lasttare + ",改为：" + curtare;
                }
                if (lastnet != curnet)
                {
                    if (updatesql == "")
                    {
                        updatesql += "net_weight=" + Convert.ToDouble(curnet);
                    }
                    else
                    {
                        updatesql += ",net_weight=" + Convert.ToDouble(curnet);
                    }
                    logtext += "净重重原来是：" + lastnet + ",改为：" + curnet;
                }
                if (updatesql == "")
                {
                    MessageBox.Show("数据没有变化！");
                    return;
                }
                string strsql = "update cbfiron set "+updatesql+" where materialid = '"+textBox1.Text+"'";
                MESTool.exeSql(Adapter, strsql);
               
                strsql = " insert into TS_sys_log(note) values('" + logtext + "')";
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