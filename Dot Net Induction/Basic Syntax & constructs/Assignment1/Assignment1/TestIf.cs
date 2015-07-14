using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TestIf
    {
        public static void Main()
        {
            string languageChoice = System.Console.ReadLine();
            if (languageChoice.Equals("VB", StringComparison.InvariantCultureIgnoreCase))
            {
                System.Console.WriteLine("VB .NET: OOP, multithreading andmore!");
            }
            else if (languageChoice.Equals("C#", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("Good choice, C# is a fine language");
            else
                Console.WriteLine("Well...good luck with that!");

            Console.ReadKey();
        }
    }
}
