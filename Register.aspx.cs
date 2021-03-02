using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        SqlConnection connRegister = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");
        connRegister.Open();
        string mySQL;

        mySQL="INSERT INTO Member(userName, passWord, firstName, lastName, email, gender, birthDate, address, postal, admin) VALUES (@userName, @passWord, @firstName, @lastName, @email, @gender, @birthDate, @address, @postal, 0)";

        SqlCommand cmdRegister = new SqlCommand(mySQL, connRegister);


        cmdRegister.Parameters.AddWithValue("@userName", txtUsername.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@passWord", txtPassword.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@gender", rbGender.SelectedValue);
        cmdRegister.Parameters.AddWithValue("@birthDate", txtCalendar.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
        cmdRegister.Parameters.AddWithValue("@postal", txtPostalCode.Text.Trim());

        cmdRegister.ExecuteNonQuery();
        connRegister.Close();

        Response.Redirect("RegisterSuccess.aspx");
    }
    protected void cldBirthDate_SelectionChanged(object sender, EventArgs e)
    {
        txtCalendar.Text = cldBirthDate.SelectedDate.ToShortDateString();
    }
    protected void txtCalendar_TextChanged(object sender, EventArgs e)
    {

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