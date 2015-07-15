using System;

namespace Assignment6
{
    public class Passenger
    {
        private String name;
        private int age;
        private char sex;
        private String address;
        public Passenger(String name, int age, char sex, String address)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.address = address;
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public char Sex
        {
            get
            {
                return ;
            }
            set
            {
                age = value;
            }
        }
        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public String Reservation();
        // Passenger uses this method for reservation of train

        public void Cancellation();
        //Passenger uses this method to cancell the tickets
        public void CheckForAvailability(Train train);
        //Passenger passes train details to check its availability
    }
}
