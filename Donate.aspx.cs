using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        if (Page.IsPostBack == false)
        {
            SqlConnection connEventSel = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter adapterEventSel = new SqlDataAdapter("Select eventID,eventName,eventStartDate,eventEndDate,description,urlLink FROM Events WHERE verified=1", connEventSel);

            connEventSel.Open();
            DataSet dsEventSel = new DataSet();
            adapterEventSel.Fill(dsEventSel);

            ddlEventSel.DataSource = dsEventSel;
            ddlEventSel.DataTextField = "eventName";
            ddlEventSel.DataValueField = "eventID";
            ddlEventSel.DataBind();

            connEventSel.Close();
        }

    }
    protected void ddlEventSel_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection connSel = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        SqlDataAdapter adapterSel;


        string mySQL = "SELECT e.eventName as [Event Name], m.firstName as [Posted By], e.eventStartDate as [Event Start Date], e.eventEndDate as [Event End Date], e.description as Description, e.urlLink as [URL Link] from Events as e, Member as m where e.eventID = '" + ddlEventSel.SelectedValue + "' AND m.memberID = '" + ddlEventSel.SelectedValue + "'";

        adapterSel = new SqlDataAdapter(mySQL, connSel);

        connSel.Open();

        DataSet dsSEventsa = new DataSet();
        adapterSel.Fill(dsSEventsa);
        gvEvent.DataSource = dsSEventsa;
        gvEvent.DataBind();

        connSel.Close();
    }
    protected void btnDonate_Click(object sender, EventArgs e)
    {
        SqlConnection connDonate = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        connDonate.Open();
        string mySQL;

        mySQL = "insert into Donation (eventID, memberID, amount) values('" + ddlEventSel.SelectedValue + "', '" + Convert.ToInt32(Session["memberID"]) + "' , '" + txtDonate.Text.Trim() + "')";

        SqlCommand cmdDonate = new SqlCommand (mySQL,connDonate);
        cmdDonate.ExecuteNonQuery();
        connDonate.Close();
        Response.Redirect("DonateComplete.aspx");
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