using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Train
    {
        private int _number;
        private String _name;
        private String _source;
        private String _destination;
        private DateTime _arrivalTime;
        private DateTime _depatureTime;
        private double _fare;
        public Train(String name, String source, String destination, DateTime arrivalTime, DateTime depatureTime, double fare)
        {
            this._name = name;
            this._source = source;
            this._destination = destination;
            this._arrivalTime = arrivalTime;
            this._depatureTime = depatureTime;
            this._fare = fare;
        }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
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
        public String Source
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }
        public String Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }
        public DateTime ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                _arrivalTime = value;
            }
        }
        public DateTime DepatureTime
        {
            get
            {
                return _depatureTime;
            }
            set
            {
                _depatureTime = value;
            }
        }
        public double Fare
        {
            get
            {
                return _fare;
            }
            set
            {
                _fare = value;
            }


        }
        public override string ToString()
        {
            return "Train Information : \nName:" + Name + "\t" + "Train Number : " + Number + "\n Source Station : " + Source + "\t" + " Destination Station : " + Destination + "\nArrival Time : " + ArrivalTime + "\t" + "Departure Time : " + DepatureTime;
        }
    }
}
