using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment22
{
    /// <summary>
    /// This Program is used to demonstrate the use of binary Reader and Binary Writer
    /// </summary>
    class Program
    {
        const string fileName = "AppSettings.dat";
        static void Main(string[] args)
        {
            try
            {
                WriteSomeValue();
                DisplayValues();
            }
            catch (IOException ioexception)
            {
                Console.WriteLine("IOException:" + ioexception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception:" + exception.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Write Some value in the binary file
        /// </summary>
        public static void WriteSomeValue()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(250.32F);
                writer.Write(@"C:\Users");
                writer.Write(10);
                writer.Write(true);
            }
        }
        public static void DisplayValues()
        {
            float decimalValue;
            string userDirectory;
            int intValue;
            bool boolValue;
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    decimalValue = reader.ReadSingle();
                    userDirectory = reader.ReadString();
                    intValue = reader.ReadInt32();
                    boolValue = reader.ReadBoolean();
                }
                Console.WriteLine("Decimal Value:  " +decimalValue);
                Console.WriteLine("User Directory: "+userDirectory);
                Console.WriteLine("Int value:      "+intValue);
                Console.WriteLine("Bool Value:     "+boolValue);
            }
        }
    }
}
