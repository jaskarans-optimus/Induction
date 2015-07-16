using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Administrator
    {
        private String _name;
        private int _age;
        private char _sex;
        private String _address;
        public Administrator(String _name, int _age, char _sex, String _address)
        {
            this._name = _name;
            this._age = _age;
            this._sex = _sex;
            this._address = _address;
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
        public void Authentication();
        // admin uses this method to gain access to the server

        public Boolean GenerateTicket(Passenger passenger);
        // this method is used for generating ticket by passing passenger details
    }
}
