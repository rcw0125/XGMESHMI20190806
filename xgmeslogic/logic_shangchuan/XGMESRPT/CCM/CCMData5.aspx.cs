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


public partial class CCM_CCMData5 : System.Web.UI.Page
{
    protected string date1;
    protected string date2;
    protected string year;
    protected string month;
    protected int day;
    protected string StartYear;
    protected string StartMonth;
    protected int StartDay;
    protected bool newdate;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("CCM_CCMData5");

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
            //string strCurrentDate = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
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
            //    OracleDataAdapter da = new OracleDataAdapter();

            //    try
            //    {
                    
            //        conn.Open();
            //        string strSQL = "";// "Select * from TC_ORIGINALDATA_NO5 where LOGTIME='" + strCurrentDate + "'";

            //        strSQL += "    SELECT logtime,                                                       ";
            //        strSQL += "    DECODE (team,                                                         ";
            //        strSQL += "            '1', '甲班',                                                  ";
            //        strSQL += "            '2', '乙班',                                                  ";
            //        strSQL += "            '3', '丙班',                                                  ";
            //        strSQL += "            '4', '丁班',                                                  ";
            //        strSQL += "            '-'                                                           ";
            //        strSQL += "           ) team,                                                        ";
            //        strSQL += "    DECODE (shift, '1', '夜班', '2', '白班', '3', '中班', '-') shift,CCMID,";
            //        strSQL += "    log_per, headfurnace, castingno, steel_grade, heatid, block_size,     ";
            //        strSQL += "    ladleid, ladle_grade, steel_weight, temp, TUNDISH_HEATCOUNT,           ";
            //        strSQL += "    DECODE (steeltempupto, '0', '否', '1', '是', '-') steeltempupto,      ";
            //        strSQL += "    arrival_time, casting_start_time, casting_stop_time, remainweight,    ";
            //        strSQL += "    holdtime, DECODE (autoflow, '0', '否', '1', '是', '-') autoflow,      ";
            //        strSQL += "    unautoflow_reason,                                                    ";
            //        strSQL += "    DECODE (PROTECTION, '0', '否', '1', '是', '-') PROTECTION,            ";
            //        strSQL += "    unprotection_reason, FLOW_BLOWAR_PROTECTCASTING,FLOW_BLOWAR_PLUGBAR_1ST ,FLOW_BLOWAR_PLUGBAR_2ND,FLOW_BLOWAR_PLUGBAR_3RD ,FLOW_BLOWAR_PLUGBAR_4TH , off_ladle_time, tundish_carid, tundishid,        ";
            //        strSQL += "    fender_slag_usage_case, thickness, bottom_temp, wall_temp,            ";
            //        strSQL += "    castingstarttime1, castingstoptime1, castingstarttime2,               ";
            //        strSQL += "    castingstoptime2, castingstarttime3, castingstoptime3,                ";
            //        strSQL += "    castingstarttime4, castingstoptime4, tundishtemp5, tundishtemp10,     ";
            //        strSQL += "    tundishtemp15, tundishtemp20, tundishtemp25, tundishtemp30,           ";
            //        strSQL += "    tundishtemp35, tundishtemp40, tundishtemp45, ladlestoptemp,           ";
            //        strSQL += "    DECODE (tundishtempupto, '0', '否', '1', '是', '-') tundishtempupto,  ";
            //        strSQL += "    speed1st, speed2nd, speed3rd, speed4th, speedchange, steelweight,     ";
            //        strSQL += "    tundish_1st_officer, tundish_2nd_officer, tundish_3rd_officer,        ";
            //        strSQL += "    tundish_4th_officer, ladle_operator, control_operator,                ";
            //        strSQL += "    elec_mix_current_1st, elec_mix_current_2nd, elec_mix_current_3rd,     ";
            //        strSQL += "    elec_mix_current_4th, elec_mix_freq_1st, elec_mix_freq_2nd,           ";
            //        strSQL += "    elec_mix_freq_3rd, elec_mix_freq_4th, direction_electmix1,            ";
            //        strSQL += "    direction_electmix2,direction_electmix3,direction_electmix4,          ";
            //        strSQL += "    cooling_meterno, temp_in_cooling, cooling_press, cooling_exception,   ";
            //        strSQL += "    in_temp,IN_TEMP_1, temp_dif_mold1,temp_dif_mold2,temp_dif_mold3,temp_dif_mold4, ";
            //        strSQL += "    flow_1st, flow_2nd, flow_3rd, flow_4th,                      ";
            //        strSQL += "    soft_press_flag1, soft_press_flag2,soft_press_flag3,soft_press_flag4, ";
            //        strSQL += "    oscillate_meterno, protect_dreg_type,                                 ";
            //        strSQL += "    protect_dreg_fac, batch_id, cover_type, cover_fac,cover_ID, LENGTH, bloom_count,";
            //        strSQL += "    reason_holt_casting, note ,CASTINGTUNDISHWEIGHT ,EXCEPT ,ActProtocol,Protocol,bof_note,lf_note,rh_note,WARD_DREGS_FAC,DRY_FLAP_FAC ,TUNDISHTEMP2                            ";
            //        strSQL += "    FROM tc_originaldata_no5   where LOGTIME>='" + strCurrentDate1 + "'AND LOGTIME<='" + strCurrentDate + "'";
            //        if (TeamDropDownList.SelectedValue.ToString() != "")
            //            strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
            //        strSQL += "order by CCMID,casting_start_time";
            //        da.SelectCommand = new OracleCommand(strSQL, conn);
            //        CCMData5 ds = new CCMData5();
            //        da.Fill(ds, "TC_ORIGINALDATA_NO5");

            //        ReportViewer1.Visible = true;

            //        ReportDataSource rds = new ReportDataSource("CCMData5_TC_ORIGINALDATA_NO5", ds.Tables[0]);
            //        ReportViewer1.LocalReport.DataSources.Clear();
            //        ReportViewer1.LocalReport.DataSources.Add(rds);
            //        ReportViewer1.LocalReport.Refresh();
                   
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
    //protected void Page_UnLoad(object sender, EventArgs e)
    //{
    //    if (rdt != null) rdt.Dispose();
    //}
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Page_Load(sender, e);
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
            OracleConnection conn = DB.createConn();
            OracleDataAdapter da = new OracleDataAdapter();

            try
            {

                conn.Open();
                string strSQL = "";// "Select * from TC_ORIGINALDATA_NO5 where LOGTIME='" + strCurrentDate + "'";

                strSQL += "    SELECT logtime,                                                       ";
                strSQL += "    DECODE (team,                                                         ";
                strSQL += "            '1', '甲班',                                                  ";
                strSQL += "            '2', '乙班',                                                  ";
                strSQL += "            '3', '丙班',                                                  ";
                strSQL += "            '4', '丁班',                                                  ";
                strSQL += "            '-'                                                           ";
                strSQL += "           ) team,                                                        ";
                strSQL += "    DECODE (shift, '1', '夜班', '2', '白班', '3', '中班', '-') shift,CCMID,";
                strSQL += "    log_per, headfurnace, castingno, steel_grade, heatid, block_size,     ";
                strSQL += "    ladleid, ladle_grade, steel_weight, temp, TUNDISH_HEATCOUNT,           ";
                strSQL += "    DECODE (steeltempupto, '0', '否', '1', '是', '-') steeltempupto,      ";
                strSQL += "    arrival_time, casting_start_time, casting_stop_time, remainweight,    ";
                strSQL += "    holdtime, DECODE (autoflow, '0', '否', '1', '是', '-') autoflow,      ";
                strSQL += "    unautoflow_reason,                                                    ";
                strSQL += "    DECODE (PROTECTION, '0', '否', '1', '是', '-') PROTECTION,            ";
                strSQL += "    unprotection_reason, FLOW_BLOWAR_PROTECTCASTING,FLOW_BLOWAR_PLUGBAR_1ST ,FLOW_BLOWAR_PLUGBAR_2ND,FLOW_BLOWAR_PLUGBAR_3RD ,FLOW_BLOWAR_PLUGBAR_4TH , off_ladle_time, tundish_carid, tundishid,        ";
                strSQL += "    fender_slag_usage_case, thickness, bottom_temp, wall_temp,            ";
                strSQL += "    castingstarttime1, castingstoptime1, castingstarttime2,               ";
                strSQL += "    castingstoptime2, castingstarttime3, castingstoptime3,                ";
                strSQL += "    castingstarttime4, castingstoptime4, tundishtemp5, tundishtemp10,     ";
                strSQL += "    tundishtemp15, tundishtemp20, tundishtemp25, tundishtemp30,           ";
                strSQL += "    tundishtemp35, tundishtemp40, tundishtemp45, ladlestoptemp,           ";
                strSQL += "    DECODE (tundishtempupto, '0', '否', '1', '是', '-') tundishtempupto,  ";
                strSQL += "    speed1st, speed2nd, speed3rd, speed4th, speedchange, steelweight,     ";
                strSQL += "    tundish_1st_officer, tundish_2nd_officer, tundish_3rd_officer,        ";
                strSQL += "    tundish_4th_officer, ladle_operator, control_operator,                ";
                strSQL += "    elec_mix_current_1st, elec_mix_current_2nd, elec_mix_current_3rd,     ";
                strSQL += "    elec_mix_current_4th, elec_mix_freq_1st, elec_mix_freq_2nd,           ";
                strSQL += "    elec_mix_freq_3rd, elec_mix_freq_4th, direction_electmix1,            ";
                strSQL += "    direction_electmix2,direction_electmix3,direction_electmix4,          ";
                strSQL += "    cooling_meterno, temp_in_cooling, cooling_press, cooling_exception,   ";
                strSQL += "    in_temp,IN_TEMP_1, temp_dif_mold1,temp_dif_mold2,temp_dif_mold3,temp_dif_mold4, ";
                strSQL += "    flow_1st, flow_2nd, flow_3rd, flow_4th,                      ";
                strSQL += "    soft_press_flag1, soft_press_flag2,soft_press_flag3,soft_press_flag4, ";
                strSQL += "    oscillate_meterno, protect_dreg_type,                                 ";
                strSQL += "    protect_dreg_fac, batch_id, cover_type, cover_fac,cover_ID, LENGTH, bloom_count,";
                strSQL += "    reason_holt_casting, note ,CASTINGTUNDISHWEIGHT ,EXCEPT ,ActProtocol,Protocol,bof_note,lf_note,rh_note,WARD_DREGS_FAC,DRY_FLAP_FAC ,TUNDISHTEMP2 ,CAL_WEIGHT, WATERSPEED1,WATERSPEED2,WATERSPEED3,WATERSPEED4,            ";
                strSQL += "    BEFORE_CASTING_TUNDISH_TEMP,BEFORE_CASTING_SHUIKOU_TEMP1,BEFORE_CASTING_SHUIKOU_TEMP2,BEFORE_CASTING_SHUIKOU_TEMP3,BEFORE_CASTING_SHUIKOU_TEMP4   ";
                strSQL += "    FROM tc_originaldata_no5   where LOGTIME>='" + strCurrentDate1 + "'AND LOGTIME<='" + strCurrentDate + "'";
                if (TeamDropDownList.SelectedValue.ToString() != "")
                    strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
                strSQL += "order by CCMID,casting_start_time";
                da.SelectCommand = new OracleCommand(strSQL, conn);
                CCMData5 ds = new CCMData5();
                da.Fill(ds, "TC_ORIGINALDATA_NO5");

                ReportViewer1.Visible = true;

                ReportDataSource rds = new ReportDataSource("CCMData5_TC_ORIGINALDATA_NO5", ds.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.Refresh();

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

