using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesLayer;
namespace Library_Management_System
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.CompareTo("") == 0 || txtUserName.Text.CompareTo("") == 0 || txtPassword.Text.CompareTo("") == 0)
                lblStatus.Text = "Enter all the fields";
            else
            {
                try
                {
                    if (StudentOperations.AddStudent(txtName.Text, txtUserName.Text, txtPassword.Text))
                    {
                        lblStatus.Text = "Student Added";
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lblStatus.Text = "Student Not Added";
                    }
                }
                catch (Exception exception)
                {
                    lblStatus.Text = exception.Message;
                }
            }
        }
    }
}