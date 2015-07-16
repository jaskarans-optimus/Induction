using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class SchoolStudent : Student
    {
        private int _rollNumber;
        private int _standard;
        private double _fees;
        private int[] _marks;
        private int _presentDays;
        private int _workingDays;
        private String _nameOfinstitute;
        public SchoolStudent()
        {

        }
        public SchoolStudent(string name, string guardiansName, string address, int age, char sex, DateTime dateOfBirth, string mobileNo,int rollNumber,int standard,double fees,int[] marks,int presentDays,int workingDays,string nameOfInstitute)
            : base(name, guardiansName, address, age, sex, dateOfBirth, mobileNo)
        {
            this.RollNumber = rollNumber;
            this.Standard = standard;
            this.Fees = fees;
            this.Marks = marks;
            this.PresentDays = presentDays;
            this.WorkingDays = workingDays;
            this.NameOfInstitute = nameOfInstitute;
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
        public int Standard
        {
            get
            {
                return _standard;
            }
            set
            {
                _standard = value;
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
        public string NameOfInstitute
        {
            get
            {
                return _nameOfinstitute;
            }
            set
            {
                _nameOfinstitute = value;
            }
        }
        public String Result()
        {
            double percentage = 0;
            for (int i = 0; i < Marks.Length; i++)
                percentage += Marks[i];
            if ((percentage / Marks.Length * 100) >= 33)
                return "Pass";
            return "Fail";

        }
        public string checkMinAttendance()
        {
            if (((WorkingDays / PresentDays) * 100) > 60)
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
            return "School Student:\n"+base.ToString()+"\nRoll Number: "+RollNumber+"\tStandard: "+Standard+"\nFees: "+Fees+"\tMarks: "+StringMarks(Marks)+"\nPresent Days: "+PresentDays+"\tWorking Days: "+WorkingDays;
        }
    }
}
