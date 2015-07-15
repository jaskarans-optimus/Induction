using System;

namespace Assignment2
{
    class TestSwitch
    {
         static void Main()
        {

            string languageChoice = System.Console.ReadLine();
            switch (languageChoice)
            {
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading andmore!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;


            }
            Console.ReadKey();
        }
    }
}
