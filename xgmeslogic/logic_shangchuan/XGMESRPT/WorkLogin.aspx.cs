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

public partial class WorkLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUser.Focus();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        DataSet tempds;
        string md5pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
        Service1 LoginQuery = new Service1();
        string tempusername = txtUser.Text.Trim().Replace("'", "").Replace("--", "");
        string sqlstr = "select * from USER_ACCOUNT where USERNAME='" + tempusername + "' and PASSWORDS='" + md5pass + "'";

        tempds = LoginQuery.Query("", sqlstr);
        if (tempds == null)
        {
            Response.Write("DFDF");
            return;
        }
        if (tempds.Tables[0].Rows.Count > 0)
        {
            tempds.Clear();
            sqlstr = "select  b.GROUPID,a.USERREALNAME from USER_ACCOUNT a,USER_GROUP b,ACCOUNT_GROUP_MAP c ";
            sqlstr += "where a.USERID=c.USERID and c.GROUPID=b.GROUPID and a.USERNAME='" + txtUser.Text + "'";
            tempds = LoginQuery.Query("", sqlstr);
            if (tempds.Tables[0].Rows.Count > 0)
            {
                string sql = "insert into TS_USER_LOGIN(userid,username,ip) values('" + txtUser.Text + "','" + tempds.Tables[0].Rows[0][1].ToString() + "','"+getip()+"')";
                LoginQuery.Update("", sql);

                Session["ABBUSERNAME"] = tempusername;
                Session["ABBPASSWORD"] = md5pass;
                Session["ABBREALNAME"] = tempds.Tables[0].Rows[0][1].ToString();
                Session["ABBGROUPS"] = Convert.ToString(tempds.Tables[0].Rows[0][0]);
                System.Web.Security.FormsAuthentication.SetAuthCookie(tempusername, false);
                Response.Redirect("default.aspx");
                Label1.Text = "";
            }
        }
        else
        {
            Label1.Text = "用户名或密码输入不正确,请重新输入.";
            txtPassword.Focus();
        }
    }

    public string getip()
    {
        string ip=HttpContext.Current.Request.UserHostAddress;
        string ip1=HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        string ip2=HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        string zip = "";
        if (ip != "")
        {
            zip += ip + ";";
        }
        if (ip1 != "")
        {
            zip += ip1 + ";";
        }
        if (ip2 != "")
        {
            zip += ip2 + ";";
        }
        return zip;
    }
}
