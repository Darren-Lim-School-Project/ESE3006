using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SecondMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var menu = Page.Master.FindControl("Menu1") as Menu;
        if ((string)Session["username"] == null)
        {
            Menu1.Items.Remove(Menu1.FindItem("ACP")); //The Value
            Menu1.Items.Remove(Menu1.FindItem("UCP")); //The Value
            Menu1.Items.Remove(Menu1.FindItem("Donate"));
        }
        else if (((string)Session["username"] != null) && (Convert.ToInt32(Session["admin"])) == 0)
        {
            if (menu != null)
            {
                Menu1.Items.Remove(Menu1.FindItem("ACP")); //The Value
                Menu1.Items.Remove(Menu1.FindItem("Register")); //The Value

                txtUsername.Visible = false;
                txtPassword.Visible = false;

                btnLogin.Visible = false;

                lblUsername.Visible = false;
                lblPassword.Visible = false;
                lblError.Visible = false;

                ddlThemes.Visible = true;
            }
        }
        else if (((string)Session["username"] != null) && (Convert.ToInt32(Session["admin"])) == 1)
        {
            if (menu != null)
            {
                Menu1.Items.Remove(Menu1.FindItem("Register")); //The Value

                txtUsername.Visible = false;
                txtPassword.Visible = false;

                btnLogin.Visible = false;

                lblUsername.Visible = false;
                lblPassword.Visible = false;
                lblError.Visible = false;

                ddlThemes.Visible = true;
            }
        }

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;" + "Initial Catalog=healthcare; user=user; password=Password_2013");
        conn.Open();

        SqlCommand login = new SqlCommand("SELECT memberID, username, password, admin, firstname, lastname, lastLogin, theme FROM Member WHERE username='" + txtUsername.Text.Trim() + "' AND password='" + txtPassword.Text.Trim() + "'", conn);

        SqlDataReader reader = login.ExecuteReader();
        if (reader.Read())
        {
            Session["memberID"] = reader["memberID"];
            Session["username"] = txtUsername.Text.Trim();
            Session["admin"] = Convert.ToInt32(reader["admin"]);
            Session["firstName"] = reader["firstName"];
            Session["lastName"] = reader["lastName"];
            Session["lastLogin"] = reader["lastLogin"];
            Session["theme"] = reader["theme"];

            SqlConnection connTime = new SqlConnection("Data Source=localhost;" + "Initial Catalog=healthcare; user=user; password=Password_2013");
            connTime.Open();
            SqlCommand timeStamp = new SqlCommand("UPDATE Member SET lastLogin='" + DateTime.Now.ToString("HH:mm:ss") + "' WHERE userName='" + txtUsername.Text.Trim() + "'", connTime);
            timeStamp.ExecuteNonQuery();
            connTime.Close();

            conn.Close();
            Response.Redirect("Home.aspx");
        }

        conn.Close();
    }
    protected void ddlThemes_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection connTheme = new SqlConnection("Data Source=localhost;" + "Initial Catalog=healthcare; user=user; password=Password_2013");
        connTheme.Open();
        SqlCommand timeStamp = new SqlCommand("UPDATE Member SET theme='" + ddlThemes.SelectedValue + "' WHERE userName='" + (string)Session["username"] + "'", connTheme);

        Session["theme"] = ddlThemes.SelectedValue;


        timeStamp.ExecuteNonQuery();
        connTheme.Close();
        Response.Redirect("Home.aspx");
    }
}
