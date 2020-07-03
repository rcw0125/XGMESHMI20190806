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

public partial class DeSIronWeight : System.Web.UI.Page
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
    private string strCurrentDate;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("DeSIronWeight");

            date1 = "1910-01";
            newdate = false;

            int CurrentYear = Convert.ToInt32(DateTime.Now.Year);
            int i;
            for (i = CurrentYear - 5; i <= CurrentYear; i++)
            {
                ListItem Year = new ListItem();
                Year.Text = Convert.ToString(i);
                Year.Value = Convert.ToString(i);
                if (i == CurrentYear) Year.Selected = true;
                else Year.Selected = false;
                ddlYear.Items.Add(Year);
            }

            string CurrentDate = Convert.ToString(DateTime.Now.Month);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem Month in ddlMonth.Items)
            {
                if (Month.Text == CurrentDate)
                {
                    Month.Selected = true;
                    ddlMonth.Text = Month.Text;
                    //EndMonth.Text = Month.Text;
                    break;
                }
                else
                    Month.Selected = false;
            }
        }
        else
        {
            strCurrentDate = ddlYear.SelectedValue.ToString() + '-' + ddlMonth.SelectedValue.ToString();

            OracleConnection conn = DB.createConn();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "";
            try
            {
                if (newdate)
                {
                    CrystalReportViewer1.ResetReportPartNavigation();
                    newdate = false;
                }
                conn.Open();


                strSQL = "Select * from TQ_DES_STATISTICS where substr(LOGTIME,1,7) = '" + strCurrentDate + "' order by LogTime ,TEAM ";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TQ_DES_STATISTICS");

                rdt.Load(this.Server.MapPath("").ToString() + "\\\\DeSIron.rpt");

                //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;

                rdt.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rdt;
                CrystalReportViewer1.DataBind();





            }
            catch (Exception ee)
            {
                Response.Write(ee.ToString());//"出错");
            }
            finally
            {
                ds.Dispose();
                conn.Close();
            }

        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        rdt.Dispose();
    }
    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;

    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
    }
}
