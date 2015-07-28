using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.XPath;
namespace Assignment26
{
    public class Utility
    {
        public static void LoadStudentsFromXMLFile(String fileName)
        {
            List<Student> students = new List<Student>();
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlNodeList nodes = document.SelectNodes("//Students//Student");

            foreach (XmlNode node in nodes)
            {
                Student student = new Student();
                XmlNode Child = node.FirstChild;
                int id;
                if (Int32.TryParse(Child.InnerText, out id))
                    student.Id = id;
                Child = Child.NextSibling;
                student.Name = Child.InnerText;
                Child = Child.NextSibling;
                student.Grade = Child.InnerText;
                Child = Child.NextSibling;
                student.Branch = Child.InnerText;
                Child = Child.NextSibling;
                student.State = Child.InnerText;
                students.Add(student);
            }
                Student.InsertStudents(students);
            
        }
    
}
}