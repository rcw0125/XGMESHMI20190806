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
using System.Windows.Forms;

public partial class Plant_MonthPlanInput : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //记录页面使用次数
            DB.RecordPageUseCount("Plant_MonthPlanInput");

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
        }
    }

    //保存
    protected void btnSaveData_Click(object sender, EventArgs e)
    {
        string strDate = ddlYear.Text.ToString() + "-" + ddlMonth.Text.ToString();
        OracleConnection conn = DB.createConn();

        conn.Open();
        string strSQL = "select count(*) From TP_PLANT_DATA_M where LOGTIME = '" + strDate + "'";
        OracleCommand cmd = new OracleCommand(strSQL, conn);
        int iResult = Convert.ToInt32(cmd.ExecuteOracleScalar().ToString());
        if (iResult > 0)
        {

        }

        strSQL = "Delete From TP_PLANT_DATA_M where LOGTIME = '" + strDate + "'";
        cmd = new OracleCommand(strSQL, conn);
        cmd.ExecuteNonQuery();

        strSQL = "insert into TP_PLANT_DATA_M(LOGTIME,F_STEEL,P_STEEL,J_STEEL,GREATETIME) "
                + "values ('" + strDate + "'," + txtFSteel.Text + "," + txtPSteel.Text + ","
                + txtJSteel.Text + ",'" + DateTime.Now.ToString() + "')";
        cmd = new OracleCommand(strSQL, conn);
        int rsCount = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
        if (rsCount > 0)
        {
            this.Page.Visible = false;
        }
        else
            Response.Write("保存失败!");
        conn.Close();
    }
}
