using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        if (Session["userName"]==null)
                                Response.Redirect("~/Default.aspx");
        }
       
        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Status.Text = "";
        }
        protected void RegisterMe_Click(object sender, EventArgs e)
        {
            if (Session["userName"].Equals("admin"))
            {
                if (UserCrud.InsertUser(UserID.Text, Pass.Text, Country.Text, Gender.Text))
                    Status.Text = "User Added";
                else
                    Status.Text = "User Add Failed";
            }
            else
                Status.Text = "You dont have Admin Priveleges";
        }
    }
}