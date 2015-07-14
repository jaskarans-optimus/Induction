using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TestStrings
    {
       static void Main()//assignment 4 String operations
        {
            string temp = "India is Incredible", temp2 = "Incredible";
            Console.WriteLine("String 1:{0} \nString 2:{1}\n", temp, temp2);
            string cloneString = (String)temp.Clone();
            Console.WriteLine("\nClone:{0}", cloneString);
            Console.WriteLine("\nCompare: {0}", String.Compare(temp2, temp));
            Console.WriteLine("\nCompare(IgnoreCase): {0}", String.Compare(temp2, temp, true));
            Console.WriteLine("\nConcat: {0}", String.Concat(temp2, temp));
            Console.WriteLine("\nConcat: {0}", String.Concat(temp2, temp, " WAH"));
            Console.WriteLine("\nContains: {0}", temp.Contains(temp2));
            Console.WriteLine("\nCopy: {0}", string.Copy(temp));
            char[] ch = new char[10];
            temp.CopyTo(8, ch, 0, 8);
            String dest = new String(ch);
            Console.WriteLine("\nCopyto:{0}", dest);
            Console.WriteLine("\nEndWith:{0}", temp.EndsWith(temp2));
            Console.WriteLine("\nEquals: {0}", temp.Equals(temp2));
            Console.WriteLine("\nStatic Equals: {0}", string.Equals(temp, temp2));
            String s = string.Format("\nThis is string \" {0} \" using Format", temp2);
            Console.WriteLine(s);
            Console.WriteLine("\nFirst Occurrence  of String \"{0}\" in String \"{1}\" using indexof():{2}", temp2, temp, temp.IndexOf(temp2));
            Console.WriteLine("\nFirst Occurrence  of char \"{0}\" in String \"{1}\" using indexof():{2}", 'i', temp, temp.IndexOf('i', 7));
            char[] ch1 = { 'i', 'a', 'r' };
            Console.WriteLine("\nIndexOfAny():{0}", temp.IndexOfAny(ch1));
            Console.WriteLine("\nInsert():{0}", temp.Insert(temp.Length, temp2));
            Console.WriteLine("\nIsNull():{0}", string.IsNullOrEmpty(temp));
            Console.WriteLine("\njoin() :{0}", string.Join(" , ", ch1));
            Console.WriteLine("\nLastIndexof() :{0}", temp.LastIndexOf("Inc"));
            Console.WriteLine("\nRemove() :{0}", temp.Remove(9));
            Console.WriteLine("\nReplace() :{0}", temp.Replace('i', 'b'));
            Console.WriteLine("\nReplace() :{0}", temp.Replace("Incredible", "Bekaar h"));
            Console.WriteLine("\nSplit() :");
            string[] stringSplit = temp.Split(' ');
            foreach (string str in stringSplit)
            {
                Console.WriteLine("\n{0}", str);
            }
            Console.WriteLine("\nStartsWith() :{0}", temp.StartsWith("I"));
            char[] temp1 = temp.ToCharArray();
            Console.WriteLine("\n tocharArray() :");
            for (int i = 0; i < temp1.Length; i++)
            {
                Console.Write(temp1[i] + ",");
            }

            Console.WriteLine("\nToLower() :{0}", temp.ToLower());
            Console.WriteLine("\nToUpper() :{0}", temp.ToUpper());
            Console.WriteLine("\nTrim() :{0}", temp.Trim());
            Console.ReadKey();
        }
    }
}
