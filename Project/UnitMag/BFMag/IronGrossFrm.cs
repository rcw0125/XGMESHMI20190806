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
    public partial class IronGrossFrm : Form
    {
        public IronGrossFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session ,AppSvrHMI.L3DataSet dsSend)
        {
            try
            {
                if (dsSend == null || dsSend.Tables[0].Rows.Count != 1)
                    return DialogResult.None;

                dsMain.Tables[0].Rows.Clear();

                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["MaterialID"] = dsSend.Tables[0].Rows[0]["MaterialID"].ToString();
                newrow["BFID"] = dsSend.Tables[0].Rows[0]["BFID"].ToString();
                newrow["TAP_No"] = dsSend.Tables[0].Rows[0]["TAP_No"].ToString();
                newrow["TPC_No"] = dsSend.Tables[0].Rows[0]["TPC_No"].ToString();
                newrow["Weight"] = 0;
                newrow["WeightMode"] = 1;
                dsMain.Tables[0].Rows.Add(newrow);

                Adapter.Session = session;

                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {  
                bsMain.EndEdit();
                dsMain.AcceptChanges();

                float fGross = float.Parse(txtbTare.Text.Trim());
                if (fGross < 0)
                {
                    MessageBox.Show("毛重必须大于0t！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string check = MessageBox.Show("确认毛重吗？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
                if (check != "OK")
                    return;
              
                int iRet = cmdAcceptWeightData.Execute();
                if (iRet != 0 || !(Convert.ToBoolean(cmdAcceptWeightData.Command.Return)))
                {
                    MessageBox.Show("设定毛重失败！");
                    //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdAcceptWeightData.Command.ErrorCode, iRet));
                }
                else
                {
                    string note = "ip地址" + GetLocalIP() + ",手工输入毛重铁次号：" + txtTapNo.Text.Trim() + ",罐号：" + txtTpcNo.Text.Trim();
                    string strsql = " insert into TS_sys_log(note) values('" + note + "')";
                    MESTool.exeSql(Adapter, strsql);
                    MessageBox.Show("设定毛重成功！");
                    this.Close();
                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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