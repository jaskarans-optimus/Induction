using System;

namespace Assignment12
{
    class Bicycle : Vehicle
    {
        private bool _isGearPresent;
        private int _currentGear;
        private String _typeOfBicycle; //like Road Bicycles,touring bicycles 
        private float _sizeOfTire;
  
        public Bicycle()
        {

        }
        public Bicycle(string make, int yearOfManufacture, string model, float speed, bool isGearPresent, int currentGear, string typeOfBicycle, float sizeOfTire) : base(make,yearOfManufacture,model,speed)
        {
            this._isGearPresent = isGearPresent;
            this._currentGear = currentGear;
            this._typeOfBicycle = typeOfBicycle;
            this._sizeOfTire = sizeOfTire;
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
        public string TypeOfBicycle
        {
            get
            {
                return _typeOfBicycle;
            }
            set
            {
                _typeOfBicycle = value;
            }
        }
        public float SizeOfTire
        {
            get
            {
                return _sizeOfTire;
            }
            set
            {
                _sizeOfTire = value;
            }
        }
        public bool IsGearPresent 
        {
            get
            {
                return _isGearPresent;
            }
            set
            {
                _isGearPresent = value;
            }
        }
        public void ForwardGear()
        {
            _currentGear++;
        }
        public void ReverseGear()
        {
            _currentGear--;
        }
        public override void Accelerate()
        {
            Speed=Speed+10;
            if (_isGearPresent)
            {

                if ((Speed) < 5)
                {
                    _currentGear = 1;
                }
                else if (Speed < 10)
                {
                    _currentGear = 2;
                }
                else if (Speed < 15)
                {
                    _currentGear = 3;
                }
                else if (Speed < 20)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
                
            }
            if (Speed > 100)
            {
                throw new IsCarDeadException("Bicycle cannit go above 100km/hr", Speed);
            }
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 10;
            if (Speed < 0)
            {
                throw new IsCarDeadException("Bicycle Stopped", Speed);  
            }
            if (_isGearPresent)
            {

                if ((Speed) < 10)
                {
                    _currentGear = 1;
                }
                else if (Speed < 20)
                {
                    _currentGear = 2;
                }
                else if (Speed < 30)
                {
                    _currentGear = 3;
                }
                else if (Speed < 40)
                {
                    _currentGear = 4;
                }
                else
                    _currentGear = 5;
            }
        }
        public override void Stop()
        {
            Speed=0;
            _currentGear=0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYear Of Manufacture:" + YearOfManufacture + "\tGear:" + IsGearPresent + "\nCurrent Speed:" + Speed + "\tCurrent Gear" + CurrentGear + "\nType Of Bicycle: " + TypeOfBicycle + "\tSize of Tire: " + SizeOfTire;
        }
    }
}
