using Assignment9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNLists2
{
    class TestCollection
    {
        static void Main(string[] args)
        {
            ArrayList vehicleList = new ArrayList();
            Bicycle bicycle = new Bicycle("Hero", 2002, "A234", 7.2f, true, 0, "Road", 2.8f);
            Bike bike = new Bike("Bajaj", 2010, "Enticer", 30, "Cruise", 250, 2);
            Car car = new Car("Honda", 2014, "Amaze", 60, "Sedan", 4, "manual", 4, false, true, true);
            vehicleList.Add(bicycle);
            vehicleList.Add(car);
            vehicleList.Add(bike);
            
            foreach (Vehicle vehicle in  vehicleList)
            {
                Console.WriteLine(vehicle+"\n \n");
            }
            Console.WriteLine("\n \nAccessing element by index:");
            for (int i = 0; i < vehicleList.Count; i++)
            {
              ((Vehicle)vehicleList[i]).YearOfManufacture = 2010;
                Console.WriteLine(vehicleList[i] + "\n\n");
            }
                Console.ReadKey();
        }
    }
}
