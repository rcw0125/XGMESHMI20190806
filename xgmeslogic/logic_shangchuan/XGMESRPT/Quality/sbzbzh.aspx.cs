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

public partial class sbzbzh : System.Web.UI.Page
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
            DB.RecordPageUseCount("sbzbzh");

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
            strSQL = "Select * from ts_sbdjzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='"+ddlzhou.SelectedValue.ToString()+"'";

            //strSQL += " order by logtime";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            ds = new DataSet();
            da.Fill(ds, "tb");
            ReportViewer1.Visible = true;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.Reset();
            ReportDataSource rds = new ReportDataSource("dssbzb", ds.Tables[0]);

            //查询第二个,对点检(维修)进行查询
            strSQL = "Select * from ts_sbdjzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='" + ddlzhou.SelectedValue.ToString() + "' and djdw in('连铸维修车间','冶炼维修车间','运行车间')";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            DataSet dsdjwx = new DataSet();
            da.Fill(dsdjwx, "djwx");
            ReportDataSource rdsdjwx = new ReportDataSource("dsdjwx", dsdjwx.Tables[0]);
            //查询第三个,对点检(分类)进行查询
            strSQL = "select '" + strCurrentDate1 + "' as logtime ,'" + ddlzhou.SelectedValue.ToString() + "' as zhou,djfl,djsl,wtsl from ";
            strSQL += "(";
            strSQL += "SELECT '管理点检' as djfl,sum(zysl)  as djsl,sum(glwtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('冶炼维修车间','连铸维修车间','运行车间') and logtime='" + strCurrentDate1 + "'";
            strSQL += " union ";
            strSQL += "SELECT '岗位点检' as djfl,sum(gwsl)  as djsl,sum(wtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('连铸车间','精炼车间','冶炼一车间') and logtime='" + strCurrentDate1 + "'";
            strSQL += " union ";
            strSQL += "SELECT '维修点检' as djfl,sum(jssl)  as djsl,sum(wtsl-glwtsl) as wtsl from xgwebrpt.TS_SBDJZB where djdw in('冶炼维修车间','连铸维修车间','冶炼一车间') and logtime='" + strCurrentDate1 + "'";
            strSQL += ")";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            DataSet dsdjfl = new DataSet();
            da.Fill(dsdjfl, "djfl");
            ReportDataSource rdsdjfl = new ReportDataSource("Dsdjfl", dsdjfl.Tables[0]);

            //查询第四个,对计划检修进行查询
            strSQL = "Select * from ts_sbjxzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='" + ddlzhou.SelectedValue.ToString() + "'";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            DataSet dsjx = new DataSet();
            da.Fill(dsjx, "jx");
            ReportDataSource rdsjx = new ReportDataSource("Dssbjx", dsjx.Tables[0]);

            //查询第五个,对故障保修进行查询
            strSQL = "Select * from ts_sbbxzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='" + ddlzhou.SelectedValue.ToString() + "'";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            DataSet dsgzbx = new DataSet();
            da.Fill(dsgzbx, "gzbx");
            ReportDataSource rdsgzbx = new ReportDataSource("DsGzbx", dsgzbx.Tables[0]);
            //查询第六个,对故障保修（维修）进行查询
            strSQL = "Select * from ts_sbbxzb where LOGTIME ='" + strCurrentDate1 + "' and zhou='" + ddlzhou.SelectedValue.ToString() + "' and djdw in('连铸维修车间','冶炼维修车间','运行车间')";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            DataSet dsgzbxwx = new DataSet();
            da.Fill(dsgzbxwx, "gzbxwx");
            ReportDataSource rdsgzbxwx = new ReportDataSource("Dsgzbxwx", dsgzbxwx.Tables[0]);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.DataSources.Add(rdsdjfl);
            ReportViewer1.LocalReport.DataSources.Add(rdsdjwx);
            ReportViewer1.LocalReport.DataSources.Add(rdsjx);
            ReportViewer1.LocalReport.DataSources.Add(rdsgzbx);
            ReportViewer1.LocalReport.DataSources.Add(rdsgzbxwx);
            ReportViewer1.LocalReport.ReportPath = "Quality\\sbzbzh.rdlc";
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

