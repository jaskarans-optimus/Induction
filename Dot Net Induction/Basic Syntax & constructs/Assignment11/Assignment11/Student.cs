using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Student
    {
        private string name;
        private string guardiansName;
        private string address;
        private int age;
        private char sex;
        private DateTime dateOfBirth;
        private string mobileNo;
        public Student()
        {

        }
        public Student(string name,string guardiansName,string address,int age,char sex,DateTime dateOfBirth,string mobileNo)
        {
            this.name = name;
            this.guardiansName = guardiansName;
            this.address = address;
            this.age = age;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.mobileNo = mobileNo;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string GuardiansName
        {
            get
            {
                return guardiansName;
            }
            set
            {
                guardiansName = value;
            }
        }
        public string Address
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex=value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
        public string MobileNo
        {
            get
            {
                return mobileNo;
            }
            set
            {
                mobileNo = value;
            }

        }
        public override string ToString()
        {
            return "Name:"+name+"\tGuardian's Name: "+guardiansName+"\nAge: "+age+"\tSex: "+sex+"\nDate Of Birth: "+dateOfBirth+"\tAddress: "+address+"\nMobile: "+mobileNo;
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
