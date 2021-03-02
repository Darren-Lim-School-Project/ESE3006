using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class EventStatus : System.Web.UI.Page
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
            SqlConnection connEventsa = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");
            SqlConnection check = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            check.Open();

            SqlDataAdapter adapterEventsa = new SqlDataAdapter("Select * FROM Events WHERE verified=0", connEventsa);
            SqlCommand login = new SqlCommand("Select * FROM Events WHERE verified=0", check);

            SqlDataReader reader = login.ExecuteReader();
            if (reader.Read())
            {
                gvEvent.Visible = true;
                ddlApprove.Visible = true;
                btnSubmitEV.Visible = true;
                ddlEvent.Visible = true;
            }
            else
            {
                lblMessage.Text = "Currently no event awaiting to be confirmed.";
            }
            check.Close();

            connEventsa.Open();
            DataSet dsEventsa = new DataSet();
            adapterEventsa.Fill(dsEventsa);

            ddlEvent.DataSource = dsEventsa;
            ddlEvent.DataTextField = "eventName";
            ddlEvent.DataValueField = "eventID";
            ddlEvent.DataBind();

            connEventsa.Close();
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
    protected void btnSubmitEV_Click(object sender, EventArgs e)
    {
        string confirmValue = Request.Form["confirm_value"];

        if (confirmValue == "Yes")
        {
            if (ddlApprove.SelectedValue == "1")
            {
                //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);

                SqlConnection connEV = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

                connEV.Open();
                string mySQL;

                mySQL = "update Events set verified='" + ddlApprove.SelectedValue + "'" + "where eventID ='" + ddlEvent.SelectedValue + "'";

                SqlCommand cmdUpdate = new SqlCommand(mySQL, connEV);
                cmdUpdate.ExecuteNonQuery();
                connEV.Close();
                Response.Redirect("ACP.aspx");
                //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
            }
            else if (ddlApprove.SelectedValue == "0")
            {
                SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

                connDecline.Open();
                string mySQL;

                mySQL = "DELETE FROM Events where eventID ='" + ddlEvent.SelectedValue + "'";

                SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
                cmdUpdate.ExecuteNonQuery();
                connDecline.Close();
                Response.Redirect("ACP.aspx");
            }
        }
        else
        {

        }
    }
    protected void ddlEvent_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection connSDEventsa = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        SqlDataAdapter adapSa;


        //string mySQL = "SELECT eventID as [Event ID], memberID as [Member ID], eventName as [Event Name], eventStartDate as [Event Start Date], eventEndDate as [Event End Date], description as [Description], urlLink as [URL Link], verified as Verified from Events where eventID = '" + ddlEvent.SelectedValue + "' AND verified=0";
        string mySQL = "SELECT Events.eventID as [Event ID], Events.memberID as [Member ID], Member.firstName as [Uploaded By], Events.eventName as [Event Name], Events.eventStartDate as [Event Start Date], Events.eventEndDate as [Event End Date], Events.description as [Description], Events.urlLink as [URL Link], Events.verified as Verified from Events as Events,Member as Member where eventID = '" + ddlEvent.SelectedValue + "' AND verified=0 AND Member.memberID = Events.memberID";

        adapSa = new SqlDataAdapter(mySQL, connSDEventsa);

        connSDEventsa.Open();

        DataSet dsSEventsa = new DataSet();
        adapSa.Fill(dsSEventsa);
        gvEvent.DataSource = dsSEventsa;
        gvEvent.DataBind();

        connSDEventsa.Close();
    }
}