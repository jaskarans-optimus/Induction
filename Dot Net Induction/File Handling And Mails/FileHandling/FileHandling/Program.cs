using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.IO.Compression;
namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAttributes();
            NewlyCreatedFileDirectory();
            PathDirectory("C:\\Program Files");

            SetToReadOnly("C:\\Users\\optimus150.OPTIMUSDOM\\Desktop\\file1.txt");
            ReadAndWriteFile("C:\\Users\\optimus150.OPTIMUSDOM\\Desktop\\file1.txt", "C:\\Users\\optimus150.OPTIMUSDOM\\Desktop\\file2.txt");
            try
            {
                CompressFile("C:\\Users\\optimus150.OPTIMUSDOM\\Desktop\\file1.txt", "C:\\Users\\optimus150.OPTIMUSDOM\\Desktop\\file2.txt");
            }
            catch
            {
                Console.WriteLine("Compression Failed");
            }
            Console.ReadKey();
        }

        public static void DisplayAttributes()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.ToString().CompareTo("C:\\") == 0)
                {
                    Console.WriteLine("Drive Name:" + drive.Name);
                    Console.WriteLine("Drive Volume Name:" + drive.VolumeLabel);
                    Console.WriteLine("Drive Format:" + drive.DriveFormat);
                    Console.WriteLine("Drive Type:" + drive.DriveType);
                    Console.WriteLine("Available Free Space:" + drive.AvailableFreeSpace);
                    Console.WriteLine("Root Directory:" + drive.RootDirectory);
                    Console.WriteLine("Total Free Space:" + drive.TotalFreeSpace);
                    Console.WriteLine("Total Size:" + drive.TotalSize);

                }
            }
        }
        public static void NewlyCreatedFileDirectory()
        {
            DirectoryInfo directory = new DirectoryInfo("C:\\");
            FileInfo file = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
            Console.WriteLine("\n\nName:" + file.Name);
            Console.WriteLine("Full Name:" + file.FullName);
            Console.WriteLine("Read-Only:" + file.IsReadOnly);
            Console.WriteLine("Last Acces Time:" + file.LastAccessTime);
            Console.WriteLine("Last Write Time:" + file.LastWriteTime);
            Console.WriteLine("Length:" + file.Length);
            Console.WriteLine("Extension:" + file.Extension);
            Console.WriteLine("Attributes:" + file.Attributes);
            Console.WriteLine("Creation Time:" + file.CreationTime);
            Console.WriteLine("Directory Name: " + file.DirectoryName);


            DirectoryInfo directory1 = directory.GetDirectories().OrderByDescending(f => f.LastWriteTime).First();
            Console.WriteLine("\n\nDirectory Name:" + directory1.Name);
            Console.WriteLine("Parent:" + directory1.Parent);
            Console.WriteLine("Root:" + directory1.Root);
            Console.WriteLine("Last Write Time:" + directory1.LastWriteTime);
            Console.WriteLine("Last Access Time:" + directory1.LastAccessTime);
            Console.WriteLine("Extension:" + directory1.Extension);
            Console.WriteLine("Creation Time:" + directory1.CreationTime);
            Console.WriteLine("Attributes" + directory1.Attributes);

        }
        public static void PathDirectory(String path)
        {
            Console.WriteLine("\nDirectory Path:" + Path.GetDirectoryName(path));
        }
        public static void SetToReadOnly(String path)
        {
            FileInfo file = new FileInfo(path);
            file.IsReadOnly = true;
        }
        public static void ReadAndWriteFile(String filePath1, String filePath2)
        {
            String text = File.ReadAllText(filePath1);
            File.WriteAllText(filePath2, text);

        }
        public static void CompressFile(String path1, String path2)
        {
            String text = File.ReadAllText(path1);
            String temp = Path.GetTempFileName();
            File.WriteAllText(temp, text);
            byte[] buffer;
            using (FileStream file = new FileStream(temp, FileMode.Open))
            {
                buffer = new byte[file.Length];
                file.Read(buffer, 0, (int)file.Length);
            }
            using (FileStream f2 = new FileStream(path2, FileMode.Create))
            using (GZipStream gz = new GZipStream(f2, CompressionMode.Compress, false))
            {
                gz.Write(buffer, 0, buffer.Length);
            }
        }
    }
}