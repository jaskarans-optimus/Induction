using System;

namespace Assignment7
{
  
    
        class SavingsAccount
        {
            public double currBalance;
            public static double currInterestRate = 0.04;
            public SavingsAccount(double balance)
            {
                currBalance = balance;
            }
            public static void SetInterestRate(double newRate)
            {
                currInterestRate = newRate;
            }
            public static double GetInterestRate()
            {
                return currInterestRate;
            }
            public void SetInterestRateObj(double newRate)
            {
                currInterestRate = newRate;
            }
            public double GetInterestRateObj() { return currInterestRate; }
            static void Main(string[] args)
            {
                SavingsAccount s1 = new SavingsAccount(50);
                // An object s1 is created whose  'currBalance' field  is set to 50

                SavingsAccount s2 = new SavingsAccount(100);
                // An object s1 is create whose 'currBalace' field is set to 100

                Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
                //s1.getInterestRateObj() returns the default value of currInterestRate=0.04

                s2.SetInterestRateObj(0.08);
                // s2.SetInterestRateObj sets the value of currInterestRate . 
                //Since 'currInterestRate' is static , all objects will share the value 0.08
                Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
                //this will give output 0.08 as explained above

                SavingsAccount s3 = new SavingsAccount(10000.75);
                Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
                // this will also give '0.08'  as Output
            }
        }
    }
    /*
     * Output 
     * Interest Rate is: 0.04
     * Interest Rate is: 0.08
     * Interest Rate is: 0.08

    */

