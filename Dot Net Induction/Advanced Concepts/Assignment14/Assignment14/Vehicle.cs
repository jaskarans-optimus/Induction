using System;
using System.Collections;
using System.Collections.Generic;
namespace Assignment12
{
    public class Vehicle :IComparable<Vehicle>,IEqualityComparer<Vehicle>
    {
        private string _make;
        private int _yearOfManufacture;
        private string _model;
        private float _speed;
        public Vehicle()
        {

        }
        public Vehicle(string make, int yearOfManufacture, string model, float speed)
        {
            this._make = make;
            this._yearOfManufacture = yearOfManufacture;
            this._model = model;
            this._speed = speed;
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public int YearOfManufacture
        {
            get
            {
                return _yearOfManufacture;
            }
            set
            {
                _yearOfManufacture = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public float Speed
        {
            get
            {
                return _speed;

            }
            set
            {
                _speed = value;
            }

        }
        public virtual void Accelerate()
        {
            _speed = _speed + 10;
        }
        public virtual void Deaccelerate()
        {
            
            _speed = _speed - 10;
            if (_speed < 0)
            {
                _speed = 0;
            }
        }
        public virtual void Stop()
        {
            _speed = 0;
        }
        public bool isMoving()
        {
            if (_speed != 0)
                return true;
            return false;
        }

        public int CompareTo(Vehicle obj)
        {
            if (obj == null)
                return 1;
            return this.Speed.CompareTo((obj as Vehicle).Speed);
        }
        
        
        public bool Equals(Vehicle v1,Vehicle v2)
        {
            if (v1 == null || v2 == null)
                return false;
            if (v1 == v2)
                return true;
            else if (!v1.Make.Equals(v2.Make))
                return false;
            else if (!v1.Model.Equals(v2.Model))
                return false;
            else if (!v1.YearOfManufacture.Equals(v2.YearOfManufacture))
                return false;
            return true;
        }
        public int GetHashCode(Vehicle v)
        {
            int hCode =(int) v.Speed;
            return hCode.GetHashCode();
        }
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle("Hero",2002,"A234", 7.2f , true,0,"Road",2.8f);
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Deaccelerate();
            //Console.WriteLine("\nBicycle:\n"+bicycle);
            Bike bike = new Bike("Bajaj",2010,"Enticer",30,"Cruise",250,2);
            bike.Accelerate();
            bike.Accelerate();
            bike.Accelerate();
            bike.Deaccelerate();
            bike.Stop();
          //  Console.WriteLine("\nBike:\n" + bike);
            Car car = new Car("Honda",2014,"Amaze",60,"Sedan",4,"manual",4,false,true,true);
           // Console.WriteLine("\nCar:\n" + car);
            List<Vehicle>list = new List<Vehicle>();
            list.Add(bicycle);
            list.Add(bike);
            list.Add(car);
            Console.WriteLine("-----------Vehicle List(Before Sorting):\n---------");
            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle+"\n\n");
            }
            list.Sort();
            Console.WriteLine("----------Vehicle List(After Sorting according to Speed):\n-----------");
            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle+"\n\n");
            }
            
            Console.WriteLine(new Vehicle().Equals(car ,bike
));
            Console.ReadKey();
        }
    }
    
}
