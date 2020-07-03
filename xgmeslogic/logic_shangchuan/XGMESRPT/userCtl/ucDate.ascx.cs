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

public partial class userCtl_ucDate : System.Web.UI.UserControl
{
    protected string year;
    protected string month;
    protected int day;
    protected string currentDay;

    public string Year
    {
        get
        {
            return this.ddlYear.Text;
        }
    }
    public string Month
    {
        get
        {
            return this.ddlMonth.Text;
        }
    }
    public string Day
    {
        get
        {
            return this.ddlDay.Text;
        }
    }
    public string CurrentDay
    {
        get
        {
            return this.currentDay;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int CurrentYear = Convert.ToInt32(DateTime.Now.Year);
            int i;
            for (i = 2006; i <= CurrentYear; i++)
            {
                ListItem Year = new ListItem();
                Year.Text = Convert.ToString(i);
                Year.Value = Convert.ToString(i);
                if (i == CurrentYear) Year.Selected = true;
                else Year.Selected = false;
                ddlYear.Items.Add(Year);
            }

            string CurrentDate = Convert.ToString(DateTime.Now.Month);
            if (CurrentDate.Length == 1) CurrentDate = "0" + CurrentDate;
            foreach (ListItem li in ddlMonth.Items)
            {
                if (li.Text == CurrentDate)
                    li.Selected = true;
                else
                    li.Selected = false;
            }
            AddDate(sender, e);

            currentDay = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
        }
        else
        {
            currentDay = ddlYear.SelectedValue.ToString() + "-" + ddlMonth.SelectedValue.ToString() + "-" + ddlDay.SelectedValue.ToString();
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
        if (nowday.Length == 1) nowday = "0" + nowday;
        foreach (ListItem li in ddlDay.Items)
        {
            if (li.Text == nowday)
                li.Selected = true;
            else
                li.Selected = false;
        }
    }
}
