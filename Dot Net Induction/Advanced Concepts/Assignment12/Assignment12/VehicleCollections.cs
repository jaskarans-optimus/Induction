using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class VehicleCollections:IEnumerable<Vehicle>
    {
       private List<Vehicle> vehicleList;
        public  VehicleCollections()
       {
           vehicleList=new List<Vehicle>();
       }
       public void Add(Vehicle vehicle)
       {
           vehicleList.Add(vehicle);
       }
       public bool Remove(Vehicle vehicle)
       {
           return vehicleList.Remove(vehicle);
           
       }
       public IEnumerator<Vehicle> GetEnumerator()
       {
           foreach (Vehicle vehicle in vehicleList)
           {
               if (vehicle == null)
               {
                   break;
               }
               yield return vehicle;
           }
       }
        IEnumerator IEnumerable.GetEnumerator()
       {
           // Lets call the generic version here
           return this.GetEnumerator();
       }
    }
}
