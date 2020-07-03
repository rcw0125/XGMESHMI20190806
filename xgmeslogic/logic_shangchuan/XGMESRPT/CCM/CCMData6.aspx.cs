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


public partial class CCM_CCMData6 : System.Web.UI.Page
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
            DB.RecordPageUseCount("CCM_CCMData6");

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
               
            //            string strSQL = "";// "Select * from TC_ORIGINALDATA_NO3ANDNO4 where LOGTIME='" + strCurrentDate + "'";
            //            strSQL += "            SELECT   logtime,                                                  ";
            //            strSQL += "     DECODE (team,                                                             ";
            //            strSQL += "             '1', '甲班',                                                      ";
            //            strSQL += "             '2', '乙班',                                                      ";
            //            strSQL += "             '3', '丙班',                                                      ";
            //            strSQL += "             '4', '丁班',                                                      ";
            //            strSQL += "             '-'                                                               ";
            //            strSQL += "            ) team,                                                            ";
            //            strSQL += "     DECODE (shift, '1', '夜班', '2', '白班', '3', '中班', '-') shift,CCMID ,  ";
            //            strSQL += "     log_per, headfurnace, tundish_1st_officer, tundish_2nd_officer,           ";
            //            strSQL += "     tundish_3rd_officer, tundish_4th_officer, ladle_operator,                 ";
            //            strSQL += "     steel_grade, block_size, LENGTH, heatid, castingno,TUNDISH_HEATCOUNT, ladleid,";
            //            strSQL += "     ladle_grade, steel_weight, temp,                                          ";
            //            strSQL += "     DECODE (steeltempupto, '0', '否', '1', '是', '-') steeltempupto,          ";
            //            strSQL += "     arrival_time, casting_start_time, casting_stop_time, off_ladle_time,      ";
            //            strSQL += "     remainweight, holdtime,                                                   ";
            //            strSQL += "     DECODE (autoflow, '0', '否', '1', '是', '-') autoflow,                    ";
            //            strSQL += "     unautoflow_reason,                                                        ";
            //            strSQL += "     DECODE (PROTECTION, '0', '否', '1', '是', '-') PROTECTION,                ";
            //            strSQL += "     unprotection_reason, flow_blowar_protectcasting, tundish_carid,           ";
            //            strSQL += "     tundishid, castingstarttime1, castingstoptime1, castingstarttime2,        ";
            //            strSQL += "     castingstoptime2, castingstarttime3, castingstoptime3,                    ";
            //            strSQL += "     castingstarttime4, castingstoptime4, tundishtemp5, tundishtemp10,         ";
            //            strSQL += "     tundishtemp15, tundishtemp20, tundishtemp25, tundishtemp30,               ";
            //            strSQL += "     tundishtemp35, ladlestoptemp,                                             ";
            //            strSQL += "     DECODE (tundishtempupto, '0', '否', '1', '是', '-') tundishtempupto,      ";
            //            strSQL += "     speed1st, speed2nd, speed3rd, speed4th,  speedchange,tundishweight, bottom_temp,       ";
            //            strSQL += "     wall_temp, thickness, plugbar_control, injectionbar_blowar,               ";
            //            strSQL += "     flow_blowar_plugbar_1st, flow_blowar_plugbar_2nd,                         ";
            //            strSQL += "     flow_blowar_plugbar_3rd, flow_blowar_plugbar_4th,                         ";
            //            strSQL += "     position_plugbar_1st, position_plugbar_2nd, position_plugbar_3rd,         ";
            //            strSQL += "     position_plugbar_4th, mold_elec_mix_current_1st,                          ";
            //            strSQL += "     mold_elec_mix_current_2nd, mold_elec_mix_current_3rd,                     ";
            //            strSQL += "     mold_elec_mix_current_4th, mold_elec_mix_freq_1st,                        ";
            //            strSQL += "     mold_elec_mix_freq_2nd, mold_elec_mix_freq_3rd,                           ";
            //            strSQL += "     mold_elec_mix_freq_4th, mold_direction_electmix1, mold_direction_electmix2,";
            //            strSQL += "     mold_direction_electmix3, mold_direction_electmix4,                       ";
            //            strSQL += "     end_elec_mix_current_1st, end_elec_mix_current_2nd,                       ";
            //            strSQL += "     end_elec_mix_current_3rd, end_elec_mix_current_4th,                       ";
            //            strSQL += "     end_elec_mix_freq_1st, end_elec_mix_freq_2nd, end_elec_mix_freq_3rd,      ";
            //            strSQL += "     end_elec_mix_freq_4th, end_direction_electmix1,end_direction_electmix2,   ";
            //            strSQL += "     end_direction_electmix3, end_direction_electmix4,cooling_meterno,         ";
            //            strSQL += "     flow_cooling_1st, flow_cooling_2nd, flow_cooling_3rd,                     ";
            //            strSQL += "     flow_cooling_4th, cooling_press_1st, cooling_press_2nd,                   ";
            //            strSQL += "     cooling_press_3rd, cooling_press_4th, flow_1st, flow_2nd, flow_3rd,       ";
            //            strSQL += "     flow_4th, in_temp, temp_out_mold_1st, temp_out_mold_2nd,                  ";
            //            strSQL += "     temp_out_mold_3rd, temp_out_mold_4th, temp_dif_mold_1st,                  ";
            //            strSQL += "     temp_dif_mold_2nd, temp_dif_mold_3rd, temp_dif_mold_4th,                  ";
            //            strSQL += "     oscillate_meterno, protect_dreg_fac, protect_dreg_type, batch_id,         ";
            //            strSQL += "     cover_type, cover_fac, cover_id, bloom_count, note ,CASTINGTUNDISHWEIGHT,allexcept,ACTPROTOCOL,PROTOCOL,bof_note,lf_note,WARD_DREGS_FAC,DRY_FLAP_FAC,TUNDISHTEMP2,TUNDISHTEMP40,TUNDISHTEMP45,TUNDISHTEMP50,TUNDISHTEMP55,TUNDISHTEMP60,TUNDISHTEMP65,TUNDISHTEMP70   ";
            //            strSQL += "     FROM xgwebrpt.tc_originaldata_no3andno4                                  ";
            //            strSQL += "     where LOGTIME >= '" + strCurrentDate1 + "'AND LOGTIME <= '" + strCurrentDate + "'　AND CCMID='S66'"　;
            //            if (TeamDropDownList.SelectedValue.ToString() != "")
            //                strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
            //              strSQL += "ORDER BY CCMID,casting_start_time";

            //            da.SelectCommand = new OracleCommand(strSQL, conn);
            //            CCMData34 ds = new CCMData34();
            //            da.Fill(ds, "TC_ORIGINALDATA_NO3ANDNO4");
            //            ReportViewer1.Visible = true;
            //            ReportDataSource rds = new ReportDataSource("CCMData34_TC_ORIGINALDATA_NO3ANDNO4", ds.Tables[0]);
            //            ReportViewer1.LocalReport.DataSources.Clear();
            //            ReportViewer1.LocalReport.DataSources.Add(rds);
            //            ReportViewer1.LocalReport.Refresh();
                   
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

                string strSQL = "";// "Select * from TC_ORIGINALDATA_NO3ANDNO4 where LOGTIME='" + strCurrentDate + "'";
                strSQL += "            SELECT   logtime,                                                  ";
                strSQL += "     DECODE (team,                                                             ";
                strSQL += "             '1', '甲班',                                                      ";
                strSQL += "             '2', '乙班',                                                      ";
                strSQL += "             '3', '丙班',                                                      ";
                strSQL += "             '4', '丁班',                                                      ";
                strSQL += "             '-'                                                               ";
                strSQL += "            ) team,                                                            ";
                strSQL += "     DECODE (shift, '1', '夜班', '2', '白班', '3', '中班', '-') shift,CCMID ,  ";
                strSQL += "     log_per, headfurnace, tundish_1st_officer, tundish_2nd_officer,           ";
                strSQL += "     tundish_3rd_officer, tundish_4th_officer, ladle_operator,                 ";
                strSQL += "     steel_grade, block_size, LENGTH, heatid, castingno,TUNDISH_HEATCOUNT, ladleid,";
                strSQL += "     ladle_grade, steel_weight, temp,                                          ";
                strSQL += "     DECODE (steeltempupto, '0', '否', '1', '是', '-') steeltempupto,          ";
                strSQL += "     arrival_time, casting_start_time, casting_stop_time, off_ladle_time,      ";
                strSQL += "     remainweight, holdtime,                                                   ";
                strSQL += "     DECODE (autoflow, '0', '否', '1', '是', '-') autoflow,                    ";
                strSQL += "     unautoflow_reason,                                                        ";
                strSQL += "     DECODE (PROTECTION, '0', '否', '1', '是', '-') PROTECTION,                ";
                strSQL += "     unprotection_reason, flow_blowar_protectcasting, tundish_carid,           ";
                strSQL += "     tundishid, castingstarttime1, castingstoptime1, castingstarttime2,        ";
                strSQL += "     castingstoptime2, castingstarttime3, castingstoptime3,                    ";
                strSQL += "     castingstarttime4, castingstoptime4, tundishtemp5, tundishtemp10,         ";
                strSQL += "     tundishtemp15, tundishtemp20, tundishtemp25, tundishtemp30,               ";
                strSQL += "     tundishtemp35, ladlestoptemp,                                             ";
                strSQL += "     DECODE (tundishtempupto, '0', '否', '1', '是', '-') tundishtempupto,      ";
                strSQL += "     speed1st, speed2nd, speed3rd, speed4th,  speedchange,tundishweight, bottom_temp,       ";
                strSQL += "     wall_temp, thickness, plugbar_control, injectionbar_blowar,               ";
                strSQL += "     flow_blowar_plugbar_1st, flow_blowar_plugbar_2nd,                         ";
                strSQL += "     flow_blowar_plugbar_3rd, flow_blowar_plugbar_4th,                         ";
                strSQL += "     position_plugbar_1st, position_plugbar_2nd, position_plugbar_3rd,         ";
                strSQL += "     position_plugbar_4th, mold_elec_mix_current_1st,                          ";
                strSQL += "     mold_elec_mix_current_2nd, mold_elec_mix_current_3rd,                     ";
                strSQL += "     mold_elec_mix_current_4th, mold_elec_mix_freq_1st,                        ";
                strSQL += "     mold_elec_mix_freq_2nd, mold_elec_mix_freq_3rd,                           ";
                strSQL += "     mold_elec_mix_freq_4th, mold_direction_electmix1, mold_direction_electmix2,";
                strSQL += "     mold_direction_electmix3, mold_direction_electmix4,                       ";
                strSQL += "     end_elec_mix_current_1st, end_elec_mix_current_2nd,                       ";
                strSQL += "     end_elec_mix_current_3rd, end_elec_mix_current_4th,                       ";
                strSQL += "     end_elec_mix_freq_1st, end_elec_mix_freq_2nd, end_elec_mix_freq_3rd,      ";
                strSQL += "     end_elec_mix_freq_4th, end_direction_electmix1,end_direction_electmix2,   ";
                strSQL += "     end_direction_electmix3, end_direction_electmix4,cooling_meterno,         ";
                strSQL += "     flow_cooling_1st, flow_cooling_2nd, flow_cooling_3rd,                     ";
                strSQL += "     flow_cooling_4th, cooling_press_1st, cooling_press_2nd,                   ";
                strSQL += "     cooling_press_3rd, cooling_press_4th, flow_1st, flow_2nd, flow_3rd,       ";
                strSQL += "     flow_4th, in_temp, temp_out_mold_1st, temp_out_mold_2nd,                  ";
                strSQL += "     temp_out_mold_3rd, temp_out_mold_4th, temp_dif_mold_1st,                  ";
                strSQL += "     temp_dif_mold_2nd, temp_dif_mold_3rd, temp_dif_mold_4th,                  ";
                strSQL += "     oscillate_meterno, protect_dreg_fac, protect_dreg_type, batch_id,         ";
                strSQL += "     cover_type, cover_fac, cover_id, bloom_count, note ,CASTINGTUNDISHWEIGHT,allexcept,ACTPROTOCOL,PROTOCOL,bof_note,lf_note,WARD_DREGS_FAC,DRY_FLAP_FAC,TUNDISHTEMP2,TUNDISHTEMP40,TUNDISHTEMP45,TUNDISHTEMP50,TUNDISHTEMP55,TUNDISHTEMP60,TUNDISHTEMP65,TUNDISHTEMP70,CAL_WEIGHT   ";
                strSQL += "     FROM xgwebrpt.tc_originaldata_no3andno4                                  ";
                strSQL += "     where LOGTIME >= '" + strCurrentDate1 + "'AND LOGTIME <= '" + strCurrentDate + "'　AND CCMID='S66'";
                if (TeamDropDownList.SelectedValue.ToString() != "")
                    strSQL += " and Team = '" + TeamDropDownList.SelectedValue.ToString() + "'";
                strSQL += "ORDER BY CCMID,casting_start_time";

                da.SelectCommand = new OracleCommand(strSQL, conn);
                CCMData34 ds = new CCMData34();
                da.Fill(ds, "TC_ORIGINALDATA_NO3ANDNO4");
                ReportViewer1.Visible = true;
                ReportDataSource rds = new ReportDataSource("CCMData34_TC_ORIGINALDATA_NO3ANDNO4", ds.Tables[0]);
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

