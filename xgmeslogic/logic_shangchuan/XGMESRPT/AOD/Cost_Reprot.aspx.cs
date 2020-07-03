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
using CrystalDecisions.CrystalReports.Engine;
using System.Data.OracleClient;

public partial class BOF_Cost_Reprot : System.Web.UI.Page
{
    protected string date1;
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
            DB.RecordPageUseCount("BOF_Cost_Reprot");

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
                    //EndDay.Text = day.Text;
                    break;
                }
                else
                    day.Selected = false;
            }
            OracleConnection conn = DB.createConn();
            try
            {
                string strSQL = "";
                ddlSteelGrade.Items.Clear();
                ddlSteelGrade.Items.Add("");
                strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r  GROUP BY steelgrade ORDER BY steelgrade";
                OracleDataAdapter da = new OracleDataAdapter();

                conn.Open();
                DataSet ds = new DataSet();
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "cqa_steelgradeindex_r");
                for (int m = 0; m < ds.Tables[0].Rows.Count; m++)
                {
                    ddlSteelGrade.Items.Add(ds.Tables[0].Rows[m][0].ToString());
                }
                ds.Dispose();
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
        else
        {
           
        }

    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        rdt.Dispose();
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
        //Page_Load(sender, e);
        string strCurrentDate = ddlYear.SelectedValue.ToString() + '-' + ddlMonth.SelectedValue.ToString() + '-' + ddlDay.SelectedValue.ToString();

        //查询表名
        string strTableName = "";
        if (ddlYear.SelectedValue.ToString() != DateTime.Now.Year.ToString())
            strTableName = "TS_COST_HIS";
        else
            strTableName = "TS_COST";
        //成本中心
        string strCCMID = ddlCostCenter.SelectedValue.ToString();
        //钢种
        string strSteelgrade = ddlSteelGrade.SelectedValue.ToString();
        //价格类型
        string strPriceType = ddlPriceType.SelectedValue.ToString();
        //价格类型后缀
        string strPrice_YMN = "";
        if (strPriceType == "1")
            strPrice_YMN = "_Y";
        else if (strPriceType == "2")
            strPrice_YMN = "_M";
        else if (strPriceType == "3")
            strPrice_YMN = "_N";
        else
            return;
        OracleConnection conn = DB.createConn();
        DataSet ds = new DataSet();
        try
        {
            if (newdate)
            {
                newdate = false;
            }
            string strSQL = "";
            string strSQLJudge = "";//判断产量是否为空的查询语句
            double dOutput_Cur = 0;//本期产量
            double dOutput_Total = 0;//累计产量

            OracleDataAdapter da = new OracleDataAdapter();
            conn.Open();
         
            if (strCCMID == "" && strSteelgrade == "")
            {
                strSQLJudge = "SELECT SUM (output_cur) AS output_cur,                               ";                 
                strSQLJudge += "       SUM (output_total) AS output_total                           ";
                strSQLJudge += "  FROM (SELECT   output_cur, output_total                           ";
                strSQLJudge += "            FROM " + strTableName + "                               ";
                strSQLJudge += "           WHERE logtime = '" + strCurrentDate + "'                 ";
                strSQLJudge += "        GROUP BY ccmid, steelgrade, output_cur, output_total)       ";

                ds = new DataSet();
                da.SelectCommand = new OracleCommand(strSQLJudge, conn);
                da.Fill(ds, "Steel_Output");
                if (ds.Tables["Steel_Output"].Rows.Count > 0)
                {
                    dOutput_Cur = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_cur"].ToString()), 3);
                    dOutput_Total = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_total"].ToString()), 3);

                    if (dOutput_Cur > 0 && dOutput_Total > 0)
                    {
                        strSQL = "        SELECT   a.logtime, NULL AS ccmid, NULL AS steeltype, NULL AS steelgrade,                                                     ";
                        strSQL += "                 a.ELEMENT, a.ele_unit, a.cost_project, a.cost_project_lower,                                                        ";
                        strSQL += "                 " + dOutput_Cur + " as output_cur," + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,      ";
                        strSQL += "                 SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                                            ";
                        strSQL += "                 ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                                          ";
                        strSQL += "                        2                                                                                                            ";
                        strSQL += "                       ) AS price_total" + strPrice_YMN + ",                                                                         ";
                        strSQL += "                 ROUND (SUM (total_con_cur) / " + dOutput_Cur + " , 3) AS con_cur" + strPrice_YMN + ",                               ";
                        strSQL += "                 ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",                          ";
                        strSQL += "                 ROUND (price_cur" + strPrice_YMN + " * SUM (total_con_cur) / " + dOutput_Cur + " ,                                  ";
                        strSQL += "                        2                                                                                                            ";
                        strSQL += "                       ) AS unit_cost_cur" + strPrice_YMN + ",                                                                       ";
                        strSQL += "                 ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                                 ";
                        strSQL += "                        / SUM (total_con_total)                                                                                      ";
                        strSQL += "                        * SUM (total_con_total)                                                                                      ";
                        strSQL += "                        / " + dOutput_Total + ",                                                                                     ";
                        strSQL += "                        2                                                                                                            ";
                        strSQL += "                       ) AS unit_cost_total" + strPrice_YMN + ",                                                                     ";
                        strSQL += "                 SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                                     ";
                        strSQL += "                 SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                                  ";
                        strSQL += "            FROM " + strTableName + "  a                                                                                             ";
                        strSQL += "           WHERE a.logtime = '" + strCurrentDate + "'                                                                                ";
                        strSQL += "        GROUP BY a.logtime,                                                                                                          ";
                        strSQL += "                 a.ELEMENT,                                                                                                          ";
                        strSQL += "                 a.ele_unit,                                                                                                         ";
                        strSQL += "                 a.cost_project,                                                                                                     ";
                        strSQL += "                 a.cost_project_lower,                                                                                               ";
                        strSQL += "                 a.price_cur" + strPrice_YMN + "                                                                                     ";
                        strSQL += "        ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                                     ";
                    }
                    else if (dOutput_Cur <= 0 && dOutput_Total > 0)
                    {
                        strSQL = "        SELECT   a.logtime, NULL AS ccmid, NULL AS steeltype, NULL AS steelgrade,                                                     ";
                        strSQL += "                 a.ELEMENT, a.ele_unit, a.cost_project, a.cost_project_lower,                                                        ";
                        strSQL += "                 0 as output_cur," + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,                        ";
                        strSQL += "                 SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                                            ";
                        strSQL += "                 ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                                          ";
                        strSQL += "                        2                                                                                                            ";
                        strSQL += "                       ) AS price_total" + strPrice_YMN + ",                                                                         ";
                        strSQL += "                0 AS con_cur" + strPrice_YMN + ",                                                                                    ";
                        strSQL += "                 ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",                          ";
                        strSQL += "                 0 AS unit_cost_cur" + strPrice_YMN + ",                                                                             ";
                        strSQL += "                 ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                                 ";
                        strSQL += "                        / SUM (total_con_total)                                                                                      ";
                        strSQL += "                        * SUM (total_con_total)                                                                                      ";
                        strSQL += "                        / " + dOutput_Total + ",                                                                                     ";
                        strSQL += "                        2                                                                                                            ";
                        strSQL += "                       ) AS unit_cost_total" + strPrice_YMN + ",                                                                     ";
                        strSQL += "                 SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                                     ";
                        strSQL += "                 SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                                  ";
                        strSQL += "            FROM " + strTableName + "  a                                                                                             ";
                        strSQL += "                                                                                                                                     ";
                        strSQL += "           WHERE a.logtime = '" + strCurrentDate + "'                                                                                ";
                        strSQL += "        GROUP BY a.logtime,                                                                                                          ";
                        strSQL += "                 a.ELEMENT,                                                                                                          ";
                        strSQL += "                 a.ele_unit,                                                                                                         ";
                        strSQL += "                 a.cost_project,                                                                                                     ";
                        strSQL += "                 a.cost_project_lower,                                                                                               ";
                        strSQL += "                 a.price_cur" + strPrice_YMN + "                                                                                     ";
                        strSQL += "        ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                                     ";
                    }
                }
            }
            else if (strCCMID == "" && strSteelgrade != "")
            {
                strSQLJudge = "  SELECT SUM (output_cur) AS output_cur,                                                                ";
                strSQLJudge += "         SUM (output_total) AS output_total                                                            ";
                strSQLJudge += "    FROM (SELECT   ccmid, steelgrade, output_cur, output_total                                         ";
                strSQLJudge += "              FROM ts_cost                                                                             ";
                strSQLJudge += "             WHERE logtime = '" + strCurrentDate + "' AND steelgrade = '" + strSteelgrade + "'         ";
                strSQLJudge += "          GROUP BY ccmid, steelgrade, output_cur, output_total )                                       ";
                   
                ds = new DataSet();
                da.SelectCommand = new OracleCommand(strSQLJudge, conn);
                da.Fill(ds, "Steel_Output");
                if (ds.Tables["Steel_Output"].Rows.Count > 0)
                {
                    dOutput_Cur = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_cur"].ToString()), 3);
                    dOutput_Total = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_total"].ToString()), 3);
                    if (dOutput_Cur > 0 && dOutput_Total > 0)
                    {
                        strSQL += "      SELECT   a.logtime, NULL AS ccmid,NULL AS steeltype, '" + strSteelgrade + "' AS steelgrade, a.ELEMENT,         ";
                        strSQL += "               a.ele_unit, a.cost_project, a.cost_project_lower, " + dOutput_Cur + " as output_cur,                  ";
                        strSQL += "               " + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,                          ";
                        strSQL += "               SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                              ";
                        strSQL += "               ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                            ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS price_total" + strPrice_YMN + ",                                                           ";
                        strSQL += "               ROUND (SUM (total_con_cur) / " + dOutput_Cur + ", 3) AS con_cur" + strPrice_YMN + ",                  ";
                        strSQL += "               ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",            ";
                        strSQL += "               ROUND (price_cur" + strPrice_YMN + " * SUM (total_con_cur) / " + dOutput_Cur + ",                     ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_cur" + strPrice_YMN + ",                                                         ";
                        strSQL += "               ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                   ";
                        strSQL += "                      / SUM (total_con_total)                                                                        ";
                        strSQL += "                      * SUM (total_con_total)                                                                        ";
                        strSQL += "                      / " + dOutput_Total + ",                                                                       ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_total" + strPrice_YMN + ",                                                       ";
                        strSQL += "               SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                       ";
                        strSQL += "               SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                    ";
                        strSQL += "          FROM ts_cost a                                                                                             ";
                        strSQL += "         WHERE a.logtime = '" + strCurrentDate + "' AND A.steelgrade = '" + strSteelgrade + "'                       ";
                        strSQL += "      GROUP BY a.logtime,                                                                                            ";
                        strSQL += "               a.ELEMENT,                                                                                            ";
                        strSQL += "               a.ele_unit,                                                                                           ";
                        strSQL += "               a.cost_project,                                                                                       ";
                        strSQL += "               a.cost_project_lower,                                                                                 ";
                        strSQL += "               a.price_cur" + strPrice_YMN + "                                                                       ";
                        strSQL += "      ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                       ";
                    }
                    else if (dOutput_Cur <= 0 && dOutput_Total > 0)
                    {
                        strSQL += "      SELECT   a.logtime, NULL AS ccmid,NULL AS steeltype, '" + strSteelgrade + "' AS steelgrade, a.ELEMENT,         ";
                        strSQL += "               a.ele_unit, a.cost_project, a.cost_project_lower, 0 as output_cur,                                    ";
                        strSQL += "               " + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,                          ";
                        strSQL += "               SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                              ";
                        strSQL += "               ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                            ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS price_total" + strPrice_YMN + ",                                                           ";
                        strSQL += "               0 AS con_cur" + strPrice_YMN + ",                                                                     ";
                        strSQL += "               ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",            ";
                        strSQL += "               0 AS unit_cost_cur" + strPrice_YMN + ",                                                               ";
                        strSQL += "               ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                   ";
                        strSQL += "                      / SUM (total_con_total)                                                                        ";
                        strSQL += "                      * SUM (total_con_total)                                                                        ";
                        strSQL += "                      / " + dOutput_Total + ",                                                                       ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_total" + strPrice_YMN + ",                                                       ";
                        strSQL += "               SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                       ";
                        strSQL += "               SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                    ";
                        strSQL += "          FROM ts_cost a                                                                                             ";
                        strSQL += "         WHERE a.logtime = '" + strCurrentDate + "' AND A.steelgrade = '" + strSteelgrade + "'                       ";
                        strSQL += "      GROUP BY a.logtime,                                                                                            ";
                        strSQL += "               a.ELEMENT,                                                                                            ";
                        strSQL += "               a.ele_unit,                                                                                           ";
                        strSQL += "               a.cost_project,                                                                                       ";
                        strSQL += "               a.cost_project_lower,                                                                                 ";
                        strSQL += "               a.price_cur" + strPrice_YMN + "                                                                       ";
                        strSQL += "      ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                       ";
                    }
                }
            }
            else if (strCCMID != "" && strSteelgrade == "")
            {
                strSQLJudge = "     SELECT nvl(SUM (output_cur),0) AS output_cur,                                              ";
                strSQLJudge += "           nvl(SUM (output_total),0) AS output_total                                           ";
                strSQLJudge += "      FROM (SELECT   ccmid, steelgrade, output_cur, output_total                        ";
                strSQLJudge += "                FROM ts_cost                                                            ";
                strSQLJudge += "               WHERE logtime = '" + strCurrentDate + "' AND ccmid = '" + strCCMID + "'  ";
                strSQLJudge += "            GROUP BY ccmid, steelgrade, output_cur, output_total)                       ";

                ds = new DataSet();
                da.SelectCommand = new OracleCommand(strSQLJudge, conn);
                da.Fill(ds, "Steel_Output");
                if (ds.Tables["Steel_Output"].Rows.Count > 0)
                {
                    dOutput_Cur = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_cur"].ToString()), 3);
                    dOutput_Total = Math.Round(Convert.ToDouble(ds.Tables["Steel_Output"].Rows[0]["output_total"].ToString()), 3);
                   
                    if (dOutput_Cur > 0 && dOutput_Total > 0)
                    {
                        strSQL = "      SELECT   a.logtime, '" + strCCMID + "' AS ccmid, steeltype, null AS steelgrade, a.ELEMENT,                      ";
                        strSQL += "               a.ele_unit, a.cost_project, a.cost_project_lower, " + dOutput_Cur + " as output_cur,                  ";
                        strSQL += "               " + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,                          ";
                        strSQL += "               SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                              ";
                        strSQL += "               ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                            ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS price_total" + strPrice_YMN + ",                                                           ";
                        strSQL += "               ROUND (SUM (total_con_cur) / " + dOutput_Cur + ", 3) AS con_cur" + strPrice_YMN + ",                  ";
                        strSQL += "               ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",            ";
                        strSQL += "               ROUND (price_cur" + strPrice_YMN + " * SUM (total_con_cur) /  " + dOutput_Cur + ",                    ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_cur" + strPrice_YMN + ",                                                         ";
                        strSQL += "               ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                   ";
                        strSQL += "                      / SUM (total_con_total)                                                                        ";
                        strSQL += "                      * SUM (total_con_total)                                                                        ";
                        strSQL += "                      / " + dOutput_Total + ",                                                                       ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_total" + strPrice_YMN + ",                                                       ";
                        strSQL += "               SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                       ";
                        strSQL += "               SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                    ";
                        strSQL += "          FROM ts_cost a                                                                                             ";
                        strSQL += "         WHERE a.logtime = '" + strCurrentDate + "' AND A.ccmid = '" + strCCMID + "'                                 ";
                        strSQL += "      GROUP BY a.logtime,                                                                                            ";
                        strSQL += "               a.ELEMENT,                                                                                            ";
                        strSQL += "               a.ele_unit,                                                                                           ";
                        strSQL += "               a.cost_project,                                                                                       ";
                        strSQL += "               a.cost_project_lower,                                                                                 ";
                        strSQL += "               a.price_cur" + strPrice_YMN + ",                                                                      ";
                        strSQL += "               a.steeltype                                                                                           ";
                        strSQL += "      ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                       ";
                    }
                    else if (dOutput_Cur <= 0 && dOutput_Total > 0)
                    {
                        strSQL = "      SELECT   a.logtime, '" + strCCMID + "' AS ccmid, steeltype, null AS steelgrade, a.ELEMENT,                      ";
                        strSQL += "               a.ele_unit, a.cost_project, a.cost_project_lower, 0 as output_cur,                  ";
                        strSQL += "               " + dOutput_Total + " as output_total, SUM (total_con_cur) AS total_con_cur,                          ";
                        strSQL += "               SUM (total_con_total) AS total_con_total, price_cur" + strPrice_YMN + ",                              ";
                        strSQL += "               ROUND (SUM (total_cost_total" + strPrice_YMN + ") / SUM (total_con_total),                            ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS price_total" + strPrice_YMN + ",                                                           ";
                        strSQL += "               0 AS con_cur" + strPrice_YMN + ",                  ";
                        strSQL += "               ROUND (SUM (total_con_total) / " + dOutput_Total + ", 3) AS con_total" + strPrice_YMN + ",            ";
                        strSQL += "               0 AS unit_cost_cur" + strPrice_YMN + ",                                                         ";
                        strSQL += "               ROUND (  SUM (total_cost_total" + strPrice_YMN + ")                                                   ";
                        strSQL += "                      / SUM (total_con_total)                                                                        ";
                        strSQL += "                      * SUM (total_con_total)                                                                        ";
                        strSQL += "                      / " + dOutput_Total + ",                                                                       ";
                        strSQL += "                      2                                                                                              ";
                        strSQL += "                     ) AS unit_cost_total" + strPrice_YMN + ",                                                       ";
                        strSQL += "               SUM (total_cost_cur" + strPrice_YMN + ") AS total_cost_cur" + strPrice_YMN + ",                       ";
                        strSQL += "               SUM (total_cost_total" + strPrice_YMN + ") AS total_cost_total" + strPrice_YMN + "                    ";
                        strSQL += "          FROM ts_cost a                                                                                             ";
                        strSQL += "         WHERE a.logtime = '" + strCurrentDate + "' AND A.ccmid = '" + strCCMID + "'                                 ";
                        strSQL += "      GROUP BY a.logtime,                                                                                            ";
                        strSQL += "               a.ELEMENT,                                                                                            ";
                        strSQL += "               a.ele_unit,                                                                                           ";
                        strSQL += "               a.cost_project,                                                                                       ";
                        strSQL += "               a.cost_project_lower,                                                                                 ";
                        strSQL += "               a.price_cur" + strPrice_YMN + ",                                                                      ";
                        strSQL += "               a.steeltype                                                                                           ";
                        strSQL += "      ORDER BY a.cost_project, a.cost_project_lower, a.ELEMENT                                                       ";
                    }
                    else
                    {
                        strSQL += "Select * from " + strTableName + " where LOGTIME='" + strCurrentDate + "' ";
                        strSQL += " and CCMID = '" + strCCMID + "' and SteelGrade = '" + strSteelgrade + "' ";
                        strSQL += " order by COST_PROJECT,COST_PROJECT_LOWER,ELEMENT";
                    }
                }
            }
            else
            {
                strSQL += "Select * from " + strTableName + " where LOGTIME='" + strCurrentDate + "' ";
                strSQL += " and CCMID = '" + strCCMID + "' and SteelGrade = '" + strSteelgrade + "' ";
                strSQL += " order by COST_PROJECT,COST_PROJECT_LOWER,ELEMENT";
            }

            ds = new DataSet();
             if (strPriceType == "1")
            {
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TS_COST");
                rdt.Load(this.Server.MapPath("").ToString() + "\\Cost_Report_Y.rpt");

                //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperCsheet;

                rdt.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rdt;
                CrystalReportViewer1.DataBind();
                ds.Dispose();
            }
            else if (strPriceType == "2")
            {
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TS_COST");
                rdt.Load(this.Server.MapPath("").ToString() + "\\Cost_Report_M.rpt");

                //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperCsheet;

                rdt.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rdt;
                CrystalReportViewer1.DataBind();
                ds.Dispose();
            }
            else if (strPriceType == "3")
            {
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.Fill(ds, "TS_COST");
                rdt.Load(this.Server.MapPath("").ToString() + "\\Cost_Report_N.rpt");

                //rdt.PrintOptions.PrinterName = "Microsoft Office Document Image Writer";
                rdt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperCsheet;

                rdt.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rdt;
                CrystalReportViewer1.DataBind();
                ds.Dispose();
            }
            ds.Dispose();
        }
        catch (Exception ee)
        {
            Response.Write(ee.ToString());//"出错");
        }
        finally
        {
            conn.Close();
            ds.Dispose();
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
    //选择铸机获取对应钢种
    protected void ddlCostCenter_SelectedIndexChanged(object sender, EventArgs e)
    {
        OracleConnection conn = DB.createConn();
        try
        {
            string strSQL = "";
            ddlSteelGrade.Items.Clear();
            ddlSteelGrade.Items.Add("");
            //Modify begin by llj 2011-04-02 增加7#铸机，取消了1,2#铸机
            //if (ddlCostCenter.SelectedValue.ToString() == "S61" || ddlCostCenter.SelectedValue.ToString() == "S62")
            //    strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r where substr(steelgradeindex,1,1) = 'F' GROUP BY steelgrade ORDER BY steelgrade";
            //else 
            //Modify end
            if (ddlCostCenter.SelectedValue.ToString() == "S63" || ddlCostCenter.SelectedValue.ToString() == "S64")
                strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r where substr(steelgradeindex,1,1) = 'J' GROUP BY steelgrade ORDER BY steelgrade";
            else if (ddlCostCenter.SelectedValue.ToString() == "S65")
                strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r where substr(steelgradeindex,1,1) = 'P' GROUP BY steelgrade ORDER BY steelgrade";
            else
                strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r GROUP BY steelgrade ORDER BY steelgrade";
            OracleDataAdapter da = new OracleDataAdapter();

            conn.Open();
            DataSet ds = new DataSet();
            da.SelectCommand = new OracleCommand(strSQL, conn);
            da.Fill(ds, "cqa_steelgradeindex_r");
            for (int m = 0; m < ds.Tables[0].Rows.Count; m++)
            {
                ddlSteelGrade.Items.Add(ds.Tables[0].Rows[m][0].ToString());
            }
            ds.Dispose();
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

