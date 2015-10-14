using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class TemporaryClass
    {
        private int privateNum = 0;
        public TemporaryClass()
        {
        }
        public TemporaryClass(String myString)
        {
            Console.WriteLine("Temporary class (String):"+myString);
        }
        public TemporaryClass(StringBuilder myStringBuilder)
        {
            Console.WriteLine("Temporary class(StringBuilder)" + myStringBuilder);
        }
        public void SetValue(int num)
        {
            privateNum=num;
        }
        public int GetValue()
        {
            return privateNum;
        }
    }
}
