using System;

namespace Assignment9
{
    class Bike : Vehicle
    {
        private String _typeOfBike;
        private int _capacityOfEngine;
        private int _currentGear;
        public Bike()
        {
                
        }
        public Bike(string make, int yearOfManufacture, string model, float speed, string typeOfBike, int capacityOfEngine, int currentGear)
            : base(make, yearOfManufacture, model, speed)
        {
            
            this._typeOfBike = typeOfBike;
            this._capacityOfEngine = capacityOfEngine;
            this._currentGear = currentGear;
        }
        public String TypeOfBike
        {
            get
            {
                return _typeOfBike;
            }
            set
            {
                _typeOfBike = value;
            }
        }
        public int CapacityOFEngine
        {
            get
            {
                return _capacityOfEngine;
            }
            set
            {
                _capacityOfEngine = value;
            }
        }
        public int CurrentGear
        {
            get
            {
                return _currentGear;
            }
            set
            {
                _currentGear = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 20;
        

                if ((Speed) < 10)
                {
                    _currentGear = 1;
                    _currentGear = 0;
                }
                else if (Speed < 30)
                {
                    _currentGear = 2;
                }
                else if (Speed < 50)
                {
                    _currentGear = 3;
                }
                else if (Speed < 70)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
            
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 20;
            if (Speed < 0)
            {
                Speed = 0;
            }
                if ((Speed) < 10)
                {
                    _currentGear = 1;
                }
                else if (Speed < 30)
                {
                    _currentGear = 2;
                }
                else if (Speed < 50)
                {
                    _currentGear = 3;
                }
                else if (Speed < 70)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
            
        }
        public override void Stop()
        {
            Speed = 0;
            _currentGear = 0;
        }
        public override string ToString()
        { 
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture: " + YearOfManufacture  + "\nCurrent Speed: " + Speed + "\tCurrent Gear: " +CurrentGear + "\nType Of Bicycle: " + TypeOfBike + "\tCapacity Of Engine: " + CapacityOFEngine;
        }
    }
}
