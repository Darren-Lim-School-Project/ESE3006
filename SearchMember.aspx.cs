using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class SearchMember : System.Web.UI.Page
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
    protected void btnSearchMember_Click(object sender, EventArgs e)
    {
        if (txtSearchName.Text == "VIEW ALL")
        {
            SqlConnection connSearchMember = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter cmdSearchMember = new SqlDataAdapter("Select memberID as [Member ID], userName as Username, passWord as Password, firstName as [First Name], lastName as [Last Name], email as Email, gender as Gender, birthDate as Birthdate, address as Address, postal as [Postal Code], admin as Admin, lastLogin as [Last Login], theme as Theme FROM Member", connSearchMember);

            connSearchMember.Open();

            DataSet dsSearchMember = new DataSet();
            cmdSearchMember.Fill(dsSearchMember);
            gvFirstName.DataSource = dsSearchMember;
            gvFirstName.DataBind();

            connSearchMember.Close();
        }
        else
        {

            SqlConnection connSearchMember = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter cmdSearchMember = new SqlDataAdapter("Select memberID as [Member ID], userName as Username, passWord as Password, firstName as [First Name], lastName as [Last Name], email as Email, gender as Gender, birthDate as Birthdate, address as Address, postal as [Postal Code], admin as Admin, lastLogin as [Last Login], theme as Theme FROM Member WHERE firstName like '%" + txtSearchName.Text.Trim() + "%'", connSearchMember);

            connSearchMember.Open();

            DataSet dsSearchMember = new DataSet();
            cmdSearchMember.Fill(dsSearchMember);
            gvFirstName.DataSource = dsSearchMember;
            gvFirstName.DataBind();

            connSearchMember.Close();
        }


    }
    protected void btnSearchGender_Click(object sender, EventArgs e)
    {
        SqlConnection connSearchGender = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        SqlDataAdapter cmdSearchGender = new SqlDataAdapter("Select memberID as [Member ID], userName as Username, passWord as Password, firstName as [First Name], lastName as [Last Name], email as Email, gender as Gender, birthDate as Birthdate, address as Address, postal as [Postal Code], admin as Admin, lastLogin as [Last Login], theme as Theme FROM Member WHERE gender like '%" + ddlGender.SelectedValue + "%'", connSearchGender);

        connSearchGender.Open();

        DataSet dsSearchGender = new DataSet();
        cmdSearchGender.Fill(dsSearchGender);
        gvGender.DataSource = dsSearchGender;
        gvGender.DataBind();

        connSearchGender.Close();
    }
}