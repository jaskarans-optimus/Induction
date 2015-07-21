using System;
using System.Collections;
using System.Collections.Generic;
namespace Assignment12
{
    public class Vehicle :IComparable<Vehicle>,IEquatable<Vehicle>
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
        
        
        public bool Equals(Vehicle v2)
        {
            if (v2 == null)
                return false;
            if (this == v2)
                return true;
            else if (!this.Make.Equals(v2.Make))
                return false;
            else if (!this.Model.Equals(v2.Model))
                return false;
            else if (!this.YearOfManufacture.Equals(v2.YearOfManufacture))
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
            Bicycle bicycle = new Bicycle("Hero",2002,"A234",100f , true,0,"Road",2.8f);
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Deaccelerate();

            Bike bike = new Bike("Bajaj",2010,"Enticer",113,"Cruise",250,2);
            bike.Accelerate();
            bike.Accelerate();
            bike.Accelerate();
            bike.Deaccelerate();
            bike.Stop();
            
            Car car = new Car("Honda",2014,"Amaze",60,"Sedan",4,"manual",4,false,true,true);

            Console.ReadKey();
        }
    }
    
}
