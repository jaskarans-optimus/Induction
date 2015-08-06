using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.Entity;
namespace BussinesLayer
{
    public static class StudentOperations
    {
        public static bool AddStudent(String name, String userName, String password)
        {
            return DataLayer.StudentOperations.AddStudent(name, userName, password);
        }
        public static List<Student> GetAllStudents()
        {
            List<DataLayer.Student> dbStudents = DataLayer.StudentOperations.GetAllStudents();
            List<DataLayer.IssueDetail> dbIssueDetails = DataLayer.StudentOperations.GetAllIssueDetails();
            List<BussinesLayer.Student> students = new List<Student>();
            SortedSet<string> bookSet = new SortedSet<string>();
            foreach (DataLayer.Student student in dbStudents)
            {
                Student tempStudent = new Student();
                tempStudent.Name = student.Name;
                tempStudent.UserName = student.UserName;
                  foreach (IssueDetail issue in dbIssueDetails)
                   {
                       if(student.UserName.CompareTo(issue.StudentUserName)==0)
                       bookSet.Add(issue.BookName);
                   }
                  foreach (string book in bookSet)
                  {
                      tempStudent.Books += book + " ";
                  }
                students.Add(tempStudent);
            }
            return students;

        }
    }
}
