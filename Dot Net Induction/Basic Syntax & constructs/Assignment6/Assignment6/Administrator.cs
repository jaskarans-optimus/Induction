using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Administrator
    {
        private String name;
        private int age;
        private char sex;
        private String address;
        public Administrator(String name, int age, char sex, String address)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.address = address;
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
                return sex;
            }
            set
            {
                sex = value;
            }
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
        public void Authentication();
        // admin uses this method to gain access to the server

        public Boolean GenerateTicket(Passenger passenger);
        // this method is used for generating ticket by passing passenger details
    }
}
