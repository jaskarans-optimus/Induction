using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
namespace Assignment21
{
    public static class StudentDataHandler
    {
        public static bool AddStudent(Student student)
        {
    
                String sqlQuery = String.Format("INSERT INTO Student VALUES({0},'{1}',{2},{3},{4})", student.Id, student.Name, student.State, student.Stream, student.Age);
                String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;

                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteScalar();
                connection.Close();
                command.Dispose();
                connection.Dispose();
                return true;

 
        
            
        }
        public static Student GetStudent(int id)
        {
            String sqlQuery = String.Format("SELECT * FROM Student WHERE Id={0}",id);
            String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Student student=new Student();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    student.Id = Convert.ToInt32(dataReader["Id"]);
                    student.Name = dataReader["Name"].ToString();
                    student.State = Convert.ToInt32(dataReader["State"]);
                    student.Stream = Convert.ToInt32(dataReader["Streams"]);
                    student.Age = Convert.ToInt32(dataReader["Age"]);
                }
            }
            return student;
        }
        public static void UpdateStudent(Student student)
        {
            String sqlQuery = String.Format("Update Student SET Name='{0}',state={1},streams={2},age={3} WHERE Id={4} ",student.Name,student.State,student.Stream,student.Age,student.Id );
            String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteScalar();
        }
        public static List<Student> GetAllStudents(int streamID)
        {
            String sqlQuery = String.Format("Select * FROM Student WHERE Id={0}",streamID);
            String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            if (dataReader.HasRows)
            {
              
                Student student = new Student();
                while (dataReader.Read())
                {
                    student.Id = Convert.ToInt32(dataReader["Id"]);
                    student.Name = dataReader["Name"].ToString();
                    student.State = Convert.ToInt32(dataReader["State"]);
                    student.Stream = Convert.ToInt32(dataReader["Streams"]);
                    student.Age = Convert.ToInt32(dataReader["Age"]);
                    students.Add(student);
                }
            }
            return students;
        }
    }
}