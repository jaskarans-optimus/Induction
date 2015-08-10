using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
      
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

   
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
     abstract class Product
    {
    }
 
      /// <summary>
     /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteProductA : Product
    {
    }
 
    /// <summary>
     /// A 'ConcreteProduct' class
     /// </summary>
    class ConcreteProductB : Product
     {
     }
 
    /// <summary>
    /// The 'Creator' abstract class
     /// </summary>
    abstract class Creator
    {
         public abstract Product FactoryMethod();
    }
 
        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
    class ConcreteCreatorA : Creator
    {
         public override Product FactoryMethod()
          {
         return new ConcreteProductA();
            }
     }
 
     /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
        class ConcreteCreatorB : Creator
         {
          public override Product FactoryMethod()
        {
         return new ConcreteProductB();
        }
     }
}
