using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class SearchEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else if (Convert.ToInt32(Session["admin"]) != 1)
        {
            Response.Redirect("InvalidAccess.aspx");
        }

        if (Page.IsPostBack == false)
        {
            SqlConnection connEvents = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter adapterEvents = new SqlDataAdapter("Select eventID,eventName,eventStartDate,eventEndDate,description,urlLink FROM Events WHERE verified=1", connEvents);

            connEvents.Open();
            DataSet dsEvents = new DataSet();
            adapterEvents.Fill(dsEvents);

            ddlEvents.DataSource = dsEvents;
            ddlEvents.DataTextField = "eventName";
            ddlEvents.DataValueField = "eventID";
            ddlEvents.DataBind();

            connEvents.Close();
        }
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

    protected void btnListAllEvent_Click(object sender, EventArgs e)
    {
            SqlConnection connSearchEvent = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter cmdSearchEvent = new SqlDataAdapter("SELECT Events.eventID as [Event ID], Events.memberID as [Member ID], Member.firstName as [Uploaded By], Events.eventName as [Event Name], Events.eventStartDate as [Event Start Date], Events.eventEndDate as [Event End Date], Events.description as [Description], Events.urlLink as [URL Link], Events.verified as Verified from Events as Events,Member as Member where verified = 1 AND Member.memberID = Events.memberID", connSearchEvent);

            connSearchEvent.Open();

            DataSet dsSearchEvent = new DataSet();
            cmdSearchEvent.Fill(dsSearchEvent);
            gvEvent.DataSource = dsSearchEvent;
            gvEvent.DataBind();

            connSearchEvent.Close();
    }
    protected void ddlEvents_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection connSDEvents = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        SqlDataAdapter adapS;

        string mySQL = "SELECT e.eventName as [Event Name], m.firstName as [Posted By], e.eventStartDate as [Event Start Date], e.eventEndDate as [Event End Date], e.description as Description, e.urlLink as [URL Link] from Events as e, Member as m where e.eventID = '" + ddlEvents.SelectedValue + "' AND m.memberID = '"+ ddlEvents.SelectedValue + "'";

        adapS = new SqlDataAdapter(mySQL, connSDEvents);

        connSDEvents.Open();

        DataSet dsSEvents = new DataSet();
        adapS.Fill(dsSEvents);
        gvEvent.DataSource = dsSEvents;
        gvEvent.DataBind();

        connSDEvents.Close();
    }
    protected void btnDisable_Click(object sender, EventArgs e)
    {
        SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        connDecline.Open();
        string mySQL;

        mySQL = "update Events set verified=2" + "where eventID ='" + ddlEvents.SelectedValue + "'";
        //mySQL = "update Events set verified='" + ddlApprove.SelectedValue + "'" + "where eventID ='" + ddlEvent.SelectedValue + "'";

        SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
        cmdUpdate.ExecuteNonQuery();
        connDecline.Close();
        Response.Redirect("DisableEvent.aspx");
    }
}