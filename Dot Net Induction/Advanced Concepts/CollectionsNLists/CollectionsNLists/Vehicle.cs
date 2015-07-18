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

    }
    
}
