using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OracleClient;

/// <summary>
/// DB 的摘要说明
/// </summary>
public class DB
{
	public DB()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static OracleConnection createConn()
    {
        return new OracleConnection(System.Configuration.ConfigurationSettings.AppSettings["oraclestr"]);
    }

    public static String RecordPageUseCount(string strPageName)
    {
        string connstr = ConfigurationManager.AppSettings["oraclestr"];
        OracleConnection conn = new OracleConnection(connstr);
        conn.Open();
        OracleTransaction mytrans = conn.BeginTransaction();

        string strSQL = "Update PAGE_USE_COUNT Set USE_COUNT = USE_COUNT + 1 where PAGE_NAME = '" + strPageName + "'";
        try
        {
            OracleCommand myCommand = new OracleCommand(strSQL);
            myCommand.Connection = conn;
            myCommand.Transaction = mytrans;

            myCommand.ExecuteNonQuery();
            mytrans.Commit();
            conn.Close();
        }
        catch (Exception e)
        {
            mytrans.Rollback();
            conn.Close();
            return e.Message;
        }
        return "0";
    }
}
