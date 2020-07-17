using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using MESIF;
using System.Web.Services;

/// <summary>
/// WebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World1";
    }

    [WebMethod]
    public DataSet GetMaterial(string heatid)
    {
        
        DataSet ds = null;
        try
        {
            MESAgent ma = new MESAgent();
            ds = ma.GetMainSecondTable("SendAddMaterialsInfor", heatid);
        }
        catch (Exception ex)
        {
            throw new Exception (ex.ToString());
        }
        return ds;
    }

}
