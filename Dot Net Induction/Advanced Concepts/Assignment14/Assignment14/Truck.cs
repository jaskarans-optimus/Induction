using System;

namespace Assignment12
{
    class Truck : Vehicle
    {
        private string _typeOfTrucks; //Light ,medium ,heavy weight trucks
        private float _maxWeight;
        private string _transmission;//auto or manual
        private float _width;
        private float _height;
        private int _currentGear;
        public Truck()
        {

        }
        public Truck(string make, int yearOfManufacture, string model, float speed, string typeOfTrucks, float maxWeight, string transmission, float width, float height, int currentGear)
            : base(make, yearOfManufacture, model, speed)
        {
            this.TypeOfTrucks = typeOfTrucks;
            this.MaxWeight = maxWeight;
            this.Transmission = transmission;
            this.Width = width;
            this.Height = height;
            this._currentGear = currentGear;
        }
        public string TypeOfTrucks
        {
            get
            {
                return _typeOfTrucks;
            }
            set
            {
                _typeOfTrucks = value;
            }
        }
        public float MaxWeight
        {
            get
            {
                return _maxWeight;
            }
            set
            {
                _maxWeight = value;
            }
        }
        public string Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                _transmission = value;
            }
        }
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }

        }
        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 10;
            if (_transmission.Equals("manual",StringComparison.InvariantCultureIgnoreCase))
            {

                if ((Speed) < 10)
                {
                    _currentGear = 1;
                }
                else if (Speed < 25)
                {
                    _currentGear = 2;
                }
                else if (Speed < 35)
                {
                    _currentGear = 3;
                }
                else if (Speed < 45)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
            }
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 10;
            if (Speed < 0)
            {
                Speed = 0; 
                _currentGear = 0;
            }
            if (_transmission.Equals("manual",StringComparison.InvariantCultureIgnoreCase))
            {

                if ((Speed) < 10)
                {
                    _currentGear = 1;
                }
                else if (Speed < 25)
                {
                    _currentGear = 2;
                }
                else if (Speed < 35)
                {
                    _currentGear = 3;
                }
                else if (Speed < 45)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
            }
        }
        public override void Stop()
        {
            Speed = 0;
            _currentGear = 0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture:" + YearOfManufacture + "\tTransmission:" +Transmission  + "\nCurrent Speed:" + Speed + "\tCurrent Gear" + _currentGear + "\nType Of Bicycle" + TypeOfTrucks + "\tMax Weight" + MaxWeight+"\nWidth"+Width+"\tHeight"+Height;
        }
    }
}
