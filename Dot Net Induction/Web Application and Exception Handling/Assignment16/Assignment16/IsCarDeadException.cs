using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class IsCarDeadException :Exception
    {
        private string p;
        private float Speed;

        public IsCarDeadException(string message,float speed)
            : base(message)
        {
            Console.WriteLine("vehicle: {0} at time : {1} and speed : {2}", message, DateTime.Now, speed);
            ExceptionUtility.LogException(this,"vehicle:"+message+" at time : "+DateTime.Now+" and speed :"+speed);
        }

 
    }
}
