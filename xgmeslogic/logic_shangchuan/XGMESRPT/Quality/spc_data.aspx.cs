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


public partial class Default2 : System.Web.UI.Page
{
    protected string date1;
    protected string date2;
    protected string year;
    protected string month;
    protected int day;
    protected string Endyear;
    protected string Endmonth;
    protected int Endday;
    protected System.Web.UI.WebControls.Button Button1;
    protected bool newdate;
      

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.IsPostBack)
        { 
            //记录页面使用次数
            DB.RecordPageUseCount("spc_Data");

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
            ////enddate
            //string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString() ;
            ////开始时间
            //string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString() + "-" + ddlStartDay.SelectedValue.ToString() ;
            //DateTime dtStart = Convert.ToDateTime(strCurrentDate1);
            //DateTime dtEnd = Convert.ToDateTime(strCurrentDate);
            //double dStoptime1 = Math.Round((dtEnd.ToOADate()), 0);
            //double dStoptime2 = Math.Round((dtStart.ToOADate()),0);
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
            //    OracleDataAdapter da = new OracleDataAdapter();
            //    string strSQL = "";

               

              


            //    try
            //    {
            //        conn.Open();
            //      //  strSQL = "Select * from spc_data where PRODUCTIONDATE> = " + dtStart + " and PRODUCTIONDATE<= " + dtEnd + "";

            //        strSQL = " select heatid,steelgradeindex,steelgrade,productiondate, case when anatype='CCM' and anaitem='TEMP' then  '中包温度'  ";
            //        strSQL += " when anatype='GL' and anaitem='C' then  '离站C'  when anaitem='Al2O3' then  '精炼渣Al2O3' when  anaitem='R' then  '精炼渣R'   ";
            //        strSQL += " when  anaitem='SOFTBLOW_TIME' then  '软吹时间'  when  anaitem='FEEDWIRE_TEMP' then  '软吹开始温度' when anatype='RH'  then  'RH离站C'  ";
            //        strSQL += " when anaitem='CASTINGTUNDISHWEIGHT' then  '中包开浇重量'  when anatype='GT' and anaitem='C' then  '终点C' when anatype='GT' and anaitem='P' then  '终点P'  ";
            //        strSQL += " when anatype='GL' and anaitem='P' then  '成品P'  when anatype='GG' and anaitem='C' then  '进站C' when anatype='GG' and anaitem='P' then  '进站P'  ";

            //        strSQL += " when anatype='LADLETEMP'  then  '大包温降'  when anatype='wire' and anaitem='Ca' then  '钙线喂入量' when anatype='C_ADD'  then  'C增量'  ";

            //        strSQL += " when  anaitem='CGL' then  '出钢量'  when anaitem='CGY' then  '出钢氧' end  as anaitem ,alarmtype,yuanyin,  ";
            //        strSQL += " gaijin,avgx,mr,sd,mse,insert_time,update_time,insert_operator,update_operator,ppk,cpk,unit,team  from spc_data  ";

            //        //if (Quality.SelectedValue.ToString() != "")
            //        //    strSQL += " and BOFID = '" + Quality.SelectedValue.ToString() + "'";
            //        strSQL += "  where to_char(PRODUCTIONDATE,'yyyy-MM-dd') >='" + strCurrentDate1 + "'";
            //        strSQL += "  and  to_char(PRODUCTIONDATE,'yyyy-MM-dd') <='" + strCurrentDate + "'";
            //        if (DropDownList2.Text != "")
            //        {
            //            if (DropDownList2.Text == "终点C")
            //            {
            //                strSQL += " and  anatype='GT' and anaitem='C' ";
            //            }
            //            if (DropDownList2.Text == "终点P")
            //            {
            //                strSQL += " and anatype='GT' and anaitem='P' ";
            //            }
            //            if (DropDownList2.Text == "进站C")
            //            {
            //                strSQL += " and anatype='GG' and anaitem='C' ";
            //            }
            //            if (DropDownList2.Text == "进站P")
            //            {
            //                strSQL += " and anatype='GG' and anaitem='P' ";
            //            }
            //            if (DropDownList2.Text == "成品P")
            //            {
            //                strSQL += " and anatype='GL' and anaitem='P' ";
            //            }
            //            if (DropDownList2.Text == "出钢量")
            //            {
            //                strSQL += " and  anaitem='CGL' ";
            //            }
            //            if (DropDownList2.Text == "出钢氧")
            //            {
            //                strSQL += " and anaitem='CGY' ";
            //            }
            //            if (DropDownList2.Text == "离站C")
            //            {
            //                strSQL += " and  anatype='GL' and anaitem='C' ";
            //            }
            //            if (DropDownList2.Text == "精炼渣Al2O3")
            //            {
            //                strSQL += " and  anaitem='Al2O3' ";
            //            }
            //            if (DropDownList2.Text == "精炼渣R")
            //            {
            //                strSQL += " and anaitem='R' ";
            //            }
            //            if (DropDownList2.Text == "软吹时间")
            //            {
            //                strSQL += "  and anaitem='SOFTBLOW_TIME' ";
            //            }
            //            if (DropDownList2.Text == "软吹开始温度")
            //            {
            //                strSQL += " and anaitem='FEEDWIRE_TEMP' ";
            //            }
            //            if (DropDownList2.Text == "大包温降")
            //            {
            //                strSQL += " and  anaitem='LADLETEMP' ";
            //            }
            //            if (DropDownList2.Text == "钙线喂入量")
            //            {
            //                strSQL += " and  anaitem='Ca' ";
            //            }
            //            if (DropDownList2.Text == "C增量")
            //            {
            //                strSQL += " and anaitem='C_ADD' ";
            //            }
            //            if (DropDownList2.Text == "RH离站C")
            //            {
            //                strSQL += " and anatype='RH' ";
            //            }
            //            if (DropDownList2.Text == "中包温度")
            //            {
            //                strSQL += " and anatype='CCM' and anaitem='TEMP' ";
            //            }
            //            if (DropDownList2.Text == "中包开浇重量")
            //            {
            //                strSQL += " and anatype='CCM' and anaitem='CASTINGTUNDISHWEIGHT' ";
            //            }

                    
            //        }

            //        //if (TeamDropDownList.SelectedValue.ToString() != "") anaitem='CASTINGTUNDISHWEIGHT' then  '中包开浇重量' 
            //        //    strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
                   
            //        strSQL += "  order by anaitem,HeatID";

            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        //dsBOF ds = new dsBOF();
            //       DataSet ds = new DataSet();
               
            //         da.Fill(ds, "spcdata");
            //         int count = ds.Tables[0].Rows.Count;


            //        ReportViewer1.Visible = true;
            //        //int count = ds.Tables[0].Rows.Count;
            //        ReportDataSource rds = new ReportDataSource("spc_SPC_DATA", ds.Tables[0]);
            //        ReportViewer1.LocalReport.DataSources.Clear();
            //        ReportViewer1.LocalReport.DataSources.Add(rds);
                 
            //        ReportViewer1.LocalReport.Refresh();

            //        ds.Dispose();
            //    }
            //    catch (Exception ee)
            //    {
            //        string strMessage = ee.Message.ToString();
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
        //enddate
        string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
        //开始时间
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
            OracleConnection conn = DB.createConn();
            OracleDataAdapter da = new OracleDataAdapter();
            string strSQL = "";






            try
            {
                conn.Open();
                //  strSQL = "Select * from spc_data where PRODUCTIONDATE> = " + dtStart + " and PRODUCTIONDATE<= " + dtEnd + "";

                strSQL = " select heatid,steelgradeindex,steelgrade,productiondate, case when anatype='CCM' and anaitem='TEMP' then  '中包温度'  ";
                strSQL += " when anatype='GL' and anaitem='C' then  '离站C'  when anaitem='Al2O3' then  '精炼渣Al2O3' when  anaitem='R' then  '精炼渣R'   ";
                strSQL += " when  anaitem='SOFTBLOW_TIME' then  '软吹时间'  when  anaitem='FEEDWIRE_TEMP' then  '软吹开始温度' when anatype='RH'  then  'RH离站C'  ";
                strSQL += " when anaitem='CASTINGTUNDISHWEIGHT' then  '中包开浇重量'  when anatype='GT' and anaitem='C' then  '终点C' when anatype='GT' and anaitem='P' then  '终点P'  ";
                strSQL += " when anatype='GL' and anaitem='P' then  '成品P'  when anatype='GG' and anaitem='C' then  '进站C' when anatype='GG' and anaitem='P' then  '进站P'  ";

                strSQL += " when anatype='LADLETEMP'  then  '大包温降'  when anatype='wire' and anaitem='Ca' then  '钙线喂入量' when anatype='C_ADD'  then  'C增量'  ";

                strSQL += " when  anaitem='CGL' then  '出钢量'  when anaitem='CGY' then  '出钢氧' end  as anaitem ,alarmtype,yuanyin,  ";
                strSQL += " gaijin,avgx,mr,sd,mse,insert_time,update_time,insert_operator,update_operator,ppk,cpk,unit,team  from spc_data  ";

                //if (Quality.SelectedValue.ToString() != "")
                //    strSQL += " and BOFID = '" + Quality.SelectedValue.ToString() + "'";
                strSQL += "  where to_char(PRODUCTIONDATE,'yyyy-MM-dd') >='" + strCurrentDate1 + "'";
                strSQL += "  and  to_char(PRODUCTIONDATE,'yyyy-MM-dd') <='" + strCurrentDate + "'";
                if (DropDownList2.Text != "")
                {
                    if (DropDownList2.Text == "终点C")
                    {
                        strSQL += " and  anatype='GT' and anaitem='C' ";
                    }
                    if (DropDownList2.Text == "终点P")
                    {
                        strSQL += " and anatype='GT' and anaitem='P' ";
                    }
                    if (DropDownList2.Text == "进站C")
                    {
                        strSQL += " and anatype='GG' and anaitem='C' ";
                    }
                    if (DropDownList2.Text == "进站P")
                    {
                        strSQL += " and anatype='GG' and anaitem='P' ";
                    }
                    if (DropDownList2.Text == "成品P")
                    {
                        strSQL += " and anatype='GL' and anaitem='P' ";
                    }
                    if (DropDownList2.Text == "出钢量")
                    {
                        strSQL += " and  anaitem='CGL' ";
                    }
                    if (DropDownList2.Text == "出钢氧")
                    {
                        strSQL += " and anaitem='CGY' ";
                    }
                    if (DropDownList2.Text == "离站C")
                    {
                        strSQL += " and  anatype='GL' and anaitem='C' ";
                    }
                    if (DropDownList2.Text == "精炼渣Al2O3")
                    {
                        strSQL += " and  anaitem='Al2O3' ";
                    }
                    if (DropDownList2.Text == "精炼渣R")
                    {
                        strSQL += " and anaitem='R' ";
                    }
                    if (DropDownList2.Text == "软吹时间")
                    {
                        strSQL += "  and anaitem='SOFTBLOW_TIME' ";
                    }
                    if (DropDownList2.Text == "软吹开始温度")
                    {
                        strSQL += " and anaitem='FEEDWIRE_TEMP' ";
                    }
                    if (DropDownList2.Text == "大包温降")
                    {
                        strSQL += " and  anaitem='LADLETEMP' ";
                    }
                    if (DropDownList2.Text == "钙线喂入量")
                    {
                        strSQL += " and  anaitem='Ca' ";
                    }
                    if (DropDownList2.Text == "C增量")
                    {
                        strSQL += " and anaitem='C_ADD' ";
                    }
                    if (DropDownList2.Text == "RH离站C")
                    {
                        strSQL += " and anatype='RH' ";
                    }
                    if (DropDownList2.Text == "中包温度")
                    {
                        strSQL += " and anatype='CCM' and anaitem='TEMP' ";
                    }
                    if (DropDownList2.Text == "中包开浇重量")
                    {
                        strSQL += " and anatype='CCM' and anaitem='CASTINGTUNDISHWEIGHT' ";
                    }


                }

                //if (TeamDropDownList.SelectedValue.ToString() != "") anaitem='CASTINGTUNDISHWEIGHT' then  '中包开浇重量' 
                //    strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";

                strSQL += "  order by anaitem,HeatID";

                da.SelectCommand = new OracleCommand(strSQL, conn);
                //dsBOF ds = new dsBOF();
                DataSet ds = new DataSet();

                da.Fill(ds, "spcdata");
                int count = ds.Tables[0].Rows.Count;


                ReportViewer1.Visible = true;
                //int count = ds.Tables[0].Rows.Count;
                ReportDataSource rds = new ReportDataSource("spc_SPC_DATA", ds.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);

                ReportViewer1.LocalReport.Refresh();

                ds.Dispose();
            }
            catch (Exception ee)
            {
                string strMessage = ee.Message.ToString();
            }
            finally
            {
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


    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDate(sender, e);
    }
    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        newdate = true;
        AddDate(sender, e);
    }
}
