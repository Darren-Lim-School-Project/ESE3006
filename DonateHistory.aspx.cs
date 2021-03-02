using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DonateHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        if (Page.IsPostBack == false)
        {
            SqlConnection connEventd = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter adapterEventd = new SqlDataAdapter("Select e.eventName as [Event Name], d.amount as Amount FROM Donation as d, Events as e where d.memberID = '" + Convert.ToInt32(Session["memberID"]) + "' AND e.eventID = d.eventID", connEventd);

            connEventd.Open();
            DataSet dsDEvents = new DataSet();
            adapterEventd.Fill(dsDEvents);
            gvDonation.DataSource = dsDEvents;
            gvDonation.DataBind();

            connEventd.Close();
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
}