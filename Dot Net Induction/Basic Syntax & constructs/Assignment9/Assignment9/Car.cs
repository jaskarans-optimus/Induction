using System;

namespace Assignment9
{
    class Car : Vehicle
    {
        private String typeOfCar; //hatchback or SUV
        private int noOfPassengers; //No. of Passenger can travels
        private String transmission; //auto or manual
        private int currentGear;
        private bool sunRoof;
        private bool powerWindow;
        private bool powerSteering;
        public Car()
        {

        }
        public Car(string make, int yearOfManufacture, string model, float speed, string typeOfCar, int noOfPassengers, String transmission, int currentGear, bool sunRoof, bool powerWindow, bool powerSteering)
            : base(make, yearOfManufacture, model, speed)
        {
            this.typeOfCar = typeOfCar;
            this.noOfPassengers = noOfPassengers;
            this.transmission = transmission;
            this.currentGear = currentGear;
            this.sunRoof = sunRoof;
            this.powerSteering = powerSteering;
            this.powerWindow = powerWindow;
        }
        public String TypeOFCar
        {
            get
            {
                return typeOfCar;
            }
            set
            {
                typeOfCar = value;
            }
        }
        public int NoOfPassengers
        {
            get
            {
                return noOfPassengers;
            }
            set
            {
                noOfPassengers = value;
            }
        }
        public String Transmission
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
        public bool SunRoof
        {
            get
            {
                return sunRoof;
            }
            set
            {
                sunRoof = value;
            }
        }
        public bool PowerWindow
        {
            get
            {
                return powerWindow;
            }
            set
            {
                powerWindow = value;
            }
        }
        public bool PowerSteering
        {
            get
            {
                return powerSteering;
            }
            set
            {
                powerSteering = value;
            }
        }
        public override void Accelerate()
        {
            Speed = Speed + 20;
            if (transmission.Equals("manual", StringComparison.InvariantCultureIgnoreCase))
            {

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
        }
        public override void Deaccelerate()
        {
            Speed = Speed - 20;
            if (Speed < 0)
            {
                Speed = 0;
            }
            if (transmission.Equals("manual", StringComparison.InvariantCultureIgnoreCase))
            {

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
        }
        public override void Stop()
        {
            Speed = 0;
            currentGear = 0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYearOFManufacture:" + YearOfManufacture + "\tTransmission:" + transmission + "\nCurrent Speed:" + Speed + "\tCurrent Gear:" + currentGear + "\nType Of Bicycle:" + typeOfCar + "\tMax No. Of Passengers:" + noOfPassengers + "\nSunRoof:" + sunRoof + "\tPower Window:" + powerWindow;
        }
    }
}