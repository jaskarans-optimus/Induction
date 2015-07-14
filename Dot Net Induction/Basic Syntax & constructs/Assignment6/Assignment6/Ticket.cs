using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Ticket
    {
        private double ticketFare;
        private String ticketClass;
        private DateTime arrivalTime;
        private DateTime depatureTime;
        public Ticket(double ticketFare, String ticketClass, DateTime arrivalTime, DateTime depatureTime)
        {
            this.ticketFare = ticketFare;
            this.ticketClass = ticketClass;
            this.arrivalTime = arrivalTime;
            this.depatureTime = depatureTime;
        }
        public double TicketFare
        {
            get
            {
                return ticketFare;
            }
            set
            {
                ticketFare = value;
            }

        }
        public String TicketClass
        {
            get
            {
                return ticketClass;
            }
            set
            {
                ticketClass = value;
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
        public void PrintTicket(Passenger passenger)
        {
            Console.WriteLine("\nPassenger Name:" + passenger.Name + " " + "Age : " + passenger.Age + " Sex : " + passenger.Sex + " \nAddress" + passenger.Address + " \nFare :" + TicketFare + "  Class:" + TicketClass + " \nArrival Time" + ArrivalTime + "  Depature Time" + DepatureTime);

        }

    }
}
