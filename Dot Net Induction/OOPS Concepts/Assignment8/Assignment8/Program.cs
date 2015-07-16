using System;

namespace Assignment8
{
    
    class Student
    {

        enum StudentAttribute { name, erollNumber,fathersName, marks, collegeName, semester };
        String _name;
        long _enrollNumber;

        String _fathersName;
        int[] _marks;
        String _collegeName;
        int _semester;
        public Student()
        {

        }
        public Student(String name,long enrollNumber,String fathersName,int[] marks,String collegeName,int semester)
        {
            this._name = name;
            this._enrollNumber = enrollNumber;
         
            this._fathersName = fathersName;
            this._marks = marks;
            this._collegeName = collegeName;
            this._semester = semester;
        }
        public String Name { 
            get
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }
        public long EnrollNumber 
        {
            get
            {
                return _enrollNumber;
            }
            set
            {
                _enrollNumber = value;
            }
          
        }
    
        public String  FathersName 
        {
            get
            {
                return _fathersName;
            }
            set
            {
                _fathersName = value;
            }
        }
        public String CollegeName 
        {
            get 
            {
                return _collegeName;
            }
            set
            {
                _collegeName = value;
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
        public int[] GetMarks()
        {
            return _marks;
        }
        public void SetMarks(int[] marks)
        {
            this._marks = marks;
        }
        public void printMarks(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine(marks[i]);
        }
        public double CalculatePercentage()
        {
            double percentage=0;
            for (int i = 0; i < _marks.Length; i++)
            {
                percentage += _marks[i];
            }
            return (percentage / _marks.Length)*100;
        }
        public void PrintAllDetails()
        {
            Console.WriteLine("----------------WELCOME----------------");
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Enrollment Number:" + EnrollNumber);
            Console.WriteLine("Father's Name:" + _fathersName);
            Console.WriteLine("Marks:"); printMarks(_marks);
            Console.WriteLine("College Name:" + _collegeName);
            Console.WriteLine("Semester:" + _semester);
            
            
        }

        public void print(int choice)
        {
            
            switch (choice)
            { 
                case 0:
                    Console.Write("Name:" + _name);
                    break;
                case 1:
                    Console.WriteLine("Enrollment Number:" + _enrollNumber);break;
                case 2:
                    Console.WriteLine("Father's Name:" + _fathersName);break;
                case 3: 
                    Console.WriteLine("Marks:"); printMarks(_marks);break;
                case 4:
                    Console.WriteLine("College Name:" + _collegeName);break;
                case 5:
                   Console.WriteLine("Semester:" + _semester);break;
                default:
                    Console.WriteLine("Choice invalid");break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Student student = new Student("Karan",random.Next(1,Int32.MaxValue),"Manno",new int[]{76,65,58,70,69},"ABCInstitute",6);
            student.PrintAllDetails();
            student.print(3);
            Console.ReadKey();

        }
    }
}
