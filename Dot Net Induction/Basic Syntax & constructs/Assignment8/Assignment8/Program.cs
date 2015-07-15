using System;

namespace Assignment8
{
    
    class Student
    {

        enum StudentAttribute { name, erollNumber,fathersName, marks, collegeName, semester };
        String name;
        long enrollNumber;

        String fathersName;
        int[] marks;
        String collegeName;
        int semester;
        public Student()
        {

        }
        public Student(String name,long enrollNumber,String fathersName,int[] marks,String collegeName,int semester)
        {
            this.name = name;
            this.enrollNumber = enrollNumber;
         
            this.fathersName = fathersName;
            this.marks = marks;
            this.collegeName = collegeName;
            this.semester = semester;
        }
        public String Name { 
            get
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public long EnrollNumber 
        {
            get
            {
                return enrollNumber;
            }
          
        }
    
        public String  FathersName 
        {
            get
            {
                return fathersName;
            }
            set
            {
                fathersName = value;
            }
        }
        public String CollegeName 
        {
            get 
            {
                return collegeName;
            }
            set
            {
                collegeName = value;
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
        public int[] GetMarks()
        {
            return marks;
        }
        public void SetMarks(int[] marks)
        {
            this.marks = marks;
        }
        public void printMarks(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine(marks[i]);
        }
        public double CalculatePercentage()
        {
            double percentage=0;
            for (int i = 0; i < marks.Length; i++)
            {
                percentage += marks[i];
            }
            return (percentage / marks.Length)*100;
        }
        public void PrintAllDetails()
        {
            Console.WriteLine("----------------WELCOME----------------");
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Enrollment Number:" + EnrollNumber);
            Console.WriteLine("Father's Name:" + fathersName);
            Console.WriteLine("Marks:"); printMarks(marks);
            Console.WriteLine("College Name:" + collegeName);
            Console.WriteLine("Semester:" + semester);
            
            
        }

        public void print(int choice)
        {
            
            switch (choice)
            { 
                case 0:
                    Console.Write("Name:" + name);
                    break;
                case 1:
                    Console.WriteLine("Enrollment Number:" + enrollNumber);break;
                case 2:
                    Console.WriteLine("Father's Name:" + fathersName);break;
                case 3: 
                    Console.WriteLine("Marks:"); printMarks(marks);break;
                case 4:
                    Console.WriteLine("College Name:" + collegeName);break;
                case 5:
                   Console.WriteLine("Semester:" + semester);break;
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
