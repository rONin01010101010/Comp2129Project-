using COMP2129;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2129Proj
{
    internal class Bookings
    {

        private string date;
        private Customer customer;
        private Flight _flight;
        private int bookingNumber;

        public Bookings(string date, Customer customer, Flight _flight, int bookingNumber)
        {
            this.date = date;
            this._flight = _flight;
            this.bookingNumber = bookingNumber;
        }

        public Bookings(string date, Customer customer, int bookingNumber, Flight flight)
        {
            this.date = date;
            this.customer = customer;
            this.bookingNumber = bookingNumber;
        }

        public string getDate()
        {
            this.date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            return date;
        }

        public int getBookingNumber()
        {
            return bookingNumber;
        }

        public Flight getFlight()
        {
            return _flight;
        }

        public Customer getCustomer()
        {
            return customer;
        }





    }
}
