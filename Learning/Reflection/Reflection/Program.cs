using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        delegate int IntFunc(int x);
        static int Square(int x) { return x * x; } // Static method
        int Cube(int x) { return x * x * x; } // Instance method
        static void Main(string[] args)
        {
            //Instantiating types
            //First way
            DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime), 2000, 1, 1);
            Console.WriteLine(dt);
            
            //Second Way
            // Fetch the constructor that accepts a single parameter of type string:
            ConstructorInfo constructorInfo = typeof(TemporaryClass).GetConstructor(new[] { typeof(string) });
            // Construct the object using that overload, passing in null:
            object foo = constructorInfo.Invoke(new object[] { null });
            Console.WriteLine(foo.GetType());

            //Delegate Instaniation
            Delegate staticD = Delegate.CreateDelegate(typeof(IntFunc), typeof(Program), "Square");
            Delegate instanceD = Delegate.CreateDelegate(typeof(IntFunc), new Program(), "Cube");
            Console.WriteLine(staticD.DynamicInvoke(3)); 
            Console.WriteLine(instanceD.DynamicInvoke(3));
            IntFunc f = (IntFunc)staticD;
            Console.WriteLine(f(3)); 
            
            //Generic Types
            Type closed = typeof(List<int>);
            List<int> list = (List<int>)Activator.CreateInstance(closed); // OK
            Type unbound = typeof(List<>);
            //object anError = Activator.CreateInstance(unbound); // Runtime error
            Console.WriteLine(closed.IsGenericType);
            Console.WriteLine(closed.IsGenericTypeDefinition);
            Console.WriteLine(unbound.IsGenericType);
            Console.WriteLine(unbound.IsGenericTypeDefinition);
            Console.WriteLine(closed.GetGenericArguments()[0]);
            Console.WriteLine(unbound.GetGenericArguments()[0]);

            //Reflecting and invoking members
            MemberInfo[] members = typeof(TemporaryClass).GetMembers();
                
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine();
            //Does not show inherited memebrs
            IEnumerable<MemberInfo> Concretemembers = typeof(TemporaryClass).GetTypeInfo().DeclaredMembers;
            foreach (MemberInfo member in Concretemembers)
            {
                Console.WriteLine(member);
            }

            PropertyInfo unbound1= typeof(IEnumerator<>).GetProperty("Current");
            PropertyInfo closed1 = typeof(IEnumerator<int>).GetProperty("Current");
            Console.WriteLine(unbound1);
            Console.WriteLine(closed1); 
            Console.WriteLine(unbound1.PropertyType.IsGenericParameter); 
            Console.WriteLine(closed1.PropertyType.IsGenericParameter);

            //PropertyInfo
            object s = "Hello";
            PropertyInfo prop = s.GetType().GetProperty("Length");
            int length = (int)prop.GetValue(s, null);
            Console.WriteLine(length);

            //Accessing Non Public Members
            Type type = typeof(TemporaryClass);
            TemporaryClass tc = new TemporaryClass();
            tc.SetValue(10);
            FieldInfo numfield = type.GetField("privateNum", BindingFlags.NonPublic | BindingFlags.Instance);
            numfield.SetValue(tc, 120);
            Console.WriteLine(tc.GetValue());

            //Reflecting Assemblies
            Type assemblyType = Assembly.GetExecutingAssembly().GetType();
            Type assembletype = typeof(Program).Assembly.GetType();
            Console.WriteLine(assembletype);

            //Assembly a = Assembly.LoadFrom(@"c:\Windows\System32\bootstr.dll");
            //foreach (Type t in a.GetTypes())
            //    Console.WriteLine(t);

            TypeAttributes ta = typeof(Console).Attributes;
            MethodAttributes ma = MethodInfo.GetCurrentMethod().Attributes;
            Console.WriteLine(ta + "\r\n" + ma);
        }
    }
}
