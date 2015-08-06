using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesLayer;
namespace Library_Management_System
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            if (Login1.UserName.CompareTo("") == 0 || Login1.Password.CompareTo("") == 0)
                e.Authenticated = false;
            else
            {
                try
                {
                    if (LoginOperations.AdminAuthentication(Login1.UserName, Login1.Password))
                    {
                        e.Authenticated = true;
                        Session["Username"] = Login1.UserName;
                        Session["AdminRights"] = true;
                        Response.Redirect("AdminHome.aspx");
                    }
                    else if (LoginOperations.StudentAuthentication(Login1.UserName, Login1.Password))
                    {
                        e.Authenticated = true;
                        Session["Username"] = Login1.UserName;
                        Session["AdminRights"] = false;
                        Response.Redirect("StudentHome.aspx");
                    }
                    else
                    {
                        e.Authenticated = false;
                        //lblStatus.Text = "Enter Valid UserName and Password";
                    }
                }
                catch (Exception execption)
                {
                    e.Authenticated = false;
                    //lblStatus.Text = "Enter Valid UserName and Password";
                }
            }
        }
    }
}