using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement3
{
    class Testenum
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
         static void Main()
        {
            foreach (string str in Enum.GetNames(typeof(Days)))
                Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
