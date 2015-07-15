using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class CollegeStudent : Student
    {
        private int rollNumber;
        private string courseNo;
        private string courseName;
        private int semester;
        private DateTime dateOfJoin;
        private double fees;
        private int[] marks;
        private int presentDays;
        private int workingDays;
        public CollegeStudent()
        {

        }
        public CollegeStudent(string name, string guardiansName, string address, int age, char sex, DateTime dateOfBirth, string mobileNo, int rollNumber, string courseNo, string courseName, int semester, DateTime dateOfJoin, double fees, int[] marks, int presentDays, int workingDays) : base(name,guardiansName,address,age,sex,dateOfBirth,mobileNo)
        {
            this.rollNumber = rollNumber;
            this.courseNo = courseNo;
            this.courseName = courseName;
            this.semester = semester;
            this.dateOfJoin = dateOfJoin;
            this.fees = fees;
            this.marks = marks;
            this.presentDays = presentDays;
            this.workingDays = workingDays;
        }
        public int RollNumber
        {
            get
            {
                return rollNumber;
            }
            set
            {
                rollNumber = value;
            }
        }
        public string CourseNo
        {
            get
            {
                return courseNo;
            }
            set
            {
                courseNo = value;
            }
        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        public DateTime DateOfJoin
        {
            get
            {
                return dateOfJoin;
            }
            set
            {
                dateOfJoin = value;
            }
        }
        public double Fees
        {
            get
            {
                return fees;
            }
            set
            {
                fees = value;
            }
        }
        public int[] Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
        public int PresentDays
        {
            get
            {
                return presentDays;
            }
            set
            {
                presentDays = value;
            }
        }
        public int WorkingDays
        {
            get
            {
                return workingDays;
            }
            set
            {
                workingDays = value;
            }
        }
        public string Result()
        {
            double percentage=0;
            for (int i = 0; i < marks.Length; i++)
                percentage += marks[i];
            if ((percentage / marks.Length * 100) >= 50)
                return "Pass";
            return "Fail";

        }
        public string checkMinAttendanceMinor()
        {
            if (((workingDays / presentDays) * 100) > 50)
                return "OK";
            return "Below";
        }
        public string checkMinAttendanceMajor()
        {
            if (((workingDays / presentDays) * 100) > 80)
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
            return "College Student:\n" + base.ToString() + "\tRoll Number: " + rollNumber + "\nCourse No.: " + courseNo +"\tCourse Name: "+courseName + "\nFees: " + fees + "\tMarks: " +StringMarks(marks)+"\nSemester: "+semester+"\tDate OF Join: "+dateOfJoin + "\nPresent Days: " + presentDays + "\tWorking Days: " + workingDays;
        }

    }
}
