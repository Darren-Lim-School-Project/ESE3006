using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UCP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else
        {
            btnLogout.Visible = true;
        }

        lblName.Text = ((string)Session["firstName"]) + " " + ((string)Session["lastName"]);

        if ((string)Session["lastLogin"] == "0")
        {
            lblTime.Text = "NEW MEMBER";
        } else {
            lblTime.Text = (string)Session["lastLogin"];
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Home.aspx");
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
    protected void btnDonateHistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("DonateHistory.aspx");
    }
}