using EDoor.WinFormsUI.Docking;
using HMIBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class LadleZb : DockContent, IMESForm
    {
        public LadleZb()
        {
            InitializeComponent();
           
        }

        private void LadleZb_Load(object sender, EventArgs e)
        {
            string strsql = " select heatid from cccm_base_data where productiondate > sysdate-0.3 order by heatid  ";
            var dtheatid = GetData(Adapter, strsql);
            if (dtheatid != null && dtheatid.Rows.Count > 0)
            {
                for (int i = 0; i < dtheatid.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dtheatid.Rows[i][0].ToString());
                }
            }

            strsql = " select ladleid from cladle_base  where status='07' or status='09' order by ladleid   ";
            var dtladle = GetData(Adapter, strsql);
            if (dtladle != null && dtladle.Rows.Count > 0)
            {
                for (int i = 0; i < dtladle.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dtladle.Rows[i][0].ToString());
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("请选择炉号和钢包号");
                return;
            }
            string strsql = " update cccm_base_data set cut_operator='"+comboBox2.Text.Trim()+"' where heatid='"+comboBox1.Text.Trim()+"'";
            exeSql(Adapter, strsql);
            MessageBox.Show("操作成功！");
        }

        /// <summary>
        /// 查询折包记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string strsql = " select heatid as 炉号,ladleno as 钢包,cut_operator as 折包,productiondate as 生产日期 from cccm_base_data ";
            strsql += " where cut_operator is not null  order by productiondate desc";
            var dt = GetData(Adapter, strsql);
            dataGridView1.DataSource = dt;

        }

        public DataTable GetData(AppSvrHMI.L3Adapter adapter, string strSql)
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



    }
}
