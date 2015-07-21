using System;

namespace Assignment12
{
    class Car : Vehicle
    {
        private String _typeOfCar; //hatchback or SUV
        private int _noOfPassengers; //No. of Passenger can travels
        private String _transmission; //auto or manual
        private int _currentGear;
        private bool _sunRoof;
        private bool _powerWindow;
        private bool _powerSteering;
        public Car()
        {

        }
        public Car(string make, int yearOfManufacture, string model, float speed, string typeOfCar, int noOfPassengers, String transmission, int currentGear, bool sunRoof, bool powerWindow, bool powerSteering)
            : base(make, yearOfManufacture, model, speed)
        {
            this._typeOfCar = typeOfCar;
            this._noOfPassengers = noOfPassengers;
            this._transmission = transmission;
            this._currentGear = currentGear;
            this._sunRoof = sunRoof;
            this._powerSteering = powerSteering;
            this._powerWindow = powerWindow;
        }
        public String TypeOFCar
        {
            get
            {
                return _typeOfCar;
            }
            set
            {
                _typeOfCar = value;
            }
        }
        public int NoOfPassengers
        {
            get
            {
                return _noOfPassengers;
            }
            set
            {
                _noOfPassengers = value;
            }
        }
        public String Transmission
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
        public bool SunRoof
        {
            get
            {
                return _sunRoof;
            }
            set
            {
                _sunRoof = value;
            }
        }
        public bool PowerWindow
        {
            get
            {
                return _powerWindow;
            }
            set
            {
                _powerWindow = value;
            }
        }
        public bool PowerSteering
        {
            get
            {
                return _powerSteering;
            }
            set
            {
                _powerSteering = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 20;
            if (_transmission.Equals("manual", StringComparison.InvariantCultureIgnoreCase))
            {

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
                if (Speed > 200)
                {
                    throw new IsCarDeadException("Car has OverHeated", Speed);
                }
            }
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 20;
            if (Speed < 0)
            {
                throw new IsCarDeadException("Car speed cannot be negative ", Speed);
            }
            if (_transmission.Equals("manual", StringComparison.InvariantCultureIgnoreCase))
            {

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
        }
        public override void Stop()
        {
            Speed = 0;
            _currentGear = 0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture:" + YearOfManufacture + "\tTransmission:" + Transmission + "\nCurrent Speed:" + Speed + "\tCurrent Gear:" + CurrentGear + "\nType Of Bicycle:" + TypeOFCar + "\tMax No. Of Passengers:" + NoOfPassengers + "\nSunRoof:" + SunRoof + "\tPower Window:" + PowerWindow;
        }
    }
}