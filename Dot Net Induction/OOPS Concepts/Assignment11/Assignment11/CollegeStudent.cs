using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class CollegeStudent : Student
    {
        private int _rollNumber;
        private string _courseNo;
        private string _courseName;
        private int _semester;
        private DateTime _dateOfJoin;
        private double _fees;
        private int[] _marks;
        private int _presentDays;
        private int _workingDays;
        public CollegeStudent()
        {

        }
        public CollegeStudent(string name, string guardiansName, string address, int age, char sex, DateTime dateOfBirth, string mobileNo, int rollNumber, string courseNo, string courseName, int semester, DateTime dateOfJoin, double fees, int[] marks, int presentDays, int workingDays) : base(name,guardiansName,address,age,sex,dateOfBirth,mobileNo)
        {
            this.RollNumber = rollNumber;
            this.CourseNo = courseNo;
            this.CourseName = courseName;
            this.Semester = semester;
            this.DateOfJoin = dateOfJoin;
            this.Fees = fees;
            this.Marks = marks;
            this.PresentDays = presentDays;
            this.WorkingDays = workingDays;
        }
        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                _rollNumber = value;
            }
        }
        public string CourseNo
        {
            get
            {
                return _courseNo;
            }
            set
            {
                _courseNo = value;
            }
        }
        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                _courseName = value;
            }
        }
        public int Semester
        {
            get
            {
                return _semester;
            }
            set
            {
                _semester = value;
            }
        }
        public DateTime DateOfJoin
        {
            get
            {
                return _dateOfJoin;
            }
            set
            {
                _dateOfJoin = value;
            }
        }
        public double Fees
        {
            get
            {
                return _fees;
            }
            set
            {
                _fees = value;
            }
        }
        public int[] Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                _marks = value;
            }
        }
        public int PresentDays
        {
            get
            {
                return _presentDays;
            }
            set
            {
                _presentDays = value;
            }
        }
        public int WorkingDays
        {
            get
            {
                return _workingDays;
            }
            set
            {
                _workingDays = value;
            }
        }
        public string Result()
        {
            double percentage=0;
            for (int i = 0; i < Marks.Length; i++)
                percentage += Marks[i];
            if ((percentage / Marks.Length * 100) >= 50)
                return "Pass";
            return "Fail";

        }
        public string checkMinAttendanceMinor()
        {
            if (((WorkingDays / PresentDays) * 100) > 50)
                return "OK";
            return "Below";
        }
        public string checkMinAttendanceMajor()
        {
            if (((WorkingDays / PresentDays) * 100) > 80)
                return "OK";
            return "Below";
        }
        public string StringMarks(int[] marks)
        {
            String s = "";
            for (int i = 0; i < marks.Length; i++)
                s += marks[i] + " ";
            return s;
        }
        public override string ToString()
        {
            return "College Student:\n" + base.ToString() + "\tRoll Number: " + RollNumber + "\nCourse No.: " + CourseNo +"\tCourse Name: "+CourseName + "\nFees: " + Fees + "\tMarks: " +StringMarks(Marks)+"\nSemester: "+Semester+"\tDate OF Join: "+DateOfJoin + "\nPresent Days: " + PresentDays + "\tWorking Days: " + WorkingDays;
        }

    }
}
