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
using Microsoft.Reporting.WebForms;
 

public partial class DES_frmDESDATA : System.Web.UI.Page
{
    protected string date1;
    protected string year;
    protected string month;
    protected int day;
    protected string Endyear;
    protected string Endmonth;
    protected int Endday;
    protected bool newdate;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("DES_frmDESDATA");

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
                ddlStartYear.Items.Add(Year);
                //EndYear.Items.Add(Year);
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
                    ddlStartMonth.Text = Month.Text;
                    break;
                }
                else
                    Month.Selected = false;
            }
            AddDate(sender, e);
            AddDateStart(sender, e);
            CurrentDate = Convert.ToString(DateTime.Now.Day);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem day in ddlDay.Items)
            {
                if (day.Text == CurrentDate)
                {
                    day.Selected = true;
                    ddlDay.Text = day.Text;
                    //EndDay.Text = day.Text;
                    ddlStartDay.Text = day.Text;
                    break;
                }
                else
                    day.Selected = false;
            }

        }
        else
        {
            //string strCurrentDate = ddlYear.SelectedValue.ToString() + '-' + ddlMonth.SelectedValue.ToString() + '-' + ddlDay.SelectedValue.ToString();

            //string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString() + "-" + ddlStartDay.SelectedValue.ToString();

            //DateTime dtStart = Convert.ToDateTime(strCurrentDate1);
            //DateTime dtEnd = Convert.ToDateTime(strCurrentDate);
            //double dStopTime = Math.Round((dtEnd.ToOADate() - dtStart.ToOADate()), 0);
            //if (dStopTime > 31)
            //{
            //    ReportViewer1.LocalReport.DataSources.Clear();
            //    ReportViewer1.LocalReport.Refresh();


            //    Response.Write("<script   language='javascript'>if(window.confirm('请查询一个月以内的数据!'))"
            //        + this.Page.ClientScript.GetPostBackEventReference(btnQuery, "") + ";</script>");   
  
            //    return;
            //}
            //else
            //{
            //    OracleConnection conn = DB.createConn();
            //    try
            //    {
            //        OracleDataAdapter da = new OracleDataAdapter();
            //        if (newdate)
            //        {
            //            newdate = false;
            //        }

            //        conn.Open();
            //        string strSQL = "Select * from TD_DES_ORIGINALRECORD where PRODUCTIONDATE  >='" + strCurrentDate1 + "'and PRODUCTIONDATE <='" + strCurrentDate + "'ORDER BY PRODUCTIONDATE ,ARRAIVL_TIME";
            //        if (TeamDropDownList.SelectedValue.ToString() != "")
            //            strSQL = "Select * from TD_DES_ORIGINALRECORD where PRODUCTIONDATE  >='" + strCurrentDate1 + "'and PRODUCTIONDATE <='" + strCurrentDate + "' and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'ORDER BY PRODUCTIONDATE ,ARRAIVL_TIME";
            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        dsDES ds = new dsDES();
            //        da.Fill(ds, "TD_DES_ORIGINALRECORD");

            //        ReportViewer1.Visible = true;

            //        //ReportParameter rptParaA = new ReportParameter("rptParaA", "测试报表参数");
            //        //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { rptParaA });

            //        ReportDataSource rds = new ReportDataSource("dsDES_TD_DES_ORIGINALRECORD", ds.Tables[0]);
            //        ReportViewer1.LocalReport.DataSources.Clear();
            //        ReportViewer1.LocalReport.DataSources.Add(rds);
            //        ReportViewer1.LocalReport.Refresh();
            //    }
            //    catch (Exception ee)
            //    {
            //        Response.Write(ee.ToString());//"出错");
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
        }
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
    private void AddDateStart(object sender, System.EventArgs e)
    {

        string nowday = ddlStartDay.SelectedValue;

        if (ddlStartMonth.SelectedValue != null)
            month = ddlStartMonth.SelectedValue;
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
            year = ddlStartYear.SelectedValue;

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

        ddlStartDay.Items.Clear();
        for (int i = 1; i <= day; i++)
        {
            string addday = Convert.ToString(i);
            if (addday.Length < 2)
                addday = "0" + addday;
            ddlStartDay.Items.Add(addday);
        }

        if (nowday == "") nowday = Convert.ToString(DateTime.Now.Day);
        foreach (ListItem li in ddlStartDay.Items)
        {
            if (li.Text == nowday)
                li.Selected = true;
            else
                li.Selected = false;
        }


        //for (int i = 1; i <= day; i++)
        //{
        //    string addday = Convert.ToString(i);
        //    if (addday.Length < 2)
        //        addday = "0" + addday;
    }

    protected void ddlStartYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDateStart(sender, e);
    }
    protected void ddlStartMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDateStart(sender, e);

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
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
        string strCurrentDate = ddlYear.SelectedValue.ToString() + '-' + ddlMonth.SelectedValue.ToString() + '-' + ddlDay.SelectedValue.ToString();

        string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString() + "-" + ddlStartDay.SelectedValue.ToString();

        DateTime dtStart = Convert.ToDateTime(strCurrentDate1);
        DateTime dtEnd = Convert.ToDateTime(strCurrentDate);
        double dStopTime = Math.Round((dtEnd.ToOADate() - dtStart.ToOADate()), 0);
        if (dStopTime > 31)
        {
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.Refresh();


            Response.Write("<script   language='javascript'>if(window.confirm('请查询一个月以内的数据!'))"
                + this.Page.ClientScript.GetPostBackEventReference(btnQuery, "") + ";</script>");

            return;
        }
        else
        {
            OracleConnection conn = DB.createConn();
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                if (newdate)
                {
                    newdate = false;
                }

                conn.Open();
                string strSQL = "Select * from TD_DES_ORIGINALRECORD where PRODUCTIONDATE  >='" + strCurrentDate1 + "'and PRODUCTIONDATE <='" + strCurrentDate + "'ORDER BY PRODUCTIONDATE ,ARRAIVL_TIME";
                if (TeamDropDownList.SelectedValue.ToString() != "")
                    strSQL = "Select * from TD_DES_ORIGINALRECORD where PRODUCTIONDATE  >='" + strCurrentDate1 + "'and PRODUCTIONDATE <='" + strCurrentDate + "' and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'ORDER BY PRODUCTIONDATE ,ARRAIVL_TIME";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                dsDES ds = new dsDES();
                da.Fill(ds, "TD_DES_ORIGINALRECORD");

                ReportViewer1.Visible = true;

                //ReportParameter rptParaA = new ReportParameter("rptParaA", "测试报表参数");
                //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { rptParaA });

                ReportDataSource rds = new ReportDataSource("dsDES_TD_DES_ORIGINALRECORD", ds.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.Refresh();
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
