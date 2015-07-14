using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Train
    {
        private int number;
        private String name;
        private String source;
        private String destination;
        private DateTime arrivalTime;
        private DateTime depatureTime;
        private double fare;
        public Train(String name, String source, String destination, DateTime arrivalTime, DateTime depatureTime, double fare)
        {
            this.name = name;
            this.source = source;
            this.destination = destination;
            this.arrivalTime = arrivalTime;
            this.depatureTime = depatureTime;
            this.fare = fare;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
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
        public String Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }
        public String Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public DateTime ArrivalTime
        {
            get
            {
                return arrivalTime;
            }
            set
            {
                arrivalTime = value;
            }
        }
        public DateTime DepatureTime
        {
            get
            {
                return depatureTime;
            }
            set
            {
                depatureTime = value;
            }
        }
        public double Fare
        {
            get
            {
                return fare;
            }
            set
            {
                fare = value;
            }


        }
        public override string ToString()
        {
            return "Train Information : \nName:" + Name + "\t" + "Train Number : " + Number + "\n Source Station : " + Source + "\t" + " Destination Station : " + Destination + "\nArrival Time : " + ArrivalTime + "\t" + "Departure Time : " + DepatureTime;
        }
    }
}
