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
    public partial class LfadditionFrm : DockContent, IMESForm
    {
        public LfadditionFrm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            dateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")+" 23:59:59");

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
            string strsql = "select a.heatid as 炉号,b.code_des as 合金,a.weight as 重量  from     ";
            strsql += " (select heatid,element,sum(weight) as weight from clf_addition_data where 1=1   ";

            strsql += " and to_char(discharge_time ,'yyyy-MM-dd hh:mm:ss') >='" + dateTimePicker1.Text+"'";
            strsql += " and to_char(discharge_time ,'yyyy-MM-dd hh:mm:ss') <='" + dateTimePicker2.Text + "'";
            strsql += " and treatno like '" + comboBox1.Text.Substring(0,1) + "%'";
            strsql += " group by heatid,element) a ,cbase_all_code b  ";
            strsql += " where b.code_group='ALLOY_CODE' and b.code=a.element order by heatid";
            // strsql += " order by a.log_time desc";

            var dt = GetData(Adapter, strsql);
            dataGridView2.DataSource = dt;

            if (dt == null)
            {
                MessageBox.Show("无数据,操作完成！");
            }
         
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

      

        private void button2_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays > 7)
            {
                MessageBox.Show("请查询七天以内的数据，重新选择日期");
                return;
            }
            //select ladleno, weight, heatid, decode(status, 1, '净重', 2, '毛重', '未知') as type,log_time,name from clf_ladle_weight
            //order by log_time desc
            string strsql = "select b.code_des as 合金,a.weight as 重量  from     ";
            strsql += " (select element,sum(weight) as weight from clf_addition_data where 1=1   ";

            strsql += " and to_char(discharge_time ,'yyyy-MM-dd hh:mm:ss') >='" + dateTimePicker1.Text + "'";
            strsql += " and to_char(discharge_time ,'yyyy-MM-dd hh:mm:ss') <='" + dateTimePicker2.Text + "'";
            strsql += " and treatno like '" + comboBox1.Text.Substring(0, 1) + "%'";
            strsql += " group by element) a ,cbase_all_code b  ";
            strsql += " where b.code_group='ALLOY_CODE' and b.code=a.element order by 合金";
            // strsql += " order by a.log_time desc";

            var dt = GetData(Adapter, strsql);

            dataGridView1.DataSource = dt;

            if (dt == null)
            {
                MessageBox.Show("无数据,操作完成！");
            }
        }
    }
}
