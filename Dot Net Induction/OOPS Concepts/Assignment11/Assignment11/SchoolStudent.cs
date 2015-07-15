using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class SchoolStudent : Student
    {
        private int rollNumber;
        private int standard;
        private double fees;
        private int[] marks;
        private int presentDays;
        private int workingDays;
        private String nameOfinstitute;
        public SchoolStudent()
        {

        }
        public SchoolStudent(string name, string guardiansName, string address, int age, char sex, DateTime dateOfBirth, string mobileNo,int rollNumber,int standard,double fees,int[] marks,int presentDays,int workingDays,string nameOfInstitute)
            : base(name, guardiansName, address, age, sex, dateOfBirth, mobileNo)
        {
            this.rollNumber = rollNumber;
            this.standard = standard;
            this.fees = fees;
            this.marks = marks;
            this.presentDays = presentDays;
            this.workingDays = workingDays;
            this.nameOfinstitute = nameOfInstitute;
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
        public int Standard
        {
            get
            {
                return standard;
            }
            set
            {
                standard = value;
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
        public string NameOfInstitute
        {
            get
            {
                return nameOfinstitute;
            }
            set
            {
                nameOfinstitute = value;
            }
        }
        public String Result()
        {
            double percentage = 0;
            for (int i = 0; i < marks.Length; i++)
                percentage += marks[i];
            if ((percentage / marks.Length * 100) >= 33)
                return "Pass";
            return "Fail";

        }
        public string checkMinAttendance()
        {
            if (((workingDays / presentDays) * 100) > 60)
                return "OK";
            return "Less than Minimum";
        }
        public string StringMarks(int[] marks)
        {
            String s="";
            for (int i = 0; i < marks.Length; i++)
                s += marks[i] + " ";
            return s;
        }
        public override string ToString()
        {
            return "School Student:\n"+base.ToString()+"\nRoll Number: "+rollNumber+"\tStandard: "+standard+"\nFees: "+fees+"\tMarks: "+StringMarks(marks)+"\nPresent Days: "+presentDays+"\tWorking Days: "+workingDays;
        }
    }
}
