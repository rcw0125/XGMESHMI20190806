using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class top : System.Web.UI.Page
{
    static string jiscousername = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        Ajax.Utility.RegisterTypeForAjax(typeof(top));
        try
        {
            jiscousername = Session["ABBUSERNAME"].ToString();
        }
        catch (Exception mye)
        {
            Response.Write(mye.Message);
            Response.Redirect("WorkLogin.aspx");
        }
    }
    [Ajax.AjaxMethod()]
    public string GetDate()
    {
        Service1 DataOpera = new Service1();
        string strDate = DataOpera.GetSystemTime("", "YYYY-MM-DD");
        return strDate;
    }

    [Ajax.AjaxMethod()]
    public string getServerTime()
    {
        Service1 DataOpera = new Service1();
        string currenttime = DataOpera.GetSystemTime("", "hhmmss");
        return currenttime;
    }


    [Ajax.AjaxMethod()]
    public string getChangeShiftTime()
    {
        Service1 DataOpera = new Service1();
        string sqlstr;
        sqlstr = "select END_TIME from OTHER_CURRENT_TEAM";
        DataSet myds = DataOpera.Query("", sqlstr);
        if (myds.Tables[0].Rows.Count > 0)
        {
            return myds.Tables[0].Rows[0][0].ToString();
        }
        return "";
    }



    [Ajax.AjaxMethod()]
    public string GetUserName()
    {
        return jiscousername;
    }

    [Ajax.AjaxMethod(Ajax.HttpSessionStateRequirement.ReadWrite)]
    public void SetUserNull()
    {
        Session["ABBUSERNAME"] = null;
        Session["ABBPASSWORD"] = null;
        Session["ABBREALNAME"] = null;
        Session["ABBGROUPS"] = null;
    }


    [Ajax.AjaxMethod()]
    public string[] getLogInfo()
    {
        //string cc = System.Web.HttpContext.Current.Session["ABBUSERNAME"].ToString();
        Service1 DataOpera = new Service1();
        DataSet LogShiftds = DataOpera.GetCurrentShiftTeam("");
        if (LogShiftds == null)
            return null;
        string[] LogInfo = new string[3];
        LogInfo[0] = Convert.ToString(LogShiftds.Tables[0].Rows[0][0]);
        LogInfo[1] = Convert.ToString(LogShiftds.Tables[0].Rows[0][1]);
        LogInfo[2] = jiscousername;
        return LogInfo;
    }

    [Ajax.AjaxMethod()]
    public DataSet GetL2CommStatus()
    {
        Service1 DataOpera = new Service1();
        string sqlstr = "select UNIT_ID,ALIVE from COM_L2_ALIVE ";
        DataSet myds = DataOpera.Query("", sqlstr);
        return myds;
    }

    [Ajax.AjaxMethod()]
    public string ManualChangeShift()
    {
        Service1 DataOpera = new Service1();
        string sqlstr = "select PAR_VALUE from OTHER_GLOBAL_PAR where PAR_NAME='ManualChangeStatus'";
        DataSet myds = DataOpera.Query("", sqlstr);
        return myds.Tables[0].Rows[0][0].ToString().Trim();
    }

    //20061106xiao
    [Ajax.AjaxMethod()]
    public DataSet GetCTMCoilTrack_Log()
    {
        Service1 DataOpera = new Service1();
        string strSql = "select * from (Select SUBSTR(ACCOUNT_ID,0,14) as LogDate,EVENT,COIL_ID from CTM_COIL_TRACK_LOG order by ACCOUNT_ID desc) where rownum<4";
        DataSet dsSet = DataOpera.Query("", strSql);
        return dsSet;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
