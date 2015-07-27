using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment17
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if (Id.Text.CompareTo("") == 0 || Name.Text.CompareTo("") == 0 || State.Text.CompareTo("") == 0 || Stream.Text.CompareTo("") == 0 || Age.Text.CompareTo("") == 0)
                Status.Text = "Enter all the details";
            else
            {
                try
                {
                    Student student = new Student(Convert.ToInt32(Id.Text), Name.Text, Convert.ToInt32(Stream.Text), Convert.ToInt32(State.Text), Convert.ToInt32(Age.Text));
                    if (student.AddStudent())
                        Status.Text = "Student Added";
                    else
                        Status.Text = "Student Not Added";
                }
                catch (Exception exc)
                {
                    Status.Text = "Error Message : " + exc.Message;
                }
            }
        }

   
    }
}