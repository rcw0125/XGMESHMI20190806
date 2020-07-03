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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public partial class MenuImg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCont = null;
        string strType = null;
        string picpath = null;
        Bitmap bmp;
        Graphics g;
        try
        {
            strType = Request["type"].ToString();
            strCont = Request["cont"].ToString();
            strCont = Server.UrlDecode(strCont);
            switch (strType)
            {
                case "menuParent":
                    picpath = Server.MapPath(".") + "\\image\\menuParent2.jpg";
                    bmp = new Bitmap(picpath);
                    g = Graphics.FromImage(bmp);
                    g.DrawString(strCont, new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 30, 8);
                    break;
                case "menuChild":
                    picpath = Server.MapPath(".") + "\\image\\menuChild.jpg";
                    bmp = new Bitmap(picpath);
                    g = Graphics.FromImage(bmp);
                    g.DrawString(strCont, new Font("Arial", 9), new SolidBrush(Color.Black), 40, 8);                    
                    break;
                default :
                    bmp = new Bitmap("null.jpg");
                    g = Graphics.FromImage(bmp);
                    g.DrawString("Wrong!", new Font("Arial", 9), new SolidBrush(Color.Black), 20, 5);
                    break;
            }

        }
        catch (Exception mye)
        {
            strType = "";
            strCont = "";
            bmp = null;
            Response.Write(mye.Message);
        }

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);
    }

   

}
