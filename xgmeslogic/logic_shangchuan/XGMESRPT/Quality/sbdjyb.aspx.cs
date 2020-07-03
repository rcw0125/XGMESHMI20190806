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

public partial class sbdjyb : System.Web.UI.Page
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
            DB.RecordPageUseCount("sbdjyb");

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
                ddlStartYear.Items.Add(Year);
            }

            string CurrentDate = Convert.ToString(DateTime.Now.Month);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem Month in ddlStartMonth.Items)
            {
                if (Month.Text == CurrentDate)
                {
                    Month.Selected = true;
                    ddlStartMonth.Text = Month.Text;             
                    break;
                }
                else
                    Month.Selected = false;
            }

           
        }
        else
        {
           
        }
    }
   
    protected void btnQuery_Click(object sender, EventArgs e)
    {
       
        Page_Load(sender, e);
        string strCurrentDate1 = ddlStartYear.SelectedValue.ToString() + "-" + ddlStartMonth.SelectedValue.ToString();      
        OracleConnection conn = DB.createConn();
        OracleDataAdapter da = new OracleDataAdapter();
       
        DataSet ds = new DataSet();
        
        string strSQL = "";
       
        try
        {
            if (newdate)
            {

                newdate = false;
            }
            conn.Open();
            strSQL = "Select * from TS_sbdjyb where LOGTIME = '" + strCurrentDate1 + "'";
            if (!DropDownList1.SelectedItem.Text.Contains("请选择"))
            {
                strSQL += " and djdw='"+DropDownList1.SelectedItem.Text.Trim().Replace(" ","")+"'";
            }
            if (!DdlBz.SelectedItem.Text.Contains("请选择"))
            {
                strSQL += " and djbz='" + DdlBz.SelectedItem.Text.Trim().Replace(" ", "") + "'";
            }
            strSQL += " order by logtime,djdw,djbz,djlx,djlb,djzq";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            ds = new DataSet();
            da.Fill(ds, "sbdjyb");
            ReportViewer1.Visible = true;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.Reset();
            ReportDataSource rds = new ReportDataSource("ds_sbdj", ds.Tables[0]);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Quality\\sbdjyb.rdlc";
            ReportViewer1.LocalReport.Refresh();
            ds.Dispose();
            conn.Close();

           

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

    
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Page_Load(sender, e);
       
        OracleConnection conn = DB.createConn();
        OracleDataAdapter da = new OracleDataAdapter();     
        DataSet ds = new DataSet();
      
        string strSQL = "";

        try
        {
           
            conn.Open();
            strSQL = "Select name from TS_sbdj_bz where id = '" + DropDownList1.SelectedValue + "'";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            ds = new DataSet();
            da.Fill(ds, "sbdjbz");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DdlBz.Items.Clear();
                DdlBz.Items.Add("请选择班组");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DdlBz.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            
            }
            ds.Dispose();
            conn.Close();



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

