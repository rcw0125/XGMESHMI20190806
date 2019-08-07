using EDoor.WinFormsUI.Docking;
using HMIBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag
{
    public partial class LfWeightFrm : DockContent, IMESForm
    {
        public LfWeightFrm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            richTextBox1.Text = "请双击炉次所在行，显示铸机备注信息";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays > 7)
            {
                MessageBox.Show("请查询七天以内的数据，重新选择日期");
                return;
            }
            //select ladleno, weight, heatid, decode(status, 1, '净重', 2, '毛重', '未知') as type,log_time,name from clf_ladle_weight

            //order by log_time desc
            string strsql = "select a.ladleno, a.weight, a.heatid as 炉号, decode(a.status, 1, '净重', 2, '皮重', '未知') as 类型,a.log_time,a.name as 分析 ,round(b.remainweight,2) as 剩钢,c.steelgrade as 钢种  ";
            strsql += " from clf_ladle_weight a,cccm_heat_ladle b,cccm_base_data c  where 1=1 and a.heatid=b.heatid(+) and a.heatid=c.heatid(+)";
            strsql += " and to_char(a.log_time,'yyyy-MM-dd') >='"+dateTimePicker1.Text+"'";
            strsql += " and to_char(a.log_time,'yyyy-MM-dd') <='" + dateTimePicker2.Text + "'";
            if (comboBox1.SelectedIndex != 0)
            {
                strsql += " and a.status="+comboBox1.SelectedIndex;
            }
           
            strsql += " order by a.log_time desc";

            var dt = GetData(Adapter, strsql);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["炉号"].ToString() != "")
                    {
                        dt.Rows[i]["分析"] = fenxi(dt.Rows[i]["ladleno"].ToString(), dt.Rows[i]["log_time"].ToString(), dt.Rows[i]["weight"].ToString());
                    }
                }

                dataGridView1.DataSource = dt;
                //DateTime pz = Convert.ToDateTime(dt.Rows[0]["log_time"]);
                //string strsql = "select count(*) from clf_ladle_weight  where ladleno='" + label17.Text.Trim() + "'and status='1' and log_time> ";
                //strsql += " TO_DATE('" + dt.Rows[0]["log_time"].ToString() + "','yyyy-MM-dd HH24:MI:SS')";
                //var dtpd = UnitMag.MESTool.GetData(Adapter, strsql);
                //if (dtpd != null && dtpd.Rows.Count > 0)
                //{
                //    if (dtpd.Rows[0][0].ToString() != "1")
                //    {

                //        MessageBox.Show("上件岗位称皮重操作不规范，或没有称皮重！次数=" + dtpd.Rows[0][0].ToString());
                //    }
                //}
            }
        }

        public string fenxi(string ladleno, string cztime,string weight)
        {
            if (!ladleno.StartsWith("G"))
            {
                return "无钢包号";
            }

            string sql = "select ladleno,weight,log_time from ";
            sql += " (select * from clf_ladle_weight  where ladleno='" + ladleno + "' and status='2'   ";
            sql += " and log_time<= TO_DATE('" + cztime + "','yyyy-MM-dd HH24:MI:SS') order by log_time desc)";
            sql += " where rownum<2  ";
            var dt = GetData(Adapter, sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string maoweight = "毛重:" + (Convert.ToDouble(dt.Rows[0]["weight"].ToString()) + Convert.ToDouble(weight));
               // dataGridView1.DataSource = dt;
                DateTime pz = Convert.ToDateTime(dt.Rows[0]["log_time"]);
                string strsql = "select count(*) from clf_ladle_weight  where ladleno='" + ladleno + "'and status='1' and log_time> ";
                strsql += " TO_DATE('" + dt.Rows[0]["log_time"].ToString() + "','yyyy-MM-dd HH24:MI:SS')";
                strsql += " and log_time<= TO_DATE('" + cztime + "','yyyy-MM-dd HH24:MI:SS')";
                var dtpd = GetData(Adapter, strsql);
                if (dtpd != null && dtpd.Rows.Count > 0)
                {
                    if (dtpd.Rows[0][0].ToString() != "1")
                    {

                       // MessageBox.Show("最新皮重时间="+ dt.Rows[0]["log_time"].ToString() + "！使用次数=" + dtpd.Rows[0][0].ToString());
                        return maoweight+",皮重:"+dt.Rows[0]["weight"].ToString()+",最新皮重时间=" + dt.Rows[0]["log_time"].ToString() + "！使用次数=" + dtpd.Rows[0][0].ToString();
                    }
                }
                return maoweight + ",皮重:" + dt.Rows[0]["weight"].ToString() + ",皮重正常";
            }
            return "没有皮重";


        }

        public  DataTable GetData(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            if (adapter.Session == null || !adapter.Session.Opened)
            {
                MessageBox.Show("adapter连接没有打开，请重新登陆");
                return null;
            }

            adapter.RefreshDataBindings();
            AppSvrIF.Command cmdSQl = new AppSvrIF.Command();
            int iRet = adapter.Session.CreateCommand((int)AppSvrIF.CommandType.QueryBySQL, strSql, "", ref cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show("创建查询命令失败，请重新登陆");
                return null;
            }
            iRet = adapter.Session.Execute(cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show("服务执行出现错误，请重新登陆");
                return null;
            }
            if (!(cmdSQl.Return is AppSvrIF.Recordset))
            {
                MessageBox.Show("返回结果错误，请重新登陆");
                return null;
            }
            AppSvrIF.Recordset rs = cmdSQl.Return as AppSvrIF.Recordset;
            if (rs.Tables[0].Rows.Count < 1)
            {
                return null;
            }
            else
            {
                return rs.Tables[0];
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                string strHeat = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
                if (strHeat != null || strHeat != "")
                {
                    string strsql = "select wm_concat(remark) as rm from cccm_heat_remark  where heatid='" + strHeat + "'";
                    var dt = GetData(Adapter, strsql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        richTextBox1.Text = dt.Rows[0]["rm"].ToString();
                    }
                }
            }
            catch
            {

            }
           
        }
    }
}
