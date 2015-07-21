using System;
using System.IO;

namespace Assignment12
{
    public class ExceptionUtility
    {
        private IsCarDeadException icde;
        private string p;

        private ExceptionUtility()
        { }

        

        public static void LogException(Exception exc, string source)
        {
            string logFile = "App_Data/";
          
            if (!Directory.Exists(logFile))
                Directory.CreateDirectory(logFile);

            logFile = Path.Combine(logFile, "ExceptionLogger.log");
   

            StreamWriter streamWriter = new StreamWriter(logFile, true);
            streamWriter.WriteLine("\n\n");
            streamWriter.WriteLine("Exception at {0}", DateTime.Now);
            if (exc.InnerException != null)
            {
                streamWriter.Write("Inner Exception Type: ");
                streamWriter.WriteLine(exc.InnerException.GetType().ToString());
                streamWriter.Write("Inner Exception: ");
                streamWriter.WriteLine(exc.InnerException.Message);
                streamWriter.Write("Inner Source: ");
                streamWriter.WriteLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    streamWriter.WriteLine("Inner Stack Trace: ");
                    streamWriter.WriteLine(exc.InnerException.StackTrace);
                }
            }
            streamWriter.Write("Exception Type: ");
            streamWriter.WriteLine(exc.GetType().ToString());
            streamWriter.WriteLine("Exception: " + exc.Message);
            streamWriter.WriteLine("Source: " + source);
            streamWriter.WriteLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                streamWriter.WriteLine(exc.StackTrace);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }
    }
}
