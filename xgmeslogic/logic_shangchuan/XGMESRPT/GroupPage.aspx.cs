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

public partial class GroupPage : System.Web.UI.Page
{
    Service1 DataOpera = new Service1();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        Ajax.Utility.RegisterTypeForAjax(typeof(GroupPage));
    }
    [Ajax.AjaxMethod()]
    public DataSet getAllGroup()
    {
        string sqlstr;
        sqlstr = "select GROUPNAME from USER_GROUP";
        return DataOpera.Query("", sqlstr);
    }

    [Ajax.AjaxMethod()]
    public DataSet getPageIDByName(string groupname)
    {
        string sqlstr;
        sqlstr = "select b.PAGEID from USER_GROUP a,USER_PAGE_PRIV b where a.GROUPID=b.GROUPID  and a.GROUPNAME='" + groupname + "' ";
        return DataOpera.Query("", sqlstr);
    }

    [Ajax.AjaxMethod()]
    public DataSet getAllPage(string pageparent)
    {
        string sqlstr;
        sqlstr = "select PAGEID,PAGENAME from USER_PAGE where PAGEPARENT=" + pageparent;
        return DataOpera.Query("", sqlstr);
    }


    [Ajax.AjaxMethod()]
    public string addRelation(string groupname, string pageid)
    {
        string sqlstr;
        string groupid = (DataOpera.Query("", "select GROUPID from USER_GROUP where GROUPNAME='" + groupname + "'")).Tables[0].Rows[0][0].ToString();
        sqlstr = "insert into USER_PAGE_PRIV  values(" + groupid + "," + pageid + ")";
        return DataOpera.Update("", sqlstr);
    }

    [Ajax.AjaxMethod()]
    public string delRelation(string groupname, string pageid)
    {
        string sqlstr;
        string groupid = (DataOpera.Query("", "select GROUPID from USER_GROUP where GROUPNAME='" + groupname + "'")).Tables[0].Rows[0][0].ToString();
        sqlstr = "delete USER_PAGE_PRIV where GROUPID=" + groupid + " and PAGEID=" + pageid;
        return DataOpera.Update("", sqlstr);
    }


    [Ajax.AjaxMethod()]
    public string addnewpage(bool root, string rootparent, string pagename, string pageurl)
    {
        string sqlstr;
        string maxid = DataOpera.Query("", "select max(PAGEID)+1 from USER_PAGE").Tables[0].Rows[0][0].ToString();

        sqlstr = "insert into USER_PAGE values(" + maxid + ",";
        if (root)
        {
            sqlstr += "0,'";
        }
        else
        {
            string parentid = DataOpera.Query("", "select PAGEID from USER_PAGE where PAGENAME='" + rootparent + "'").Tables[0].Rows[0][0].ToString();
            sqlstr += parentid + ",'";
        }
        sqlstr += pagename + "','" + pageurl + "'";
        sqlstr += ",0)";
        return DataOpera.Update("", sqlstr);
    }


    [Ajax.AjaxMethod()]
    public string delpage(string pageid)
    {
        string sqlstr;
        sqlstr = "delete USER_PAGE_PRIV where PAGEID=" + pageid;
        string retval = DataOpera.Update("", sqlstr);
        if (retval == "0")
        {
            sqlstr = "delete USER_PAGE where PAGEID=" + pageid;
            return DataOpera.Update("", sqlstr);
        }
        return retval;
    }

    [Ajax.AjaxMethod()]
    public DataSet getPageInfobyID(string pageid)
    {
        string sqlstr;
        sqlstr = "select * from USER_PAGE where PAGEID=" + pageid;
        return DataOpera.Query("", sqlstr);
    }


    [Ajax.AjaxMethod()]
    public string modifypage(string pageid, bool root, string rootparent, string pagename, string pageurl)
    {
        string sqlstr;
        sqlstr = "update USER_PAGE set PAGEPARENT=";
        if (root)
        {
            sqlstr += "0,";
        }
        else
        {
            string parentid = DataOpera.Query("", "select PAGEID from USER_PAGE where PAGENAME='" + rootparent + "'").Tables[0].Rows[0][0].ToString();
            sqlstr += parentid + ",";
        }
        sqlstr += "PAGENAME='" + pagename + "',ACTIONNAME='" + pageurl + "' where PAGEID=" + pageid;
        return DataOpera.Update("", sqlstr);
    }
}
