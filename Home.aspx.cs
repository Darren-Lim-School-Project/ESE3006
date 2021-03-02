using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
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
    public static AjaxControlToolkit.Slide[] GetSlides(string contextKey)
    {
        AjaxControlToolkit.Slide[] slide = new AjaxControlToolkit.Slide[4];
        slide[0] = new AjaxControlToolkit.Slide("Images/5Child.jpg", "i", "");     // put in your own image file name 
        slide[1] = new AjaxControlToolkit.Slide("Images/Hope.jpeg", "ii", "");
        slide[2] = new AjaxControlToolkit.Slide("Images/ReduceChildMortality.jpg", "ii", "");
        return (slide);
    }
}