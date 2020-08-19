
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class DataWeihu : Form
    {
        public DataWeihu()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session,string heatid)
        {
            Adapter.Session = session;
            textBox1.Text = heatid;        
            this.ShowDialog();
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

        public static DataTable GetData(AppSvrHMI.L3Adapter adapter, string strSql)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //            insert into csteel_data(guid, materialid, status, qastatus, qalevel, preheatid, steelgradeindex, pre_steelgradeindex, heatid, weight)
            //select guid, heatid,1,0,0,preheatid,steelgradeindex,pre_steelgradeindex,heatid,48 from cplan_tapping
            // where heatid = '242001329'
            if (checkHeatid(textBox1.Text.Trim()))
            {
                if (MessageBox.Show(textBox1.Text.Trim() + "炉次确定要手动添加钢水", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int weight = 48;
                    if (textBox1.Text.StartsWith("24"))
                    {
                        weight = 76;
                    }
                    string strsql = " insert into csteel_data(guid, materialid, status, qastatus, qalevel, preheatid, steelgradeindex, pre_steelgradeindex, heatid, weight,ladleid)";
                    strsql += "select guid, heatid,1,0,0,preheatid,steelgradeindex,pre_steelgradeindex,heatid,"+weight+",'G001' from cplan_tapping where heatid = '"+textBox1.Text.Trim()+"'";
                    exeSql(Adapter, strsql);
                    string weizhi = "S3"+textBox1.Text.Trim().Substring(1,1)+"P01";
                    if (textBox1.Text.StartsWith("61"))
                    {
                        weizhi = "S25P01";
                    }
                    string sql = " insert into materialposition(guid, materialtype, materialid, position, amount, idx)";
                    sql += " select guid,'CSteel_Data',heatid,'"+weizhi+"',1,1 from cplan_tapping where heatid = '"+textBox1.Text.Trim()+"'";
                    exeSql(Adapter, sql);

                    if (textBox1.Text.StartsWith("61"))
                    {
                        string strBofDataObj = @"XGMESLogic\DEPMag\CDEP_Unit_Mag\S91";
                        int iSucces = Adapter.Session.Set(strBofDataObj, "Status", "12");
                    }
                    else 
                    {

                        string strBofDataObj = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S2" + textBox1.Text.Trim().Substring(1, 1);
                        int iSucces = Adapter.Session.Set(strBofDataObj, "Status", "5");
                    }
                   

                    MessageBox.Show("添加钢水成功！");
                  


                }
            }

        }
    }
}
