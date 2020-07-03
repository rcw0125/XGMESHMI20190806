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


public partial class left : System.Web.UI.Page
{
    static string jiscousername ="";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(left));
        //jiscousername = Session["ABBREALNAME"].ToString();
        try
        {
            jiscousername = Session["ABBREALNAME"].ToString();
        }
        catch (Exception mye)
        {
            Response.Write(mye.Message);
            Response.Redirect("WorkLogin.aspx");
        }


        // 在此处放置用户代码以初始化页面
        try
        {
            if (Session["ABBGROUPS"].ToString() != "" && Session["ABBUSERNAME"].ToString() != "" && Session["ABBPASSWORD"].ToString() != "")
            {

                #region readXML

                Service1 Queryds = new Service1();
                string sqlstr = "select a.PAGEID,a.PAGEPARENT,a.PAGENAME,a.ACTIONNAME from USER_PAGE a,USER_PAGE_PRIV b where a.PAGEID=b.PAGEID and b.GROUPID=" + Session["ABBGROUPS"].ToString() + " and a.PAGEPARENT=0 order by a.CHILDINDEX";

                DataSet rootds = Queryds.Query("",sqlstr);
                if (rootds.Tables[0].Rows.Count > 0)
                {
                    
                    string outText = "";
                    int t = 100;
                    outText += "<div id=\"Layer1\" style=\"Z-INDEX: 1; LEFT: 0px; OVERFLOW: auto; WIDTH: 170px; POSITION: absolute; TOP: 73px; HEIGHT:100%\">";
                    outText += "	<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"170\"> <tr><td width=\"156\" valign=\"top\">";
                    for (int i = 0; i < rootds.Tables[0].Rows.Count; i++)
                    {
                        string sword = rootds.Tables[0].Rows[i][2].ToString();
                        sword = Server.UrlEncode(sword);
                        string s = Server.UrlDecode(sword);
                        outText += "<table width=\"156\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" ><tr>";
                        outText += "<td  width=\"156\"><a onClick=\"showOpt(" + Convert.ToString(i + 1) + "," + rootds.Tables[0].Rows.Count + ")\" onMouseOver=\"this.style.cursor='hand';MenuPID=" + i.ToString() + ";MenuCID=null;FadeIn(" + i.ToString() + ");\" onmouseout=\"MenuPID=null;MenuCID=null;FadeOut(" + i.ToString() + ");\" ><img id=\"MenuParent" + i.ToString() + "\" src=\"MenuImg.aspx?type=menuParent&cont=" + sword + "\" style=\"filter:alpha(opacity=60)\" ></img></a></td></tr></table>";
                        outText += "			<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"156\"><tr>";
                        outText += "<td valign=\"top\" bgcolor=\"#e8f3f2\" height=\"1\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"156\" bgcolor=\"#caddfa\" ";
                        outText += "style='background-image:url(../image/menuChild_bg.jpg);";
                        outText += "background-repeat:no-repeat;";
                        //outText += "background-position:center;";
                        outText += "background-color:#EFF1FA; BORDER-RIGHT:#d7d7d7 1px solid; BORDER-TOP:#d7d7d7 1px solid; DISPLAY:none; BORDER-LEFT:#d7d7d7 1px solid; BORDER-BOTTOM:#d7d7d7 1px solid' id=\"tb" + Convert.ToString(i + 1) + "\">";
                        ///////子菜单

                        string childsqlstr = "select a.PAGEID,a.PAGEPARENT,a.PAGENAME,a.ACTIONNAME from USER_PAGE a,USER_PAGE_PRIV b where a.PAGEID=b.PAGEID and b.GROUPID=" + Session["ABBGROUPS"].ToString() + " and a.PAGEPARENT=" + rootds.Tables[0].Rows[i][0].ToString() + " order by a.PAGENAME";//a.CHILDINDEX";

                        DataSet childds = Queryds.Query("", childsqlstr);

                        for (int j = 0; j < childds.Tables[0].Rows.Count; j++)
                        {
                            string sword1 = childds.Tables[0].Rows[j][2].ToString();
                            sword1 = Server.UrlEncode(sword1);
                            string s1 = Server.UrlDecode(sword1);

                            outText += "<tr><td width=\"16\"></td><td align=\"left\" height=\"20\"><a href=\"" + childds.Tables[0].Rows[j][3].ToString() + "\" onclick=\"ChangeTopTitle('" +
                                sword + "','" + sword1 + "');\" target=\"mainFrame\" onMouseOver=\"MenuPID=" +
                                i.ToString() + ";MenuCID=" + t.ToString() + ";FadeIn(" + i.ToString() + "," + t.ToString() + ");\"  onmouseout=\"MenuPID=null;MenuCID=null;FadeOut(" +
                                i.ToString() + "," + t.ToString() + ");\"><img id=\"MenuChild" + t.ToString() + "\" style=\"filter:alpha(opacity=60)\" src=\"MenuImg.aspx?type=menuChild&cont=" +
                                sword1 + "\" ></a></td></tr>";
                            t++;


                            ///////////测试3级菜单
                            //string childsqlstr2 = "select a.PAGEID,a.PAGEPARENT,a.PAGENAME,a.ACTIONNAME from USER_PAGE a,USER_PAGE_PRIV b where a.PAGEID=b.PAGEID and b.GROUPID=" + Session["ABBGROUPS"].ToString() + " and a.PAGEPARENT=" + childds.Tables[0].Rows[j][0].ToString() + " order by a.PAGEID";//a.CHILDINDEX";

                            //DataSet childds2 = Queryds.Query("", childsqlstr2);

                            //for (int k = 0; k < childds2.Tables[0].Rows.Count; k++)
                            //{
                            //    string sword2 = childds2.Tables[0].Rows[k][2].ToString();
                            //    sword2 = Server.UrlEncode(sword2);
                            //    string s2 = Server.UrlDecode(sword2);

                            //    outText += "<tr><td width=\"10\"></td><td align=\"left\" height=\"20\"><a href=\"" + childds2.Tables[0].Rows[j][3].ToString() + "\" onclick=\"ChangeTopTitle('" +
                            //        sword1 + "','" + sword2 + "');\" target=\"mainFrame\" onMouseOver=\"MenuPID=" +
                            //        j.ToString() + ";MenuCID=" + t.ToString() + ";FadeIn(" + j.ToString() + "," + t.ToString() + ");\"  onmouseout=\"MenuPID=null;MenuCID=null;FadeOut(" +
                            //        j.ToString() + "," + t.ToString() + ");\"><img id=\"MenuChild" + t.ToString() + "\" style=\"filter:alpha(opacity=60)\" src=\"MenuImg.aspx?type=menuChild&cont=" +
                            //        sword2 + "\" ></a></td></tr>";
                            //    t++;
                            //}

                        }

                        outText += "</table></td></tr></table></td></tr></table>";

                    }
                    outText += "</TD></TR></TABLE></div>";

                    outText += "<script language=\"javascript\"> var MenuPID=null;MenuCID=null;  </script>";

                    Response.Write(outText);
                }

                #endregion


            }
        }

        catch (Exception myE)
        {
            Trace.Write(myE.Message);
            Response.Redirect("WorkLogin.aspx");
        }
    }
    [Ajax.AjaxMethod()]
    public string GetUserName()
    {
        return jiscousername;
    }
}
