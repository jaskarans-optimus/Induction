using System;

namespace Assignment9
{
    class Bicycle : Vehicle
    {
        private bool isGearPresent;
        private int currentGear;
        private String typeOfBicycle; //like Road Bicycles,touring bicycles 
        private float sizeOfTire;
  
        public Bicycle()
        {

        }
        public Bicycle(string make, int yearOfManufacture, string model, float speed, bool isGearPresent, int currentGear, string typeOfBicycle, float sizeOfTire) : base(make,yearOfManufacture,model,speed)
        {
            this.isGearPresent = isGearPresent;
            this.currentGear = currentGear;
            this.typeOfBicycle = typeOfBicycle;
            this.sizeOfTire = sizeOfTire;
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
        public string TypeOfBicycle
        {
            get
            {
                return typeOfBicycle;
            }
            set
            {
                typeOfBicycle = value;
            }
        }
        public float SizeOfTire
        {
            get
            {
                return sizeOfTire;
            }
            set
            {
                sizeOfTire = value;
            }
        }
        public bool IsGearPresent 
        {
            get
            {
                return isGearPresent;
            }
            set
            {
                isGearPresent = value;
            }
        }
        public void ForwardGear()
        {
            currentGear++;
        }
        public void ReverseGear()
        {
            currentGear--;
        }
        public override void Accelerate()
        {
            Speed=Speed+10;
            if (isGearPresent)
            {

                if ((Speed) < 5)
                {
                    currentGear = 1;
                }
                else if (Speed < 10)
                {
                    currentGear = 2;
                }
                else if (Speed < 15)
                {
                    currentGear = 3;
                }
                else if (Speed < 20)
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
            if (isGearPresent)
            {

                if ((Speed) < 10)
                {
                    currentGear = 1;
                }
                else if (Speed < 20)
                {
                    currentGear = 2;
                }
                else if (Speed < 30)
                {
                    currentGear = 3;
                }
                else if (Speed < 40)
                {
                    currentGear = 4;
                }
                else
                    currentGear = 5;
            }
        }
        public override void Stop()
        {
            Speed=0;
            currentGear=0;
        }
        public override string ToString()
        {
            return "Make:" + Make + "\tModel:" + Model + "\nYear Of Manufacture:" + YearOfManufacture + "\tGear:" + IsGearPresent + "\nCurrent Speed:" + Speed + "\tCurrent Gear" + currentGear + "\nType Of Bicycle: " + TypeOfBicycle + "\tSize of Tire: " + sizeOfTire;
        }
    }
}
