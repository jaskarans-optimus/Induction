using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void RegisterMe_Click(object sender, EventArgs e)
        {
            if (UserCrud.InsertUser(UserID.Text, Pass.Text, Country.Text, Gender.Text))
                Response.Redirect("~/Default.aspx");
            else
                Status.Text = "Registeration failed";
        }
    }
}