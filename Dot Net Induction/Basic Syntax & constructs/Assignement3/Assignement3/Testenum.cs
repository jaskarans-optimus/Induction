﻿using System;

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
