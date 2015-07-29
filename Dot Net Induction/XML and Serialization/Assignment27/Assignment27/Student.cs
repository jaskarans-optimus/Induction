using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Runtime.Serialization;
namespace Assignment27
{
    /// <summary>
    /// If u want to do binary serialization then implement ISerializable 
    /// If u want to do Xml Serialization then we need to remove ISerializable because we cant do that together 
    /// </summary>
    [Serializable()]
    [DataContract(Name="Customer")]
    class Student//:ISerializable
    {
        [DataMember(Name="RollNo")]
        private int rollNo;
        [DataMember(Name = "Name")]
        private string name;
         [DataMember(Name = "TotalMarks")]
        private int totalMarks;
        private char grade;
        public Student()
        {
        }
        public Student(int rollNo,string name,int totalMarks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.totalMarks = totalMarks;
        }
        /// <summary>
        /// Deserialization Constructor
        /// </summary>
        /// <param name="info">object holds the name-value pair for the properties to be serialized</param>
        /// <param name="context">used to pass custom data to deserialization function</param>
        public Student(SerializationInfo info, StreamingContext context)
        {
            rollNo = (int)info.GetValue("RollNo", typeof(int));
            name = (string)info.GetValue("Name", typeof(string));
            totalMarks = (int)info.GetValue("TotalMarks", typeof(int));
          
        }
        /// <summary>
        /// Serializing function
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info,StreamingContext context)
        {
            info.AddValue("RollNo", rollNo);
            info.AddValue("Name", name);
            info.AddValue("TotalMarks", totalMarks);
        }
     
        public char Grade
        {
            get
            {
                if (totalMarks > 60)
                {
                    return 'D';
                }
                else if (totalMarks >= 60 && totalMarks < 80)
                {
                    return 'C';
                }
                else if(totalMarks>=80 && totalMarks<90)
                {
                    return 'B';
                }
                else if (totalMarks >= 90 && totalMarks < 100)
                {
                    return 'A';
                }
                else
                {
                    return 'F';
                }
            }
        }
        /// <summary>
        /// Function That implement Binary serialization
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <param name="student">Object to be serialized</param>
        public static void BinarySerialization(String fileName,Student student)
        {
            try
            {
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream,student);
            stream.Close();
            }
            catch(Exception exception)
            {
              Console.WriteLine("Exception While writng :{0}",exception.Message);  
            }
        }
        /// <summary>
        /// Function That Implement Binary Deserialization
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <returns></returns>
        public static Student BinaryDeserialization(String fileName)
        {
           
            try
            {
                Student student;
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                student = (Student)binaryFormatter.Deserialize(stream);
                stream.Close();
                return student;
          
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception(Deserialization):" + exception.Message);
            }
            return null;
                    
        }
        public static void XmlSerialization(String fileName, Student student)
        {
          /*  XmlSerializer serializer = new XmlSerializer(typeof(Student));
            StreamWriter stream = new StreamWriter(fileName);
            try
            {
                serializer.Serialize(stream, student);
            }
            catch (SerializationException exception)
            {
                Console.WriteLine("Serialization Exception:" + exception.Message);
            }
            finally
            {
                stream.Close();

            }*/
           
            DataContractSerializer serializer = new DataContractSerializer(typeof(Student));
            FileStream file = new FileStream(fileName, FileMode.Create);
            try
            {
                using (XmlWriter writer = XmlWriter.Create(file))
                {
                    serializer.WriteObject(writer, student);
                }
                file.Close();
            }
            catch (Exception exception)
            {

                Console.WriteLine("XML Serilaization:"+exception.Message);
            }
        }
        public static Student XmlDeserialization(String fileName)
        {
            Student student = null;
           /* XmlSerializer serializer = new XmlSerializer(typeof(Student));
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            try
            {
                student = (Student)serializer.Deserialize(fileStream);
            }
            catch (SerializationException exception)
            {
                Console.WriteLine("Serialization Exception:" + exception.Message);
            }
            finally
            {
                fileStream.Close();
            }
            return student;*/
            DataContractSerializer serializer = new DataContractSerializer(typeof(Student));
            FileStream file = new FileStream(fileName, FileMode.Open);
            try
            {
                student = (Student)serializer.ReadObject(file);
            }
            catch (Exception exception)
            {
                Console.WriteLine("XML Deserialization :" + exception.Message);
            }
            finally
            {
                file.Close();
                
            }
            return student;
        }
        public static void SoapSerialization(String fileName, Student student)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);                
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(stream, student);
                stream.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception While writng :{0}", exception.Message);
            }
        }
        public static Student SoapDeserialization(String fileName)
        {

            try
            {
                Student student;
                Stream stream = File.Open(fileName, FileMode.Open);
                SoapFormatter soapFormatter = new SoapFormatter();

                student = (Student)soapFormatter.Deserialize(stream);
                stream.Close();
                return student;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception(Deserialization):" + exception.Message);
            }
            return null;

        }
        public override string ToString()
        {
            return String.Format("Student Details: \n  Name: {0} \n RollNo.: {1} \n Total Marks: {2}\n", name, rollNo, totalMarks);
        }
    }
}
