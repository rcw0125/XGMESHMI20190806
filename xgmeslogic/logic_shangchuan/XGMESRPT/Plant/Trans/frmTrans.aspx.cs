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

public partial class Trans_frmTrans : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportViewer1.Visible = false;
        ReportViewer2.Visible = false;
        ReportViewer3.Visible = false;
        ReportViewer4.Visible = false;

    }

    

    
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //Page_Load(sender, e);
        string strHeatID = txtHeatID.Text.Trim();
        ReportViewer1.Visible = false;
        //ReportViewer2.Visible = false;
        //ReportViewer3.Visible = false;
        OracleConnection conn = DB.createConn();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            conn.Open();
            string strSQLBOF = "Select * from TS_ORIGINALDATA where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
            dsBOF ds = new dsBOF();
            da.Fill(ds, "TS_ORIGINALDATA");

            strSQLBOF = "Select * from TR_LF_ORIGINALDATA where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
            da.Fill(ds, "TR_LF_ORIGINALDATA");

            strSQLBOF = "Select * from TR_RH_ORIGINALDATA where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
            da.Fill(ds, "TR_RH_ORIGINALDATA");

            //1#CCM
            strSQLBOF = "Select * from TC_ORIGINALDATA_NO1ANDNO2 where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
            DataTable dtCCM1 = new DataTable();
            da.Fill(dtCCM1);

            //3#CCM
            strSQLBOF = "Select * from TC_ORIGINALDATA_NO3ANDNO4 where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
            DataTable dtCCM3 = new DataTable();
            da.Fill(dtCCM3);

            //5#CCM
            strSQLBOF = "Select * from TC_ORIGINALDATA_NO5 where HeatID='" + strHeatID + "'";
            da.SelectCommand = new OracleCommand(strSQLBOF, conn);
           //CCMData5  DataTable dtCCM5 = new DataTable();
           // da.Fill(dtCCM5);

            CCMData5 dsCCMData5 = new CCMData5();
            da.Fill(dsCCMData5, "TC_ORIGINALDATA_NO5");



            ReportViewer1.Visible = true;
            ReportViewer2.Visible = true;
            ReportViewer3.Visible = true;
            ReportViewer4.Visible = true;

            //ReportParameter rptParaA = new ReportParameter("rptParaA", "测试报表参数");
            //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { rptParaA });

            ReportDataSource rdsBOF = new ReportDataSource("dsBOF_TS_ORIGINALDATA", ds.Tables[0]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(rdsBOF);
            ReportViewer1.LocalReport.Refresh();

            ReportDataSource rdsLF = new ReportDataSource("dsLF_TR_LF_ORIGINALDATA", ds.Tables[1]);
            ReportViewer2.LocalReport.DataSources.Clear();
            ReportViewer2.LocalReport.DataSources.Add(rdsLF);
            ReportViewer2.LocalReport.Refresh();

            ReportDataSource rdsRH = new ReportDataSource("dsRH_TR_RH_ORIGINALDATA", ds.Tables[2]);
            ReportViewer3.LocalReport.DataSources.Clear();
            ReportViewer3.LocalReport.DataSources.Add(rdsRH);
            ReportViewer3.LocalReport.Refresh();

            if (dtCCM1.Rows.Count > 0)
            {
                ReportDataSource rdsCCM1 = new ReportDataSource("CCMData12_TC_ORIGINALDATA_NO1ANDNO2", dtCCM1);
                ReportViewer4.LocalReport.DataSources.Clear();
                ReportViewer4.LocalReport.DataSources.Add(rdsCCM1);
                ReportViewer4.LocalReport.Refresh();
            }

            if (dtCCM3.Rows.Count > 0)
            {
                ReportDataSource rdsCCM3 = new ReportDataSource("CCMData34_TC_ORIGINALDATA_NO3ANDNO4", dtCCM3);
                ReportViewer4.LocalReport.DataSources.Clear();
                ReportViewer4.LocalReport.DataSources.Add(rdsCCM3);
                ReportViewer4.LocalReport.Refresh();
            }

            if (dsCCMData5.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rdsCCM5 = new ReportDataSource("CCMData5_TC_ORIGINALDATA_NO5", dsCCMData5.Tables[0]);
               
                ReportViewer4.LocalReport.DataSources.Clear();
                ReportViewer4.LocalReport.DataSources.Add(rdsCCM5);
                ReportViewer4.LocalReport.Refresh();
            }
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
