using System;
namespace Assignment9
{
    public class Vehicle
    {
        private string make;
        private int yearOfManufacture;
        private string model;
        private float speed;
        public Vehicle()
        {

        }
        public Vehicle(string make, int yearOfManufacture, string model, float speed)
        {
            this.make = make;
            this.yearOfManufacture = yearOfManufacture;
            this.model = model;
            this.speed = speed;
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public int YearOfManufacture
        {
            get
            {
                return yearOfManufacture;
            }
            set
            {
                yearOfManufacture = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public float Speed
        {
            get
            {
                return speed;

            }
            set
            {
                speed = value;
            }

        }
        public virtual void Accelerate()
        {
            speed = speed + 10;
        }
        public virtual void Deaccelerate()
        {
            
            speed = speed - 10;
            if (speed < 0)
            {
                speed = 0;
            }
        }
        public virtual void Stop()
        {
            speed = 0;
        }
        public bool isMoving()
        {
            if (speed != 0)
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
