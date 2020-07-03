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


public partial class CCM_CCMData12 : System.Web.UI.Page
{
    protected string date1;
    protected string date2;
    protected string year;
    protected string month;
    protected int day;
    protected string StartYear;
    protected string StartMonth;
    protected int    StartDay;
    protected bool newdate;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("CCM_CCMData12");

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
            string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
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

                //int iDay = dtEnd.

                OracleConnection conn = DB.createConn();
                OracleDataAdapter da = new OracleDataAdapter();
                try
                {
                    conn.Open();
                    string j = Quality.SelectedValue.ToString();
                    if (j == "")
                    {
                        string strSQL = "";// "Select * from TC_ORIGINALDATA_NO1ANDNO2 where LOGTIME='" + strCurrentDate + "' order by HeatID";
                        strSQL = " SELECT LOGTIME ,CCMID,decode(TEAM, '1', '甲班', '2', '乙班', '3', '丙班', '4', '丁班', '-') TEAM, decode(SHIFT, '1', '夜班', '2', '白班', '3', '中班', '-') SHIFT,";
                        strSQL += " LOG_PER, HEADFURNACE, TUNDISH_1ST_OFFICER, TUNDISH_2ND_OFFICER, TUNDISH_3RD_OFFICER, TUNDISH_4TH_OFFICER, LADLE_OPERATOR, PLAN_STEELGRADE, CHANGE_STEELGRADE, CHANGE_REASON, BLOCK_SIZE, LENGTH, HEATID, CASTINGNO,TUNDISH_HEATCOUNT, LADLEID, LADLE_GRADE, STEEL_WEIGHT, TEMP, ";
                        strSQL += " decode(STEELTEMPUPTO, '0', '否', '1', '是', '-') STEELTEMPUPTO,  ARRIVAL_TIME, CASTING_START_TIME ,  CASTING_STOP_TIME , OFF_LADLE_TIME ,  REMAINWEIGHT , HOLDTIME , decode(AUTOFLOW,'0', '否', '1', '是', '-') AUTOFLOW,  ";
                        strSQL += " UNAUTOFLOW_REASON ,  decode(PROTECTION, '0', '否', '1', '是', '-') PROTECTION , UNPROTECTION_REASON , FLOW_BLOWAR_PROTECTCASTING ,   TUNDISH_CARID , TUNDISHID ,  CASTINGSTARTTIME1 , CASTINGSTOPTIME1 ,CASTINGSTARTTIME2 , CASTINGSTOPTIME2 , ";
                        strSQL += " CASTINGSTARTTIME3 , CASTINGSTOPTIME3 ,CASTINGSTARTTIME4 , CASTINGSTOPTIME4 ,TUNDISHTEMP5 , TUNDISHTEMP10 ,TUNDISHTEMP15 , TUNDISHTEMP20 , TUNDISHTEMP25 , TUNDISHTEMP30 ,  TUNDISHTEMP35 , LADLESTOPTEMP , ";
                        strSQL += " decode(TUNDISHTEMPUPTO, '0', '否', '1', '是', '-') TUNDISHTEMPUPTO, SPEED1ST , SPEED2ND , SPEED3RD , SPEED4TH , LEVEL_MOLD, BOTTOM_TEMP, WALL_TEMP, THICKNESS, COOLING_METERNO, FLOW_1ST, FLOW_2ND, FLOW_3RD, FLOW_4TH, ";
                        strSQL += " FLOW_COOLING_1ST, FLOW_COOLING_2ND, FLOW_COOLING_3RD, FLOW_COOLING_4TH, IN_TEMP, TEMP_OUT_MOLD_1ST, TEMP_OUT_MOLD_2ND,TEMP_OUT_MOLD_3RD, TEMP_OUT_MOLD_4TH, TEMP_DIF_MOLD_1ST, TEMP_DIF_MOLD_2ND, TEMP_DIF_MOLD_3RD, TEMP_DIF_MOLD_4TH,   ";
                        strSQL += " OSCILLATE_METERNO, SMOOTH_BLOCK_1ST, BLOCK_LIFE_1ST, BLOCK_FAC_1ST, BLOCK_SIZE_1ST, BLOCK_REASON_1ST, SMOOTH_BLOCK_2ND, BLOCK_LIFE_2ND,  BLOCK_FAC_2ND, BLOCK_SIZE_2ND, BLOCK_REASON_2ND, SMOOTH_BLOCK_3RD, BLOCK_LIFE_3RD, BLOCK_FAC_3RD, BLOCK_SIZE_3RD, BLOCK_REASON_3RD,";
                        strSQL += " SMOOTH_BLOCK_4TH,BLOCK_LIFE_4TH, BLOCK_FAC_4TH, BLOCK_SIZE_4TH, BLOCK_REASON_4TH, WATERGAP_TIME_1ST, GAPLIFE_1ST,  GAPFACTORY_1ST, GAPTYPE_1ST, GAPREASON_1ST, WATERGAP_TIME_2ND, GAPLIFE_2ND, GAPFACTORY_2ND, GAPTYPE_2ND, GAPREASON_2ND,   ";
                        strSQL += " WATERGAP_TIME_3RD, GAPLIFE_3RD, GAPFACTORY_3RD, GAPTYPE_3RD, GAPREASON_3RD, WATERGAP_TIME_4TH, GAPLIFE_4TH, GAPFACTORY_4TH, GAPTYPE_4TH, GAPREASON_4TH, FLOCFLOW, PROTECT_DREG_TYPE, PROTECT_DREG_FAC, BATCH_ID, COVER_TYPE, COVER_FAC, COVER_ID, BLOOM_COUNT, NOTE ,ActProtocol,Protocol ";
                        strSQL += " FROM XGWEBRPT.TC_ORIGINALDATA_NO1ANDNO2 WHERE LOGTIME >=  '" + strCurrentDate1 + "'and LOGTIME < = '" + strCurrentDate + "' ";
                        if (TeamDropDownList.SelectedValue.ToString() != "")
                            strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
                        strSQL += "ORDER BY CCMID,casting_start_time";
                        da.SelectCommand = new OracleCommand(strSQL, conn);
                        CCMData12 ds = new CCMData12();
                        da.Fill(ds, "TC_ORIGINALDATA_NO1ANDNO2");

                        ReportViewer1.Visible = true;

                        ReportDataSource rds = new ReportDataSource("CCMData12_TC_ORIGINALDATA_NO1ANDNO2", ds.Tables[0]);
                        ReportViewer1.LocalReport.DataSources.Clear();
                        ReportViewer1.LocalReport.DataSources.Add(rds);
                        ReportViewer1.LocalReport.Refresh();
                    }
                    else
                    {
                        string strSQL = "";// "Select * from TC_ORIGINALDATA_NO1ANDNO2 where LOGTIME='" + strCurrentDate + "' order by HeatID";
                        strSQL = " SELECT LOGTIME ,CCMID,decode(TEAM, '1', '甲班', '2', '乙班', '3', '丙班', '4', '丁班', '-') TEAM, decode(SHIFT, '1', '夜班', '2', '白班', '3', '中班', '-') SHIFT,";
                        strSQL += " LOG_PER, HEADFURNACE, TUNDISH_1ST_OFFICER, TUNDISH_2ND_OFFICER, TUNDISH_3RD_OFFICER, TUNDISH_4TH_OFFICER, LADLE_OPERATOR, PLAN_STEELGRADE, CHANGE_STEELGRADE, CHANGE_REASON, BLOCK_SIZE, LENGTH, HEATID, CASTINGNO,TUNDISH_HEATCOUNT, LADLEID, LADLE_GRADE, STEEL_WEIGHT, TEMP, ";
                        strSQL += " decode(STEELTEMPUPTO, '0', '否', '1', '是', '-') STEELTEMPUPTO,  ARRIVAL_TIME, CASTING_START_TIME ,  CASTING_STOP_TIME , OFF_LADLE_TIME ,  REMAINWEIGHT , HOLDTIME , decode(AUTOFLOW,'0', '否', '1', '是', '-') AUTOFLOW,  ";
                        strSQL += " UNAUTOFLOW_REASON ,  decode(PROTECTION, '0', '否', '1', '是', '-') PROTECTION , UNPROTECTION_REASON , FLOW_BLOWAR_PROTECTCASTING ,   TUNDISH_CARID , TUNDISHID ,  CASTINGSTARTTIME1 , CASTINGSTOPTIME1 ,CASTINGSTARTTIME2 , CASTINGSTOPTIME2 , ";
                        strSQL += " CASTINGSTARTTIME3 , CASTINGSTOPTIME3 ,CASTINGSTARTTIME4 , CASTINGSTOPTIME4 ,TUNDISHTEMP5 , TUNDISHTEMP10 ,TUNDISHTEMP15 , TUNDISHTEMP20 , TUNDISHTEMP25 , TUNDISHTEMP30 ,  TUNDISHTEMP35 , LADLESTOPTEMP , ";
                        strSQL += " decode(TUNDISHTEMPUPTO, '0', '否', '1', '是', '-') TUNDISHTEMPUPTO, SPEED1ST , SPEED2ND , SPEED3RD , SPEED4TH , LEVEL_MOLD, BOTTOM_TEMP, WALL_TEMP, THICKNESS, COOLING_METERNO, FLOW_1ST, FLOW_2ND, FLOW_3RD, FLOW_4TH, ";
                        strSQL += " FLOW_COOLING_1ST, FLOW_COOLING_2ND, FLOW_COOLING_3RD, FLOW_COOLING_4TH, IN_TEMP, TEMP_OUT_MOLD_1ST, TEMP_OUT_MOLD_2ND,TEMP_OUT_MOLD_3RD, TEMP_OUT_MOLD_4TH, TEMP_DIF_MOLD_1ST, TEMP_DIF_MOLD_2ND, TEMP_DIF_MOLD_3RD, TEMP_DIF_MOLD_4TH,   ";
                        strSQL += " OSCILLATE_METERNO, SMOOTH_BLOCK_1ST, BLOCK_LIFE_1ST, BLOCK_FAC_1ST, BLOCK_SIZE_1ST, BLOCK_REASON_1ST, SMOOTH_BLOCK_2ND, BLOCK_LIFE_2ND,  BLOCK_FAC_2ND, BLOCK_SIZE_2ND, BLOCK_REASON_2ND, SMOOTH_BLOCK_3RD, BLOCK_LIFE_3RD, BLOCK_FAC_3RD, BLOCK_SIZE_3RD, BLOCK_REASON_3RD,";
                        strSQL += " SMOOTH_BLOCK_4TH,BLOCK_LIFE_4TH, BLOCK_FAC_4TH, BLOCK_SIZE_4TH, BLOCK_REASON_4TH, WATERGAP_TIME_1ST, GAPLIFE_1ST,  GAPFACTORY_1ST, GAPTYPE_1ST, GAPREASON_1ST, WATERGAP_TIME_2ND, GAPLIFE_2ND, GAPFACTORY_2ND, GAPTYPE_2ND, GAPREASON_2ND,   ";
                        strSQL += " WATERGAP_TIME_3RD, GAPLIFE_3RD, GAPFACTORY_3RD, GAPTYPE_3RD, GAPREASON_3RD, WATERGAP_TIME_4TH, GAPLIFE_4TH, GAPFACTORY_4TH, GAPTYPE_4TH, GAPREASON_4TH, FLOCFLOW, PROTECT_DREG_TYPE, PROTECT_DREG_FAC, BATCH_ID, COVER_TYPE, COVER_FAC, COVER_ID, BLOOM_COUNT, NOTE ";
                        strSQL += " FROM XGWEBRPT.TC_ORIGINALDATA_NO1ANDNO2 WHERE LOGTIME > = '" + strCurrentDate1 + "'and LOGTIME <=  '" + strCurrentDate + "'AND CCMID='" + Quality.SelectedValue + "'";
                        if (TeamDropDownList.SelectedValue.ToString() != "")
                            strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
                        strSQL += "ORDER BY CCMID,casting_start_time";
                        da.SelectCommand = new OracleCommand(strSQL, conn);
                        CCMData12 ds = new CCMData12();
                        da.Fill(ds, "TC_ORIGINALDATA_NO1ANDNO2");

                        ReportViewer1.Visible = true;

                        ReportDataSource rds = new ReportDataSource("CCMData12_TC_ORIGINALDATA_NO1ANDNO2", ds.Tables[0]);
                        ReportViewer1.LocalReport.DataSources.Clear();
                        ReportViewer1.LocalReport.DataSources.Add(rds);
                        ReportViewer1.LocalReport.Refresh();
                    }
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
    }
    //protected void Page_UnLoad(object sender, EventArgs e)
    //{
    //    if (rdt != null) rdt.Dispose();
    //}

    
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
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
}

