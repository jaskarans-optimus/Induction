using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"]==null)
                Response.Redirect("~/Default.aspx");

            welcome.Text = "WELCOME" + Session["userName"];
        }

    }
}