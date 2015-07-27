using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment17
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
        
        public bool AddStudent()
        {
            if (StudentDataHandler.AddStudent(this))
            {
                return true;
            }
            return false;
        }
        public static Student GetStudent(int id)
        {
            return   StudentDataHandler.GetStudent(id);
        }
        public void UpdateStudent()
        {
            StudentDataHandler.UpdateStudent(this);
        }
    }
}