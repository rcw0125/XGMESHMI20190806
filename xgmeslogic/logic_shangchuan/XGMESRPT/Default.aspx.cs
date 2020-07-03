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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        try
        {
            if (Session["ABBGROUPS"].ToString() != "" && Session["ABBUSERNAME"].ToString() != "" && Session["ABBPASSWORD"].ToString() != "")
            {

            }
        }
        catch (Exception myE)
        {
            Trace.Write(myE.Message);
            //Response.Redirect("Login.aspx");//WorkLogin
            Response.Redirect("WorkLogin.aspx");//WorkLogin
        }
    }
}
