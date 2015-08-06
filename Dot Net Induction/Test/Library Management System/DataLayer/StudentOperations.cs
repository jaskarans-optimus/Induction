using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLayer
{
    public static class StudentOperations
    {
        public static bool AddStudent(String name, String userName, String password)
        {
            Student student = new Student();
            student.Name = name;
            student.UserName = userName;
            student.Password = password;
            using (LibraryEntities entities = new LibraryEntities())
            {
                try
                {
                   
                    entities.Students.Add(student);
                    entities.SaveChanges();

                    return true;
                }
                catch (Exception exception)
                {
                    return false;
                }
            }
        }
        public static List<Student> GetAllStudents()
        {
            using (LibraryEntities entities = new LibraryEntities())
            {
              return  entities.Students.ToList<Student>();
            }
        }
        public static List<IssueDetail> GetAllIssueDetails()
        {
            using (LibraryEntities entities = new LibraryEntities())
            {
                return entities.IssueDetails.ToList<IssueDetail>();
            }
        }     
    }
}
