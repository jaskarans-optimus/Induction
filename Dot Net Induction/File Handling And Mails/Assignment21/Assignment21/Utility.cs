using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace Assignment21
{
    public static class Utility
    {
        /// <summary>
        /// Get the data in Student object and store into a List
        /// </summary>
        /// <param name="fileName">Contains Path of File on Server</param>
        /// <returns>Is the records are stored on Database</returns>
        public static bool LoadFromCSV(string fileName)
        {
            List<Student> students = new List<Student>();
            String[] lines = File.ReadAllLines(fileName);
          
            foreach(string line in lines)
            {
                Student student = new Student();
                String[] row=line.Split(',');
                student.Id=Int32.Parse(row[0]);
                student.Name=row[1];
                student.State=Int32.Parse(row[2]);
                student.Stream=Int32.Parse(row[3]);
                student.Age=Int32.Parse(row[4]);
                students.Add(student); 
            }
          return  Student.InsertStudents(students);
        }
    }
}