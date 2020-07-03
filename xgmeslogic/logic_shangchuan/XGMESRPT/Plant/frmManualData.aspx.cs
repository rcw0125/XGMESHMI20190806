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

public partial class Plant_frmManualData : System.Web.UI.Page
{
    protected string year = "";
    protected string month = "";
    protected int day;
    protected string strDate = "";
    protected int rsCount = 0;
    protected string strOutNum = "";
    protected string strCrossTotal = "";
    protected bool newdate;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("Plant_frmManualData");

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
        }
    }

    private bool JudgeData()
    {        
        OracleConnection conn = DB.createConn();
        
        try
        {
            conn.Open();
            string strSQL = "Select Count(*) From TP_DAILY_QA where LOGTIME = '" + strDate + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            rsCount = System.Convert.ToInt32(cmd.ExecuteScalar().ToString());//execute.scalar()返回首行首列
        }
        catch
        {
            Response.Write("出错!");
        }
        finally
        {
            conn.Close();
        }
        if (rsCount > 0)
            return true;
        else
            return false;
    }

    //保存
    protected void btnSaveData_Click(object sender, EventArgs e)
    {
        if (txtOutNum.Text == "" || txtCrossTotal.Text == "")
        {
            Response.Write("错误!保存信息不能为空");
            return;
        }
        year = ddlYear.Text;
        month = ddlMonth.Text;
        day = Convert.ToInt16(ddlDay.Text);
        strOutNum = txtOutNum.Text;
        strCrossTotal = txtCrossTotal.Text;

        strDate = year + "-" + month + "-" + day;

        //如果有当天数据,TP_DAILY_QA插入数据,否则TP_DAILY_QA_INPUT新增数据
        if (JudgeData())
        {
            InsertData();
            UpdateData();
        }
        else
            InsertData();
    }

    //往TP_DAILY_QA插入号外,跨号改判炉数字段
    private void UpdateData()
    {
        OracleConnection conn = DB.createConn();
        try
        {
            conn.Open();

            string strSQL = "update TP_DAILY_QA "
                          + "set OUT_OF_ID_D = " + strOutNum
                          + ",CROSS_COM_TOTAL_D = " + strCrossTotal
                          + " where LOGTIME='" + strDate + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            rsCount = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());

        }
        catch
        {
            Response.Write("出错!");
        }
        finally
        {
            conn.Close();
        }
        if (rsCount > 0)
        {
            this.Page.Visible = false;
        }
        else
            Response.Write("保存失败!");
        //调用存储过程计算月累
        try
        {
            //OracleCommand cmd = new OracleCommand("XGMES.PROC_TP_DAILY_QA", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //OracleParameter parameter = cmd.Parameters.Add("@vs_rptDate", OracleType.NVarChar, 10);
            //parameter.Value = strDate;

            //connection.Open();

            //SqlDataReader reader = salesCommand.ExecuteReader();

            conn.Open();
            string strSQL = "call xgmes.PROC_TP_DAILY_QA('" + strDate + "')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
        }
        catch { }
        conn.Close();
    }
    //往TP_DAILY_QA_INPUT新增号外,跨号改判炉数字段
    private void InsertData()
    {
        OracleConnection conn = DB.createConn();
        string strSQL = "";
        try
        {
            conn.Open();

            strSQL = "delete from TP_DAILY_QA_INPUT where LOGTIME = '" + strDate + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            strSQL = "insert into TP_DAILY_QA_INPUT(LOGTIME,OUT_OF_ID_D,CROSS_COM_TOTAL_D) values('"
                            + strDate + "'," + strOutNum + ", " + strCrossTotal + ")";

            cmd = new OracleCommand(strSQL, conn);
            rsCount = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
        }
        catch
        {
            Response.Write("出错!");
        }
        finally
        {
            conn.Close();
        }
        if (rsCount > 0)
        {
            this.Page.Visible = false;
        }

        else
            Response.Write("保存失败!");
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


        //for (int i = 1; i <= day; i++)
        //{
        //    string addday = Convert.ToString(i);
        //    if (addday.Length < 2)
        //        addday = "0" + addday;
        //}
    }
}
