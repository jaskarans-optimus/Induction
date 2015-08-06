using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null||((bool)Session["AdminRights"])==false)
                Response.Redirect("Login.aspx");
            lblMsg.Text = "Welcome " + Session["UserName"];
            lblMsg.Style.Add("Color", "Blue");
            lblMsg.Style.Add("text-size", "50px");
        }
    }
}