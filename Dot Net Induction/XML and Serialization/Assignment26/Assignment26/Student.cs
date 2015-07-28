using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment26
{
    public class Student
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _grade;

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        private string _branch;

        public string Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }


        public static bool InsertStudents(List<Student> students)
        {
            try
            {
                foreach (Student student in students)
                {
                    StudentDataHandler.AddStudent(student);
                }
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
        
    }
}