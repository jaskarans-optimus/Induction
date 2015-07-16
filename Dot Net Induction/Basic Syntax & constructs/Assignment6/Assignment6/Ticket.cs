using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Ticket
    {
        private double _ticketFare;
        private String _ticketClass;
        private DateTime _arrivalTime;
        private DateTime _depatureTime;
        public Ticket(double _ticketFare, String _ticketClass, DateTime _arrivalTime, DateTime _depatureTime)
        {
            this._ticketFare = _ticketFare;
            this._ticketClass = _ticketClass;
            this._arrivalTime = _arrivalTime;
            this._depatureTime = _depatureTime;
        }
        public double TicketFare
        {
            get
            {
                return _ticketFare;
            }
            set
            {
                _ticketFare = value;
            }

        }
        public String TicketClass
        {
            get
            {
                return _ticketClass;
            }
            set
            {
                _ticketClass = value;
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
        public void PrintTicket(Passenger passenger)
        {
            Console.WriteLine("\nPassenger Name:" + passenger.Name + " " + "Age : " + passenger.Age + " Sex : " + passenger.Sex + " \nAddress" + passenger.Address + " \nFare :" + TicketFare + "  Class:" + TicketClass + " \nArrival Time" + ArrivalTime + "  Depature Time" + DepatureTime);

        }

    }
}
