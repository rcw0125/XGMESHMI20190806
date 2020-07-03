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

public partial class BOF_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //2009-08-18 SUN
        Date.SelectedDate = DateTime.Now;
        //查询钢种，填加到ddlSteelGrade中
        OracleConnection conn = DB.createConn();
        try
        {
            OracleDataAdapter da = new OracleDataAdapter();
            
            conn.Open();
            DataSet ds = new DataSet();
            string strSQL = "SELECT   steelgrade FROM xgmes.cqa_steelgradeindex_r GROUP BY steelgrade ORDER BY steelgrade";
            da.SelectCommand = new OracleCommand(strSQL, conn);
            da.Fill(ds, "cqa_steelgradeindex_r");
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
            {
                ddlSteelGrade.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            ds.Dispose();
        }
        catch (Exception ee)
        {
            Response.Write(ee.ToString());//"出错");
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        Session["CostCenter"] = ddlCostCenter.SelectedValue;
        Session["ProType"] = ddlProType.SelectedValue;
        Session["SteelGrade"] = ddlSteelGrade.SelectedValue;
        Session["Material"] = txtMaterial.Text;
        Session["CostItem"] = ddlCostItem.SelectedValue;
        Session["Date"] = Date.SelectedDate.ToString("yyyy-MM-dd");

        Response.Write("<script>window.opener=null;window.close();</script>");
    }

}
