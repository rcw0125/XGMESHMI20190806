
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class DataUpdate :Form
    {
        public DataUpdate()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session,string heatid)
        {
            Adapter.Session = session;
            textBox1.Text = heatid;
            if (!heatid.StartsWith("24"))
            {
                label4.Visible = false;
                comboBox3.Visible = false;
                button5.Visible = false;
            }
            this.ShowDialog();
        }

        /// <summary>
        /// 计划下达
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkHeatid(textBox1.Text.Trim()))
            {
                string strsql = " update CPLAN_TAPPING set status=11 where status='10' and heatid='"+textBox1.Text.Trim()+"'";
                exeSql(Adapter, strsql);
                MessageBox.Show("计划下达操作完成！请核查");
            }
        }

        public bool checkHeatid(string heatid)
        {

            if (heatid.Trim().Length != 9)
            {
                MessageBox.Show("炉号的位数不是9位！");
                return false;
            }
            if (!isNumberic(heatid))
            {
                MessageBox.Show("炉号不是有效的数字！");
                return false;
            }           
            return true;
        }

        protected bool isNumberic(string heatid)
        {            
            Int32 result = -1;  
            try
            {
                result = Convert.ToInt32(heatid);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string exeSql(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            try
            {
                if (adapter.Session == null || !adapter.Session.Opened)
                {
                    MessageBox.Show("adapter连接没有打开，请重新登陆");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkHeatid(textBox1.Text.Trim()))
            {
                string strsql = " update CPLAN_TAPPING set status=10 where status='11' and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("计划取消操作完成！请核查");
            }
        }
        /// <summary>
        /// 更改铸机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // update xgmes.CPLAN_TAPPING set casterid='S64' where caster_status='01' and heatid='211903141'
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择铸机！");
                return;
            }
            if (checkHeatid(textBox1.Text.Trim()))
            {
                string strsql = " update CPLAN_TAPPING set casterid='S6"+ comboBox1.Text.Substring(0,1) + "' where caster_status='01' and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("铸机计划已更改！请核查");
            }
           
        }

        /// <summary>
        /// 更改精炼炉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("请选择精炼炉！");
                return;
            }

            if (comboBox2.Text.Contains("不经过"))
            {
                string strsql = " update CPLAN_TAPPING set lfid=0,refine_type=0 where (status='10' or status='11') and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("LF炉路径已更改！请核查");
            }
            else
            {
                string strsql = " update CPLAN_TAPPING set lfid='S4" + comboBox2.Text.Substring(0, 1) + "',refine_type='L'  where (status='10' or status='11') and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("LF炉路径已更改！请核查");
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                MessageBox.Show("请选择RH炉！");
                return;
            }
            if (comboBox3.Text.Contains("不经过"))
            {
                string strsql = " update CPLAN_TAPPING set rhid=0,refine_type='L' where (status='10' or status='11') and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("RH炉路径已更改！请核查");
            }
            else
            {
                string strsql = " update CPLAN_TAPPING set rhid='S5" + comboBox3.Text.Substring(0, 1) + "',refine_type='LR'  where (status='10' or status='11') and heatid='" + textBox1.Text.Trim() + "'";
                exeSql(Adapter, strsql);
                MessageBox.Show("RH炉路径已更改！请核查");
            }
        }
    }
}
