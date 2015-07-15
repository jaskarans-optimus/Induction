using System;

namespace Assignment9
{
    class Truck : Vehicle
    {
        private string typeOfTrucks; //Light ,medium ,heavy weight trucks
        private float maxWeight;
        private string transmission;//auto or manual
        private float width;
        private float height;
        private int currentGear;
        public Truck()
        {

        }
        public Truck(string make, int yearOfManufacture, string model, float speed, string typeOfTrucks, float maxWeight, string transmission, float width, float height, int currentGear)
            : base(make, yearOfManufacture, model, speed)
        {
            this.typeOfTrucks = typeOfTrucks;
            this.maxWeight = maxWeight;
            this.transmission = transmission;
            this.width = width;
            this.height = height;
            this.currentGear = currentGear;
        }
        public string TypeOfTrucks
        {
            get
            {
                return typeOfTrucks;
            }
            set
            {
                typeOfTrucks = value;
            }
        }
        public float MaxWeight
        {
            get
            {
                return maxWeight;
            }
            set
            {
                maxWeight = value;
            }
        }
        public string Transmission
        {
            get
            {
                return transmission;
            }
            set
            {
                transmission = value;
            }
        }
        public float Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }

        }
        public float Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 10;
            if (transmission.Equals("manual",StringComparison.InvariantCultureIgnoreCase))
            {

                if ((Speed) < 10)
                {
                    currentGear = 1;
                }
                else if (Speed < 25)
                {
                    currentGear = 2;
                }
                else if (Speed < 35)
                {
                    currentGear = 3;
                }
                else if (Speed < 45)
                {
                    currentGear = 4;
                }
                else
                    currentGear = 5;
            }
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 10;
            if (Speed < 0)
            {
                Speed = 0; 
                currentGear = 0;
            }
            if (transmission.Equals("manual",StringComparison.InvariantCultureIgnoreCase))
            {

                if ((Speed) < 10)
                {
                    currentGear = 1;
                }
                else if (Speed < 25)
                {
                    currentGear = 2;
                }
                else if (Speed < 35)
                {
                    currentGear = 3;
                }
                else if (Speed < 45)
                {
                    currentGear = 4;
                }
                else
                    currentGear = 5;
            }
        }
        public override void Stop()
        {
            Speed = 0;
            currentGear = 0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture:" + YearOfManufacture + "\tTransmission:" +transmission  + "\nCurrent Speed:" + Speed + "\tCurrent Gear" + currentGear + "\nType Of Bicycle" + typeOfTrucks + "\tMax Weight" + maxWeight+"\nWidth"+width+"\tHeight"+height;
        }
    }
}
