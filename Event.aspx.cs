using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SqlConnection connEvents = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

            SqlDataAdapter adapterEvents = new SqlDataAdapter("Select eventName as [Event Name], eventStartDate as [Event Start Date], eventEndDate as [Event End Date], description as Description,urlLink as [URL Link] FROM Events WHERE verified=1", connEvents);

            connEvents.Open();
            DataSet dsSEvents = new DataSet();
            adapterEvents.Fill(dsSEvents);
            GridView1.DataSource = dsSEvents;
            GridView1.DataBind();

            connEvents.Close();
        }
    }
    [System.Web.Services.WebMethod, System.Web.Script.Services.ScriptMethod]
    public static List<string> GetNameList(string prefixText, int count)
    {
        List<string> names = null;
        names = GetNames();

        int index = -1;
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase))
            {
                index = i;
                break;
            }
        }
        if (index == -1)
            return new List<string>();

        List<string> nameList = new List<string>();
        for (int i = index; i < (index + count); i++)
        {
            if (i >= names.Count)
                break;
            if (!names[i].StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase))
                break;

            nameList.Add(names[i]);
        }

        return nameList;
    }

    private static List<string> GetNames()
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost;" + "Initial Catalog = healthcare; user=user; password=Password_2013");

        SqlCommand cmd = new SqlCommand("Select eventName From Events WHERE verified=1 " + "ORDER BY eventName",conn);

        List<string> names = new List<string>();

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
            names.Add((string)dr["eventName"]);

        dr.Close();
        conn.Close();

        return names;
    }

    protected void btnGi_Click(object sender, EventArgs e)
    {
     
        SqlConnection connEventss = new SqlConnection("Data Source=localhost; Initial Catalog=healthcare; user=user; password=Password_2013");

        SqlDataAdapter adapterEventss = new SqlDataAdapter("Select eventName as [Event Name], eventStartDate as [Event Start Date], eventEndDate as [Event End Date], description as Description, urlLink as [URL Link] FROM Events WHERE verified=1 AND eventName='"+txtSearch.Text+"'", connEventss);

        
        connEventss.Open();
        DataSet dsSEventss = new DataSet();
        adapterEventss.Fill(dsSEventss);
        GridView1.DataSource = dsSEventss;
        GridView1.DataBind();

        connEventss.Close();

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

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static string[] GetCompletionList(string prefixText, int count, string contextKey)
    {
        return default(string[]);
    }
}