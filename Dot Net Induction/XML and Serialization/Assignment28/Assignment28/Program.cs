using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment28
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(2, "abc", 60);
            Student student1 = new Student(4, "Sarab", 70);
            Student student2 = new Student(5, "bad", 80);
            var students= new List<Student>();
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            List<Student> deSerializedStudents;
            Console.WriteLine("---------------Binary Serialization--------------");
            Console.WriteLine("Before Serialization \n");
            foreach (Student student3 in students)
            {
                Console.WriteLine(student3);
            }
            Student.BinarySerialization("iCalibrator.dat", students);

            deSerializedStudents = Student.BinaryDeserialization("iCalibrator.dat");
            Console.WriteLine("After Serialization \n {0}");
            foreach (Student student3 in deSerializedStudents)
            {
                Console.WriteLine(student3);
            }
            //Console.WriteLine("---------------XML Serialization-----------------");


            //Console.WriteLine("Before Serialization \n ");
            //foreach (Student student3 in students)
            //{
            //    Console.WriteLine(student3);
            //}
            //Student.XmlSerialization("iCalibrator.xml", students);
            //deSerializedStudents = Student.XmlDeserialization("iCalibrator.xml");
            //Console.WriteLine("After Serialization:");
            //foreach (Student student3 in deSerializedStudents)
            //{
            //    Console.WriteLine(student3);
            //}


            Console.WriteLine("---------------Soap Serialization-----------------");

            Console.WriteLine("Before Serialization \n ");
            foreach (Student student3 in students)
            {
                Console.WriteLine(student3);
            }

            Student.SoapSerialization("iCalibrator.soap", students);
            Student[] deSerializedStudents1 = Student.SoapDeserialization("iCalibrator.soap");
            Console.WriteLine("After Serialization \n ");
            foreach (Student student3 in deSerializedStudents1)
            {
                Console.WriteLine(student3);
            }
            Console.ReadKey();
        }
    }
}
