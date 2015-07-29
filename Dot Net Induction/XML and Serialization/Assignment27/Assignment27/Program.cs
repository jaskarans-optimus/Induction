using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("---------------Binary Serialization--------------");
            //Student student = new Student(2,"abc",60);
            //Console.WriteLine("Before Serialization \n {0}", student);
            //Student.BinarySerialization("iCalibrator.dat",student);
            //Student deSerializedStudent = Student.BinaryDeserialization("iCalibrator.dat");
            //Console.WriteLine("After Serialization \n {0}",deSerializedStudent);

            Console.WriteLine("---------------XML Serialization-----------------");
            Student student1 = new Student(4, "Sarab", 70);
            Console.WriteLine("Before Serialization \n {0}", student1);
            Student.XmlSerialization("iCalibrator.xml", student1);
            Student student2 = Student.XmlDeserialization("iCalibrator.xml");
            Console.WriteLine("After Serialization:{0}", student2);

            Console.WriteLine("---------------Soap Serialization-----------------");
            Student student3 = new Student(5, "bad", 80);
            Console.WriteLine("Before Serialization \n {0}", student3);
            Student.SoapSerialization("iCalibrator.soap", student3);
            Student student4 = Student.SoapDeserialization("iCalibrator.soap");
            Console.WriteLine("After Serialization \n {0}", student4);
            Console.ReadKey();
        }
    }
}
