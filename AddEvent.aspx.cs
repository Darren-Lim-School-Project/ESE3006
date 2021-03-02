using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        SqlConnection connSEvents = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        connSEvents.Open();
        string mySQL;
        //mySQL = "insert into Events (eventName,eventStartDate,eventEndDate,description,urlLink,verified) values('" + txtEventName.Text.Trim() + "','" + Convert.ToDateTime(cldEventStartDate.SelectedDate) + "','" + Convert.ToDateTime(cldEventEndDate.SelectedDate)
        //    + "','" + txtDescription.Text.Trim() + "','" + txtURL.Text.Trim() + "',0)";

        mySQL = "insert into Events (memberID, eventName,eventStartDate,eventEndDate,description,urlLink,verified) values('" + Convert.ToInt32(Session["memberID"]) + "', '" + txtEventName.Text.Trim() + "','" + txtEventStartDate.Text.Trim() + "','" + txtEventEndDate.Text.Trim()
           + "','" + txtDescription.Text.Trim() + "','" + txtURL.Text.Trim() + "',0)";

        SqlCommand cmdSubmit = new SqlCommand(mySQL, connSEvents);
        cmdSubmit.ExecuteNonQuery();
        connSEvents.Close();
        Response.Redirect("EventSuccess.aspx");

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        txtEventStartDate.Text = cldEventStartDate.SelectedDate.ToShortDateString();

    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {

        txtEventEndDate.Text = cldEventEndDate.SelectedDate.ToShortDateString();

    }

    void Page_PreInit(object sender, EventArgs e)
    {
        if ((Convert.ToInt32(Session["theme"])) == 0)
        {
            MasterPageFile = "~/MasterPage.master";
        }
        else if ((Convert.ToInt32(Session["theme"])) == 1)
        {
            MasterPageFile = "~/SecondMasterPage.master";
        }
    }
}