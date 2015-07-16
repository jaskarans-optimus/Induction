using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Student
    {
        private string _name;
        private string _guardiansName;
        private string _address;
        private int _age;
        private char _sex;
        private DateTime _dateOfBirth;
        private string _mobileNo;
        public Student()
        {

        }
        public Student(string name,string guardiansName,string address,int age,char sex,DateTime dateOfBirth,string mobileNo)
        {
            this.Name = name;
            this.GuardiansName = guardiansName;
            this.Address = address;
            this.Age = age;
            this.Sex = sex;
            this.DateOfBirth = dateOfBirth;
            this.MobileNo = mobileNo;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string GuardiansName
        {
            get
            {
                return _guardiansName;
            }
            set
            {
                _guardiansName = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public char Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex=value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        public string MobileNo
        {
            get
            {
                return _mobileNo;
            }
            set
            {
                _mobileNo = value;
            }

        }
        public override string ToString()
        {
            return "Name:"+Name+"\tGuardian's Name: "+GuardiansName+"\nAge: "+Age+"\tSex: "+Sex+"\nDate Of Birth: "+DateOfBirth+"\tAddress: "+Address+"\nMobile: "+MobileNo;
        }
        static void Main(string[] args)
        {
            SchoolStudent schoolStudent = new SchoolStudent("Navan", "Nirmaan", "A-5,Rajouri Garden,New Delhi",16,'M', new DateTime(1992,11,13), "97114760564",21,10,2000f,new[]{60,80,66,77,79},172,200,"Sarvodya Vidhalaya");
            
            Console.WriteLine(schoolStudent);
            Console.WriteLine("Check Minimum Attendance:"+schoolStudent.checkMinAttendance());
            Console.WriteLine("Result:"+schoolStudent.Result());

            CollegeStudent collegeStudent = new CollegeStudent("Ankur", "Rajpal", "C-17,palampur,new delhi", 21, 'M', new DateTime(1991,11,16), "8802221454", 1244654, "764", "B.Com", 6, new DateTime(2012,6,1), 90000,new int[]{80,90,40,60,75}, 100, 250);
            Console.WriteLine(collegeStudent);
            Console.WriteLine("Check Attendance for Minor: "+collegeStudent.checkMinAttendanceMinor());
            Console.WriteLine("Check Attendance for Major: " + collegeStudent.checkMinAttendanceMajor());
            Console.WriteLine("Result: " + collegeStudent.Result());
            Console.ReadKey();
        }

    }

}
