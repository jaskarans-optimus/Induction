using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment17
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetDetails_Click(object sender, EventArgs e)
        {
            if (Id.Text.CompareTo("") == 0)
            {
                Status.Text = "Enter the Id:";
            }
            else
            {
                try
                {
                    Student student = Student.GetStudent(Int32.Parse(Id.Text));
                    Name.Text = student.Name;
                    State.Text = student.State.ToString();
                    Stream.Text = student.Stream.ToString();
                    Age.Text = student.Age.ToString();

                }
                catch (Exception e1)
                {
                    Status.Text = "Error : " + e1.Message;
                }
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(Int32.Parse(Id.Text), Name.Text, Int32.Parse(State.Text), Int32.Parse(Stream.Text), Int32.Parse(Age.Text));
                student.UpdateStudent();
                Status.Text = "Student Updated";
            }
            catch (Exception exc)
            {

                Status.Text = "Error :" + exc.Message;
            }
        }
    }
}