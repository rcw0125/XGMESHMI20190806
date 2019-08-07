using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public static class MESTool
    {
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

        /// <summary>
        /// 获取objurl（表/主键）路径下某项的值
        /// </summary>
        /// <param name="objUrl"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static object getValue(AppSvrHMI.L3Adapter adapter, string objUrl, string item)
        {
            try
            {
                object Obj = new object();
                if (adapter.Session == null || !adapter.Session.Opened)
                {
                    MessageBox.Show("adapter连接没有打开，请重新登陆");
                    return null;
                }
                int i = adapter.Session.Get(objUrl, item, ref Obj);
                if (i == 0)
                {
                    return Obj;
                }
                else
                {
                    return "错误" + i;
                }
            }
            catch (Exception ex)
            {
                return "错误" + ex.ToString();
            }
        }
    }
}
