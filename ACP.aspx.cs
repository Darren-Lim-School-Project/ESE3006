using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ACP : System.Web.UI.Page
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

    protected void btnEventStatus_Click(object sender, EventArgs e)
    {
        Response.Redirect("EventStatus.aspx");
    }
    protected void btnSearchMember_Click(object sender, EventArgs e)
    {
        Response.Redirect("SearchMember.aspx");
    }
    protected void btnSearchEvent_Click(object sender, EventArgs e)
    {
        Response.Redirect("DisableEvent.aspx");
    }
}


