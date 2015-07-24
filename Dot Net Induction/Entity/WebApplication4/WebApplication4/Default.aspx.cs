using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Status.Text = "";
        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (UserCrud.Authenticate(Login1.UserName, Login1.Password))
            {
                Response.Redirect("~/Home.aspx");
                Session["userName"] = Login1.UserName;
                Status.Text = "";
                e.Authenticated = true;
            }
            else
            {
                Status.Text = "Login Failed";
            }
        }


    }
}