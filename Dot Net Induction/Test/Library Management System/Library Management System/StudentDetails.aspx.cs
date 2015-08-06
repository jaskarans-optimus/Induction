using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesLayer;
namespace Library_Management_System
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null && (bool)Session["AdminRights"] == true)
            {
                List<BussinesLayer.Student> students = BussinesLayer.StudentOperations.GetAllStudents();
                gvStudents.DataSource = students;
                gvStudents.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}