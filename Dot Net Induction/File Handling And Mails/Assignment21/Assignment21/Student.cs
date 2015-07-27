using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment21
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
        private int  _state;

        public int  State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int _stream;

        public int Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Student()
        {

        }

        public Student(int id,string name,int state ,int stream ,int age)
        {
            this.Id = id;
            this.Name = name;
            this.State = state;
            this.Stream = stream;
            this.Age = age;
        }
        /// <summary>
        /// Passes the Student List to the StudentDataHandler class to store it in Database
        /// </summary>
        /// <param name="students">List Of Students</param>
        /// <returns>Are records stored</returns>
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