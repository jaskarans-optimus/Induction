using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
namespace Assignment26
{
    public static class StudentDataHandler
    {
        public static bool AddStudent(Student student)
        {

            String sqlQuery = String.Format("INSERT INTO Student VALUES({0},'{1}','{2}','{3}','{4}')", student.Id, student.Name, student.Grade, student.Branch, student.State);
            String conString = ConfigurationManager.ConnectionStrings["CollegeDB"].ConnectionString;

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteScalar();
            connection.Close();
            command.Dispose();
            connection.Dispose();
            return true;


        }
    }
}