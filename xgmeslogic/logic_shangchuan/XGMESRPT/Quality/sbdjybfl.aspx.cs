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
using Microsoft.Reporting.WebForms;

public partial class sbdjybfl : System.Web.UI.Page
{
    protected string date1;
    protected string date2;
    protected string year;
    protected string month;
    protected int day;
    protected string Endyear;
    protected string Endmonth;
    protected int Endday;
    protected bool newdate;
    //private ReportViewer rdt = new ReportViewer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("sbdjybfl");

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
                ddlStartYear.Items.Add(Year);
            }

            string CurrentDate = Convert.ToString(DateTime.Now.Month);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem Month in ddlStartMonth.Items)
            {
                if (Month.Text == CurrentDate)
                {
                    Month.Selected = true;
                    ddlStartMonth.Text = Month.Text;             
                    break;
                }
                else
                    Month.Selected = false;
            }

           
        }
        else
        {
           
        }
    }
   
    protected void btnQuery_Click(object sender, EventArgs e)
    {
       
        Page_Load(sender, e);
        string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString();      
        OracleConnection conn = DB.createConn();
        OracleDataAdapter da = new OracleDataAdapter();
       
        DataSet ds = new DataSet();
        
        string strSQL = "";
       
        try
        {
            if (newdate)
            {

                newdate = false;
            }
            conn.Open();
            //SELECT '岗位点检' as djfl,sum(gwsl)  as djsl from xgwebrpt.TS_SBDJZB where logtime='2019-10' and zhou='4'
//UNION
//SELECT '技术点检' as djfl,sum(jssl)  as djsl from xgwebrpt.TS_SBDJZB where logtime='2019-10' and zhou='4'
//UNION
//SELECT '专业点检' as djfl,sum(zysl)  as djsl from xgwebrpt.TS_SBDJZB where logtime='2019-10' and zhou='4'
            //strSQL = "Select * from ts_sbdjzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='" + ddlzhou.SelectedValue.ToString() + "'";



            strSQL = "select '" + strCurrentDate1 + "' as logtime ,djfl,djsl,wtsl from ";
            strSQL += "(";
            strSQL += "SELECT '管理点检' as djfl,sum(zysl)  as djsl,sum(glwtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('冶炼维修车间','连铸维修车间','冶炼一车间') and logtime='" + strCurrentDate1 + "'";       
            strSQL += " union ";
            strSQL += "SELECT '岗位点检' as djfl,sum(gwsl)  as djsl,sum(wtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('连铸车间','精炼车间','冶炼一车间') and logtime='" + strCurrentDate1 + "'";           
            strSQL += " union ";
            strSQL += "SELECT '维修点检' as djfl,sum(jssl)  as djsl,sum(wtsl-glwtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('冶炼维修车间','连铸维修车间','冶炼一车间') and logtime='" + strCurrentDate1 + "'";
            strSQL += ")";

            //strSQL += " order by logtime";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            ds = new DataSet();
            da.Fill(ds, "tb");
            ReportViewer1.Visible = true;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.Reset();
            ReportDataSource rds = new ReportDataSource("Dsdjfl", ds.Tables[0]);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Quality\\sbdjybfl.rdlc";
            ReportViewer1.LocalReport.Refresh();
            ds.Dispose();
            conn.Close();

           

        }
        catch (Exception ee)
        {
            string strMessage = ee.Message.ToString();
        }
        finally
        {
            ds.Dispose();
            conn.Close();
        }
    }

    
   
}

