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
using System.Web.Security;

public partial class UserGroup : System.Web.UI.Page
{
    Service1 DataOpera = new Service1();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        Ajax.Utility.RegisterTypeForAjax(typeof(UserGroup));
    }

    ///////////////
    [Ajax.AjaxMethod()]
    public DataSet GetAllUser()
    {
        string sqlstr = "select USERNAME,USERREALNAME from USER_ACCOUNT   order by USERNAME";
        return DataOpera.Query("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public DataSet GetOtherGroup(string username)
    {
        string sqlstr = "select GROUPNAME from USER_GROUP where GROUPID not in (select GroupID from USER_ACCOUNT a,ACCOUNT_GROUP_MAP b where a.USERID=b.USERID	and a.USERNAME='" + username + "')";
        return DataOpera.Query("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public DataSet GetUserGroupMap(string username)
    {
        string sqlstr = "select b.GROUPNAME from USER_ACCOUNT a,USER_GROUP b,ACCOUNT_GROUP_MAP c where a.USERID=c.USERID and b.GROUPID=c.GROUPID and a.USERNAME='" + username + "'";
        return DataOpera.Query("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public string RemoveGroup(string groupname, string username)
    {
        string sqlstr;
        string userid = (DataOpera.Query("", "select USERID from USER_ACCOUNT where USERNAME='" + username + "'")).Tables[0].Rows[0][0].ToString();
        string groupid = (DataOpera.Query("", "select GROUPID from USER_GROUP where GROUPNAME='" + groupname + "'")).Tables[0].Rows[0][0].ToString();
        sqlstr = "delete ACCOUNT_GROUP_MAP where GROUPID='" + groupid + "' and USERID='" + userid + "'";
        return DataOpera.Delete("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public string AddGroup(string groupname, string username)
    {
        string sqlstr;
        string userid = (DataOpera.Query("", "select USERID from USER_ACCOUNT where USERNAME='" + username + "'")).Tables[0].Rows[0][0].ToString();
        string groupid = (DataOpera.Query("", "select GROUPID from USER_GROUP where GROUPNAME='" + groupname + "'")).Tables[0].Rows[0][0].ToString();
        sqlstr = "insert into ACCOUNT_GROUP_MAP values(" + userid + "," + groupid + ")";
        return DataOpera.Update("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public string newUser(bool check, string pwd, string usn, string usrname, string userprof)
    {

        int checkid = 0;
        if (check) checkid = 1;
        string sqlstr;
        sqlstr = "select * from USER_ACCOUNT where USERNAME='" + usn + "'";
        DataSet myds = DataOpera.Query("", sqlstr);
        if (myds.Tables[0].Rows.Count > 0)
            return "The User name exist already!";

        sqlstr = "select max(USERID)+1 from USER_ACCOUNT";
        string maxuserid = DataOpera.Query("", sqlstr).Tables[0].Rows[0][0].ToString();
        string md5pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
        sqlstr = "insert into USER_ACCOUNT(USERID,ACCOUNTLOCK,PASSWORDS,USERNAME,USERREALNAME,USER_PROF) values(" + maxuserid + "," + checkid + ",'" + md5pwd + "','" + usn + "','" + usrname + "','" + userprof + "')";
        return DataOpera.Update("", sqlstr);
    }




    [Ajax.AjaxMethod()]
    public DataSet getUserInfo(string username)
    {
        string sqlstr;
        sqlstr = "select * from USER_ACCOUNT where USERNAME='" + username + "'";
        return DataOpera.Query("", sqlstr);
    }




    [Ajax.AjaxMethod()]
    public string modifyUser(string uid, bool check, string usn, string usrname, string userprof, string pwd)
    {
        string sqlstr;
        sqlstr = "select * from USER_ACCOUNT where USERNAME='" + usn + "' and USERID<>" + uid;
        DataSet myds = DataOpera.Query("", sqlstr);
        if (myds.Tables[0].Rows.Count > 0)
            return "The User name exist already!";

        int checkid = 0;
        if (check) checkid = 1;
        sqlstr = "update USER_ACCOUNT set ACCOUNTLOCK=" + checkid.ToString() + ",";
        /******************邓强-20080310-增加重新设定密码(使用于用户遗忘密码)*************************************/
        if (pwd != "")
        {
            string md5pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            sqlstr += " PASSWORDS='" + md5pwd + "',";
        }
        /******************邓强-20080310-增加重新设定密码(使用于用户遗忘密码)*************************************/
        sqlstr += " USERNAME='" + usn + "' , USERREALNAME ='" + usrname + "',USER_PROF='" + userprof + "' where USERID=" + uid + "";
        return DataOpera.Update("", sqlstr);
    }




    [Ajax.AjaxMethod()]
    public string deleteUser(string username)
    {
        string userid = (DataOpera.Query("", "select USERID from USER_ACCOUNT where USERNAME='" + username + "'")).Tables[0].Rows[0][0].ToString();
        string sqlstr;
        sqlstr = "delete ACCOUNT_GROUP_MAP where USERID=" + userid;
        string retstr = DataOpera.Update("", sqlstr);
        if (retstr == "0")
        {
            sqlstr = "delete USER_ACCOUNT where USERID=" + userid;
            //sqlstr = " update USER_ACCOUNT  set  ACTIVE  = '1' where USERID=" + userid;
            return DataOpera.Update("", sqlstr);
        }
        return retstr;
    }




    [Ajax.AjaxMethod()]
    public string newGroup(string groupdesc, string groupname, bool grouplock)
    {
        string sqlstr;
        sqlstr = "select * from USER_GROUP where GROUPNAME='" + groupname + "'";
        DataSet myds = DataOpera.Query("", sqlstr);
        if (myds.Tables[0].Rows.Count > 0) return "The Group name exist already!";
        string lockstat = "0";
        if (grouplock) lockstat = "1";
        sqlstr = "select max(GROUPID)+1 from USER_GROUP";
        string groupid = DataOpera.Query("", sqlstr).Tables[0].Rows[0][0].ToString();
        sqlstr = "insert into USER_GROUP values(" + groupid + ",'" + groupdesc + "','" + groupname + "'," + lockstat + ")";
        return DataOpera.Update("", sqlstr);
    }



    [Ajax.AjaxMethod()]
    public string deleteGroup(string groupname)
    {
        string sqlstr;
        string groupid = (DataOpera.Query("", "select GROUPID from USER_GROUP where GROUPNAME='" + groupname + "'")).Tables[0].Rows[0][0].ToString();
        sqlstr = "delete USER_PAGE_PRIV where GROUPID=" + groupid;
        string retstr = DataOpera.Update("", sqlstr);
        if (retstr == "0")
        {
            sqlstr = "delete ACCOUNT_GROUP_MAP where GROUPID=" + groupid;
            retstr = DataOpera.Update("", sqlstr);
            if (retstr == "0")
            {
                sqlstr = "delete USER_GROUP where GROUPID=" + groupid;
                retstr = DataOpera.Update("", sqlstr);
                return retstr;
            }
            return retstr;
        }
        return retstr;
    }




    [Ajax.AjaxMethod()]
    public string modifyGroup(string groupid, string groupdesc, string groupname, bool grouplock)
    {
        string sqlstr;
        sqlstr = "select * from USER_GROUP where GROUPNAME='" + groupname + "' and GROUPID<>" + groupid;
        DataSet myds = DataOpera.Query("", sqlstr);
        if (myds.Tables[0].Rows.Count > 0)
            return "The group name exist already!";
        int checkid = 0;
        if (grouplock) checkid = 1;
        sqlstr = "update USER_GROUP set GROUPLOCK=" + checkid.ToString() + ",";
        sqlstr += "DESCR='" + groupdesc + "',GROUPNAME='" + groupname + "' where GROUPID=" + groupid;
        return DataOpera.Update("", sqlstr);
    }

    [Ajax.AjaxMethod()]
    public DataSet getGroupinfo(string groupname)
    {
        string sqlstr;
        sqlstr = "select * from USER_GROUP where GROUPNAME='" + groupname + "'";
        return DataOpera.Query("", sqlstr);
    }

    //获取用户职称
    [Ajax.AjaxMethod()]
    public DataSet GetUserProf()
    {
        string sqlstr = "select distinct(USER_PROF) AS COL1 from TB_WORK_COST_CODE order by USER_PROF";
        DataSet dsSet = DataOpera.Query("", sqlstr);
        int Count = dsSet.Tables[0].Rows.Count;
        if (Count > 0)
            return dsSet;
        else
            return null;
    }
}

