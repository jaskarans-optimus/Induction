using System;

namespace Assignment5
{
    class TestStringArrays
    {
        public static string[] GetStringArray()//assignment 5 String array
        {
            return new string[] { "This", "is", "a", "string", "array" };
        }
        static void Main(string[] args)
        {

            String[] stringArray = GetStringArray();
            foreach (string str in stringArray)
                Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
