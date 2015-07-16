using System;
namespace Assignment9
{
    public class Vehicle
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

        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle("Hero",2002,"A234", 7.2f , true,0,"Road",2.8f);
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Accelerate();
            bicycle.Deaccelerate();
            Console.WriteLine("\nBicycle:\n"+bicycle);
            Bike bike = new Bike("Bajaj",2010,"Enticer",30,"Cruise",250,2);
            bike.Accelerate();
            bike.Accelerate();
            bike.Accelerate();
            bike.Deaccelerate();
            bike.Stop();
            Console.WriteLine("\nBike:\n" + bike);
            Car car = new Car("Honda",2014,"Amaze",60,"Sedan",4,"manual",4,false,true,true);
            Console.WriteLine("\nCar:\n" + car);

            Console.ReadKey();
        }
    }
    
}
