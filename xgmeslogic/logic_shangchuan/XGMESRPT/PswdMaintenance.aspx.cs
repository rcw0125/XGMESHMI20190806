using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OracleClient;

public partial class PswdMaintenance : System.Web.UI.Page
{
    Service1 DataOpera = new Service1();
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(PswdMaintenance));
    }
    //取得该用户密码；
    [Ajax.AjaxMethod()]
    public string GetOldPswd(string UserName, string OldPswd)
    {
        string md5pass = FormsAuthentication.HashPasswordForStoringInConfigFile(OldPswd, "MD5");
        string strSql = "Select PASSWORDS  from USER_ACCOUNT where USERNAME = '" + UserName + "'";
        DataSet ds = DataOpera.Query("", strSql);
        string pswd = ds.Tables[0].Rows[0][0].ToString();
        if (md5pass.Trim()==pswd.Trim())
            return "Same";
        else
            return "Not";
    }
    //修改密码
    [Ajax.AjaxMethod()]
    public string ModifyPswd(string UserName, string NewPswd)
    {
        string md5pass = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPswd.Trim(), "MD5");
        string pswd = md5pass.Trim();
        string strSql2 = "Update USER_ACCOUNT set PASSWORDS='"+ pswd +"' where USERNAME = '" + UserName + "'";
        string Result = DataOpera.Update("", strSql2);
        if (Result != "0")
            return "新增失败";
        else
        {
            return "修改成功！";
        }
    }
    //取得用户名字
    [Ajax.AjaxMethod()]
    public string GetUserName(string UserCode)
    {
        if (UserCode != "")
        {
            string strName = "";
            string strSql = "select USERREALNAME from USER_ACCOUNT where USERNAME = '" + UserCode + "'";
            DataSet ds = DataOpera.Query("", strSql);
            int count = ds.Tables[0].Rows.Count;
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                strName = ds.Tables[0].Rows[0][0].ToString();
            }
            return strName;
        }
        else
            return "用户名有误！";
    }
}
