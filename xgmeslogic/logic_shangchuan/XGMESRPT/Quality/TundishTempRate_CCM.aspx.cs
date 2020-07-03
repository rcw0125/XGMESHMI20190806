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

public partial class Quality_Waste : System.Web.UI.Page
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("Quality_Waste");

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
            //if (newdate)
            //{
            //    //CRVTundishTempRate.ResetReportPartNavigation();
            //    newdate = false;
            //}
            //string strCurrentDate1 = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString();
            //string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();

            //OracleConnection conn = DB.createConn();
            //OracleDataAdapter da = new OracleDataAdapter();
            //DataSet ds = new DataSet();
            //string strSQL = "";
        
            //try
            //{
            //    conn.Open();
            //    string j = Quality.SelectedValue.ToString();
            //    if (j == "0")
            //    {

            //        strSQL = "Select * from TQ_WASTE_DISTRIBUTE where LOGTIME = '" + strCurrentDate + "'and WASTETYPE is not null  order by WASTETYPE asc";
            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        da.Fill(ds, "TQ_WASTE_DISTRIBUTE");
            //        string strFileName = this.Server.MapPath("").ToString() + "\\WasteInfo1.rpt";
            //        rdt.Load(strFileName);

            //        rdt.SetDataSource(ds);
            //        //CRVTundishTempRate.ReportSource = rdt;
            //        //CRVTundishTempRate.DataBind();
            //    }
            //    else if (j == "1")
            //    {

            //        strSQL = "Select * from TQ_WASTE_DISTRIBUTE where LOGTIME = '" + strCurrentDate + "'and WASTETYPE is  null order by UnitID asc";
            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        da.Fill(ds, "TQ_WASTE_DISTRIBUTE");
            //        string strFileName = this.Server.MapPath("").ToString() + "\\Waste.rpt";
            //        rdt.Load(strFileName);

            //        rdt.SetDataSource(ds);
            //        //CRVTundishTempRate.ReportSource = rdt;
            //        //CRVTundishTempRate.DataBind();
                
            //    }
            //    else if (j == "3")
            //    {

            //        strSQL = "Select * from TQ_TUNDISH_TEMP_RATE where substr(LOGTIME,1,7) = '" + strCurrentDate1 + "' and unitid='S4' and TEAM <='71' order by LOGTIME asc,Team";
            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        da.Fill(ds, "TQ_TUNDISH_TEMP_RATE");
            //        ReportViewer1.Visible = true;
            //        ReportDataSource rds = new ReportDataSource("dsLF_TUNDISH_TEMP", ds.Tables[0]);
            //        ReportViewer1.LocalReport.DataSources.Clear();
            //        ReportViewer1.LocalReport.DataSources.Add(rds);
            //        ReportViewer1.LocalReport.Refresh();

            //        ds.Dispose();

            //    }
                
            //}
            //catch (Exception ee)
            //{
            //    string strMessage = ee.Message.ToString();
            //}
            //finally
            //{
            //    ds.Dispose();
            //    conn.Close();
            //}
        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        rdt.Dispose();
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
        if (newdate)
        {
            //CRVTundishTempRate.ResetReportPartNavigation();
            newdate = false;
        }
        string strCurrentDate1 = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString();
        string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();

        OracleConnection conn = DB.createConn();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        string strSQL = "";

        try
        {
            conn.Open();
            string j = Quality.SelectedValue.ToString();
            if (j == "0")
            {

                strSQL = "Select * from TQ_WASTE_DISTRIBUTE where LOGTIME = '" + strCurrentDate + "'and WASTETYPE is not null  order by WASTETYPE asc";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TQ_WASTE_DISTRIBUTE");
                string strFileName = this.Server.MapPath("").ToString() + "\\WasteInfo1.rpt";
                rdt.Load(strFileName);

                rdt.SetDataSource(ds);
                //CRVTundishTempRate.ReportSource = rdt;
                //CRVTundishTempRate.DataBind();
            }
            else if (j == "1")
            {

                strSQL = "Select * from TQ_WASTE_DISTRIBUTE where LOGTIME = '" + strCurrentDate + "'and WASTETYPE is  null order by UnitID asc";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TQ_WASTE_DISTRIBUTE");
                string strFileName = this.Server.MapPath("").ToString() + "\\Waste.rpt";
                rdt.Load(strFileName);

                rdt.SetDataSource(ds);
                //CRVTundishTempRate.ReportSource = rdt;
                //CRVTundishTempRate.DataBind();

            }
            else if (j == "3")
            {

                strSQL = "Select * from TQ_TUNDISH_TEMP_RATE where substr(LOGTIME,1,7) = '" + strCurrentDate1 + "' and unitid='S4' and TEAM <='71' order by LOGTIME asc,Team";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TQ_TUNDISH_TEMP_RATE");
                ReportViewer1.Visible = true;
                ReportDataSource rds = new ReportDataSource("dsLF_TUNDISH_TEMP", ds.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.Refresh();

                ds.Dispose();

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

