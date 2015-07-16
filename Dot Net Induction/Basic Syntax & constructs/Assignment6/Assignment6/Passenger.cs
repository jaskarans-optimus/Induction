using System;

namespace Assignment6
{
    public class Passenger
    {
        private String _name;
        private int _age;
        private char _sex;
        private String _address;
        public Passenger(String _name, int _age, char sex, String _address)
        {
            this._name = _name;
            this._age = _age;
            this._sex = _sex;
            this._address = _address;
        }
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public char Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        public String Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
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
