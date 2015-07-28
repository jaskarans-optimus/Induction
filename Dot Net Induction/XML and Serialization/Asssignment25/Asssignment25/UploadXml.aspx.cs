using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment25
{
    public partial class UploadXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuXml.HasFile)
            {
                String current = Request.PhysicalApplicationPath;
                current += Server.HtmlEncode(fuXml.FileName);
                fuXml.SaveAs(current);
                try
                {
                  List<Student> students=Utility.LoadStudentsFromXMLFile(current);
                  gvMca.DataSource = GetStudentWithMCA(students);
                  gvMca.DataBind();
                  gvDGrade.DataSource = GetStudentDGrade(students);
                  gvDGrade.DataBind();
                    
                   
                }
                catch (Exception exception)
                {
                    lblStatus.Text = "Error" + exception.Message;
                }
            }
            else
            {
                lblStatus.Text = "Enter Valid Path";
            }
        }
        private List<Student> GetStudentWithMCA(List<Student> students)
        {
            List<Student> McaStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Branch.CompareTo("MCA") == 0)
                {
                    McaStudents.Add(student);
                }
            }

            return McaStudents;
        }
        private List<Student> GetStudentDGrade(List<Student> students)
        {
            List<Student> Dstudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Grade.CompareTo("D") == 0)
                {
                    Dstudents.Add(student);
                }
            }
            return Dstudents;
        }
    }
}