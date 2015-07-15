using System;

namespace Assignment9
{
    class Bike : Vehicle
    {
        private String typeOfBike;
        private int capacityOfEngine;
        private int currentGear;
        public Bike()
        {
                
        }
        public Bike(string make, int yearOfManufacture, string model, float speed, string typeOfBike, int capacityOfEngine, int currentGear)
            : base(make, yearOfManufacture, model, speed)
        {
            
            this.typeOfBike = typeOfBike;
            this.capacityOfEngine = capacityOfEngine;
            this.currentGear = currentGear;
        }
        public String TypeOfBike
        {
            get
            {
                return typeOfBike;
            }
            set
            {
                typeOfBike = value;
            }
        }
        public int CapacityOFEngine
        {
            get
            {
                return capacityOfEngine;
            }
            set
            {
                capacityOfEngine = value;
            }
        }
        public int CurrentGear
        {
            get
            {
                return currentGear;
            }
            set
            {
                currentGear = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 20;
        

                if ((Speed) < 10)
                {
                    currentGear = 1;
                    currentGear = 0;
                }
                else if (Speed < 30)
                {
                    currentGear = 2;
                }
                else if (Speed < 50)
                {
                    currentGear = 3;
                }
                else if (Speed < 70)
                {
                    currentGear = 4;
                }
                else
                    currentGear = 5;
            
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
                    currentGear = 1;
                }
                else if (Speed < 30)
                {
                    currentGear = 2;
                }
                else if (Speed < 50)
                {
                    currentGear = 3;
                }
                else if (Speed < 70)
                {
                    currentGear = 4;
                }
                else
                    currentGear = 5;
            
        }
        public override void Stop()
        {
            Speed = 0;
            currentGear = 0;
        }
        public override string ToString()
        { 
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture: " + YearOfManufacture  + "\nCurrent Speed: " + Speed + "\tCurrent Gear: " + currentGear + "\nType Of Bicycle: " + TypeOfBike + "\tCapacity Of Engine: " + capacityOfEngine;
        }
    }
}
