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
using CrystalDecisions.CrystalReports.Engine;

public partial class Plant_PageUseCount : System.Web.UI.Page
{
    protected string date1;
    protected string year;
    protected string month;
    protected int day;
    protected string Endyear;
    protected string Endmonth;
    protected int Endday;
    protected bool newdate;
    private ReportDocument rdt = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            //DB.RecordPageUseCount("Plant_PageUseCount");
           
            OracleConnection conn = DB.createConn();
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                if (newdate)
                {
                    CrystalReportViewer1.ResetReportPartNavigation();
                    newdate = false;
                }
                
                conn.Open();
                DataSet ds = new DataSet();

                string strSQL = "Select * from PAGE_USE_COUNT ORDER BY  PAGE_NAME";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "PAGE_USE_COUNT");

                rdt.Load(this.Server.MapPath("").ToString() + "\\PageUseCount.rpt");

                rdt.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rdt;
                CrystalReportViewer1.DataBind();

                ds.Dispose();

            }
            catch (Exception ee)
            {
                Response.Write(ee.ToString());//"出错");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
