using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class EditProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else
        {
            txtUsername.Text = (string)Session["username"];
            txtFirstName.Text = (string)Session["firstName"];
            txtLastName.Text = (string)Session["lastName"];
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
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if ((txtEmail.Text == "") && (txtAddress.Text == ""))
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET postal='" + txtPostalCode.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else if ((txtEmail.Text == "") && (txtPostalCode.Text == ""))
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET address='" + txtAddress.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else if ((txtAddress.Text == "") && (txtPostalCode.Text == ""))
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET email='" + txtEmail.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else if (txtEmail.Text == "")
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET address='" + txtAddress.Text.Trim() + "', postal='" + txtPostalCode.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        
        else if (txtAddress.Text == "")
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET email='" + txtEmail.Text.Trim() + "', postal='" + txtPostalCode.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else if (txtPostalCode.Text == "")
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET email='" + txtEmail.Text.Trim() + "', address='" + txtAddress.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else if ((txtEmail.Text != "") && (txtAddress.Text != "") && (txtPostalCode.Text != ""))
        {
            SqlConnection connDecline = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            connDecline.Open();
            string mySQL;

            mySQL = "UPDATE Member SET email='" + txtEmail.Text.Trim() + "', address='" + txtAddress.Text.Trim() + "', postal='" + txtPostalCode.Text.Trim() + "' WHERE memberID='" + Convert.ToInt32(Session["memberID"]) + "'";

            SqlCommand cmdUpdate = new SqlCommand(mySQL, connDecline);
            cmdUpdate.ExecuteNonQuery();
            connDecline.Close();
            Response.Redirect("UCP.aspx");
        }
        else
        {
            lblMessage.Text = "Update fail, please fill in at least 1 box";
        }
    }
}