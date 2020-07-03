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

public partial class Quality_PlanSteelGradeTeam : System.Web.UI.Page
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
    private ReportDocument rdt = new ReportDocument();
    private string strCurrentDate;
    private string strCurrentDate1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("Quality_PlanSteelGradeTeam");

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
                    break;
                }
                else
                    Month.Selected = false;
            }
            AddDate(sender, e);
            CurrentDate = Convert.ToString(DateTime.Now.Day);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem day in ddlDay.Items)
            {
                if (day.Text == CurrentDate)
                {
                    day.Selected = true;
                    ddlDay.Text = day.Text;
                    break;
                }
                else
                    day.Selected = false;
            }

        }
        else
        {
            if (newdate)
            {
                CRVTundishTempRate.ResetReportPartNavigation();
                newdate = false;
            }
            strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
            strCurrentDate1 = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString();

            OracleConnection conn = DB.createConn();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "";
            try
            {
                if (newdate)
                {
                    CRVTundishTempRate.ResetReportPartNavigation();
                    newdate = false;
                }
                conn.Open();
                string j = Quality.SelectedValue.ToString();
                if (j == "0")
                {
                    strSQL = "Select * from TQ_PlanSteelGrade_Team where LOGTIME = '" + strCurrentDate + "'  order by Plan_SteelGrade";
                    da.SelectCommand = new OracleCommand(strSQL, conn);

                    da.Fill(ds, "TQ_PlanSteelGrade_Team");
                    rdt.Load(this.Server.MapPath("").ToString() + "\\PlanSteelGradeTeam.rpt");

                    //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                    rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEsheet;
                    
                    rdt.SetDataSource(ds);

                    CRVTundishTempRate.ReportSource = rdt;
                    CRVTundishTempRate.DataBind();
                }
                else if (j == "1")
                {
                    strSQL = "Select * from TQ_PlanSteelGrade_Info where substr(LOGTIME,1,7) = '" + strCurrentDate1 + "'  order by　LOGTIME,Team";
                    da.SelectCommand = new OracleCommand(strSQL, conn);
                    da.Fill(ds, "TQ_PlanSteelGrade_Info");

                    rdt.Load(this.Server.MapPath("").ToString() + "\\PlanSteelGradeInfo.rpt");

                    //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                    rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEsheet;

                    rdt.SetDataSource(ds);
                    CRVTundishTempRate.ReportSource = rdt;
                    CRVTundishTempRate.DataBind();
                }
                else if (j == "2")
                {
                    strSQL = "Select * from TQ_PlanSteelGrade_Ele where LOGTIME = '" + strCurrentDate + "'  order by Plan_SteelGrade";
                    da.SelectCommand = new OracleCommand(strSQL, conn);
                    da.Fill(ds, "TQ_PlanSteelGrade_Ele");

                    string strFileName = this.Server.MapPath("").ToString() + "\\PlanSteelGradeEle.rpt ";
                    rdt.Load(strFileName);

                    //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                    rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperEsheet;

                    rdt.SetDataSource(ds);
                    CRVTundishTempRate.ReportSource = rdt;
                    CRVTundishTempRate.DataBind();
                }

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
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //OracleConnection conn = DB.createConn();
        //OracleDataAdapter da = new OracleDataAdapter();
        //DataSet ds = new DataSet();
        //string strSQL = "";
        //try
        //{
        //    if (newdate)
        //    {
        //        CRVTundishTempRate.ResetReportPartNavigation();
        //        newdate = false;
        //    }
        //    conn.Open();
        //    string j = Quality.SelectedValue.ToString();
        //    if (j == "0")
        //    {
        //        strSQL ="Select * from TQ_PlanSteelGrade_Team where LOGTIME = '" + strCurrentDate + "'  order by SteelGrade";
        //        da.SelectCommand = new OracleCommand(strSQL, conn);

        //        da.Fill(ds, "TQ_PlanSteelGrade_Team");
        //        rdt = new ReportDocument();
        //        rdt.Load(this.Server.MapPath("").ToString() + "\\PlanSteelGradeTeam.rpt");
        //        rdt.SetDataSource(ds);

        //        CRVTundishTempRate.ReportSource = rdt;
        //        CRVTundishTempRate.DataBind();
        //    }
        //    else if (j == "1")
        //    {
        //        strSQL = "Select * from TQ_PlanSteelGrade_Info where substr(LOGTIME,1,7) = '" + strCurrentDate1 + "'  order by　LOGTIME,Team";
        //        da.SelectCommand = new OracleCommand(strSQL, conn);
        //        da.Fill(ds, "TQ_PlanSteelGrade_Info");

        //        rdt = new ReportDocument();
        //        rdt.Load(this.Server.MapPath("").ToString() + "\\PlanSteelGradeInfo.rpt");

        //        rdt.SetDataSource(ds);
        //        CRVTundishTempRate.ReportSource = rdt;
        //        CRVTundishTempRate.DataBind();
        //    }
        //    else if (j=="2")
        //    {
        //        strSQL =  "Select * from TQ_PlanSteelGrade_Ele where LOGTIME = '" + strCurrentDate + "'  order by SteelGrade";
        //        da.SelectCommand = new OracleCommand(strSQL, conn);
        //        ds = new DataSet();
        //        da.Fill(ds, "TQ_PlanSteelGrade_Ele");
        //        rdt = new ReportDocument();
         
        //        string strFileName = this.Server.MapPath("").ToString() + "\\PlanSteelGradeEle.rpt ";
        //        rdt.Load(strFileName);

        //        rdt.SetDataSource(ds);
        //        CRVTundishTempRate.ReportSource = rdt;
        //        CRVTundishTempRate.DataBind();
        //    }

        //}
        //catch (Exception ee)
        //{
        //    Response.Write(ee.ToString());//"出错");
        //}
        //finally
        //{
        //    conn.Close();
        //}
    }

    
 
     private void AddDate(object sender, System.EventArgs e)
    {

        string nowday = ddlDay.SelectedValue;

        if (ddlMonth.SelectedValue != null)
            month = ddlMonth.SelectedValue;
        else
            month = Convert.ToString(DateTime.Now.Month);

        if ((month == "01") || (month == "03") || (month == "05") || (month == "07") || (month == "08") || (month == "10") || (month == "12"))
        {
            day = 31;
        }
        if ((month == "04") || (month == "06") || (month == "09") || (month == "11"))
        {
            day = 30;
        }
        if (month == "02")
        {
            year = ddlYear.SelectedValue;

            if ((Convert.ToInt32(year) % 4 == 0) && (Convert.ToInt32(year) % 100 != 0))
            {
                day = 29;
            }
            else
                if (Convert.ToInt32(year) % 400 == 0)
                    day = 29;
                else
                    day = 28;
        }

        ddlDay.Items.Clear();
        for (int i = 1; i <= day; i++)
        {
            string addday = Convert.ToString(i);
            if (addday.Length < 2)
                addday = "0" + addday;
            ddlDay.Items.Add(addday);
        }

        if (nowday == "") nowday = Convert.ToString(DateTime.Now.Day);
        foreach (ListItem li in ddlDay.Items)
        {
            if (li.Text == nowday)
                li.Selected = true;
            else
                li.Selected = false;
        }


        for (int i = 1; i <= day; i++)
        {
            string addday = Convert.ToString(i);
            if (addday.Length < 2)
                addday = "0" + addday;
        }
    }


    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDate(sender, e);
    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDate(sender, e);
    }
}

