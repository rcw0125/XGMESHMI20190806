﻿using System;
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

public partial class Quality_BOFEleDisQuality : System.Web.UI.Page
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
            DB.RecordPageUseCount("Quality_BOFEleDisQuality");

            date1 = "1910-01";
            newdate = false;

            //int CurrentYear = Convert.ToInt32(DateTime.Now.Year);
            //int i;
            //for (i = CurrentYear - 5; i <= CurrentYear; i++)
            //{
            //    ListItem Year = new ListItem();
            //    Year.Text = Convert.ToString(i);
            //    Year.Value = Convert.ToString(i);
            //    if (i == CurrentYear) Year.Selected = true;
            //    else Year.Selected = false;
            //    ddlYear.Items.Add(Year);
            //}

            //string CurrentDate = Convert.ToString(DateTime.Now.Month);
            //if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            //foreach (ListItem Month in ddlMonth.Items)
            //{
            //    if (Month.Text == CurrentDate)
            //    {
            //        Month.Selected = true;
            //        ddlMonth.Text = Month.Text;
            //        break;
            //    }
            //    else
            //        Month.Selected = false;
            //}
            //AddDate(sender, e);
            //CurrentDate = Convert.ToString(DateTime.Now.Day);
            //if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            //foreach (ListItem day in ddlDay.Items)
            //{
            //    if (day.Text == CurrentDate)
            //    {
            //        day.Selected = true;
            //        ddlDay.Text = day.Text;
            //        break;
            //    }
            //    else
            //        day.Selected = false;
            //}
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
            }

            string CurrentDate = Convert.ToString(DateTime.Now.Month);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem Month in ddlMonth.Items)
            {
                if (Month.Text == CurrentDate)
                {
                    Month.Selected = true;
                    ddlMonth.Text = Month.Text;
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
                    ddlStartDay.Text = day.Text;
                    break;
                }
                else
                    day.Selected = false;
            }
        }
        else
        {
            //if (newdate)
            //{
            //    //CRVTundishTempRate.ResetReportPartNavigation();
            //    newdate = false;
            //}

            //string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
            //string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString() + "-" + ddlStartDay.SelectedValue.ToString();
            //DateTime dtStart = Convert.ToDateTime(strCurrentDate1);
            //DateTime dtEnd = Convert.ToDateTime(strCurrentDate);
            //double dStoptime1 = Math.Round((dtEnd.ToOADate()), 0);
            //double dStoptime2 = Math.Round((dtStart.ToOADate()), 0);
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


            //    string strCurrentDate2 = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();

            //    OracleConnection conn = DB.createConn();
            //    OracleDataAdapter da = new OracleDataAdapter();
            //    OracleDataAdapter da1 = new OracleDataAdapter();
            //    OracleDataAdapter da2 = new OracleDataAdapter();
            //    DataSet ds = new DataSet();
            //    DataSet ds1 = new DataSet();
            //    DataSet ds2 = new DataSet();
            //    string strSQL = "";
            //    string strSQL1 = "";
            //    string strSQL2 = "";
            //    try
            //    {
            //        if (newdate)
            //        {
            //            //CRVTundishTempRate.ResetReportPartNavigation();
            //            newdate = false;
            //        }
            //        conn.Open();
            //        string j = Quality.SelectedValue.ToString();

            //        if (j == "0")
            //        {
            //            //strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME = '" + strCurrentDate + "'order by Team";
            //            strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "'";
                        
            //            da.SelectCommand = new OracleCommand(strSQL, conn);
            //            ds = new DataSet();
                        
            //            da.Fill(ds, "TQ_BOF_ELE_DISQUALITY");
            //            ///
            //            strSQL1 = "Select logtime, JUDGE_RATE, SUM_COUNT, TEAM,SUM_JUDGE from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "' and team='81'";
            //            strSQL2 = "Select logtime, JUDGE_RATE, SUM_COUNT, TEAM,SUM_JUDGE from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "' and team='91'";
            //            da1.SelectCommand = new OracleCommand(strSQL1, conn);
            //            da2.SelectCommand = new OracleCommand(strSQL1, conn);
            //            ds1 = new DataSet();
            //            ds2 = new DataSet();
            //            da1.Fill(ds1, "TQ_BOF_ELE_DISQUALITY");
            //            da2.Fill(ds2, "TQ_BOF_ELE_DISQUALITY");
            //            ///
            //            ReportViewer1.Visible = true;
            //            ReportViewer1.LocalReport.DataSources.Clear();

            //            ReportDataSource rds = new ReportDataSource("dsBOFEleDisQuality", ds.Tables[0]);
                       
            //            ReportViewer1.Reset();
            //            ReportViewer1.LocalReport.DataSources.Add(rds);
            //            ReportDataSource rds1 = new ReportDataSource("dsBOFEleDisQuality1", ds1.Tables[0]);
            //            ReportDataSource rds2 = new ReportDataSource("dsBOFEleDisQuality2", ds1.Tables[0]);
            //            ReportViewer1.LocalReport.DataSources.Add(rds1);
            //            ReportViewer1.LocalReport.ReportPath = "Quality\\BOFEleDisQuality.rdlc";
                      
            //            ReportViewer1.LocalReport.Refresh();
            //            ds.Dispose();
            //            ds1.Dispose();
            //            ds2.Dispose();
            //            conn.Close();


            //        }

            //        else if (j == "1")
            //        {
            //            //strSQL = "Select * from TQ_BOF_ELE_DISQUALITY_DETAIL where LOGTIME = '" + strCurrentDate + "' and judge_flag = '1'order by Team";
            //            strSQL = "Select * from TQ_BOF_ELE_DISQUALITY_DETAIL where LOGTIME> = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "'and judge_flag = '1'order by LOGTIME ASC, Team ASC";
            //            da.SelectCommand = new OracleCommand(strSQL, conn);
            //            ds = new DataSet();
            //            da.Fill(ds, "TQ_BOF_ELE_DISQUALITY_DETAIL");
            //            ReportViewer1.Visible = true;
            //            ReportViewer1.LocalReport.DataSources.Clear();
            //            ReportViewer1.Reset();
            //            ReportDataSource rds = new ReportDataSource("dsBOFEleDisQualityDetail", ds.Tables[0]);

            //            ReportViewer1.LocalReport.DataSources.Add(rds);
            //            ReportViewer1.LocalReport.ReportPath = "Quality\\BOFEleDisQualityDetail.rdlc";
            //            ReportViewer1.LocalReport.Refresh();
            //            ds.Dispose();
            //            conn.Close();


            //        }

            //    }
            //    catch (Exception ee)
            //    {
            //        string strMessage = ee.Message.ToString();
            //    }
            //    finally
            //    {
            //        ds.Dispose();
            //        conn.Close();
            //    }
            //}
        }
    }
    //protected void Page_UnLoad(object sender, EventArgs e)
    //{
    //   rdt.Dispose();
    //}
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();

        //OracleConnection conn = DB.createConn();
        //OracleDataAdapter da = new OracleDataAdapter();
        //DataSet ds = new DataSet();
        //string strSQL = "";
        //conn.Open();
        //string j = Quality.SelectedValue.ToString();
        //if (j == "0")
        //{
        //    strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME = '" + strCurrentDate + "'order by Team";
        //    da.SelectCommand = new OracleCommand(strSQL, conn);
        //    ds = new DataSet();
        //    da.Fill(ds, "TQ_BOF_ELE_DISQUALITY");


        //}
        //else if (j == "1")
        //{
        //    strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME = '" + strCurrentDate + "'order by Team";
        //    da.SelectCommand = new OracleCommand(strSQL, conn);
        //    ds = new DataSet();
        //    da.Fill(ds, "TQ_BOF_ELE_DISQUALITY");



        //}
        Page_Load(sender, e);
        string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
        string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString() + "-" + ddlStartDay.SelectedValue.ToString();
        DateTime dtStart = Convert.ToDateTime(strCurrentDate1);
        DateTime dtEnd = Convert.ToDateTime(strCurrentDate);
        double dStoptime1 = Math.Round((dtEnd.ToOADate()), 0);
        double dStoptime2 = Math.Round((dtStart.ToOADate()), 0);
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


            string strCurrentDate2 = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();

            OracleConnection conn = DB.createConn();
            OracleDataAdapter da = new OracleDataAdapter();
            OracleDataAdapter da1 = new OracleDataAdapter();
            OracleDataAdapter da2 = new OracleDataAdapter();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            string strSQL = "";
            string strSQL1 = "";
            string strSQL2 = "";
            try
            {
                if (newdate)
                {
                    //CRVTundishTempRate.ResetReportPartNavigation();
                    newdate = false;
                }
                conn.Open();
                string j = Quality.SelectedValue.ToString();

                if (j == "0")
                {
                    //strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME = '" + strCurrentDate + "'order by Team";
                    strSQL = "Select * from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "'";

                    da.SelectCommand = new OracleCommand(strSQL, conn);
                    ds = new DataSet();

                    da.Fill(ds, "TQ_BOF_ELE_DISQUALITY");
                    ///
                    strSQL1 = "Select logtime, JUDGE_RATE, SUM_COUNT, TEAM,SUM_JUDGE from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "' and team='81'";
                    strSQL2 = "Select logtime, JUDGE_RATE, SUM_COUNT, TEAM,SUM_JUDGE from TQ_BOF_ELE_DISQUALITY where LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "' and team='91'";
                    da1.SelectCommand = new OracleCommand(strSQL1, conn);
                    da2.SelectCommand = new OracleCommand(strSQL1, conn);
                    ds1 = new DataSet();
                    ds2 = new DataSet();
                    da1.Fill(ds1, "TQ_BOF_ELE_DISQUALITY");
                    da2.Fill(ds2, "TQ_BOF_ELE_DISQUALITY");
                    ///
                    ReportViewer1.Visible = true;
                    ReportViewer1.LocalReport.DataSources.Clear();

                    ReportDataSource rds = new ReportDataSource("dsBOFEleDisQuality", ds.Tables[0]);

                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.DataSources.Add(rds);
                    ReportDataSource rds1 = new ReportDataSource("dsBOFEleDisQuality1", ds1.Tables[0]);
                    ReportDataSource rds2 = new ReportDataSource("dsBOFEleDisQuality2", ds1.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Add(rds1);
                    ReportViewer1.LocalReport.ReportPath = "Quality\\BOFEleDisQuality.rdlc";

                    ReportViewer1.LocalReport.Refresh();
                    ds.Dispose();
                    ds1.Dispose();
                    ds2.Dispose();
                    conn.Close();


                }

                else if (j == "1")
                {
                    //strSQL = "Select * from TQ_BOF_ELE_DISQUALITY_DETAIL where LOGTIME = '" + strCurrentDate + "' and judge_flag = '1'order by Team";
                    strSQL = "Select * from TQ_BOF_ELE_DISQUALITY_DETAIL where LOGTIME> = '" + strCurrentDate1 + "'and LOGTIME<= '" + strCurrentDate + "'and judge_flag = '1'order by LOGTIME ASC, Team ASC";
                    da.SelectCommand = new OracleCommand(strSQL, conn);
                    ds = new DataSet();
                    da.Fill(ds, "TQ_BOF_ELE_DISQUALITY_DETAIL");
                    ReportViewer1.Visible = true;
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.Reset();
                    ReportDataSource rds = new ReportDataSource("dsBOFEleDisQualityDetail", ds.Tables[0]);

                    ReportViewer1.LocalReport.DataSources.Add(rds);
                    ReportViewer1.LocalReport.ReportPath = "Quality\\BOFEleDisQualityDetail.rdlc";
                    ReportViewer1.LocalReport.Refresh();
                    ds.Dispose();
                    conn.Close();


                }

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

