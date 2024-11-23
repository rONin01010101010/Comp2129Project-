using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2129Proj
{
    internal class Customer
    {

        private string name;
        private string phone;
        private string customerID;
        private Bookings numOfBookings;

        public Customer(string name, string phone, string customerID, Bookings numOfBookings)
        {
            this.name = name;
            this.phone = phone;
            this.customerID = customerID;
            this.numOfBookings = numOfBookings;
        }


        public string getPhone()
        {
            return phone;
        }

        public string getName()
        {
            return name;
        }

        public string getCustomerID()
        {
            Random rand = new Random();
            this.customerID = rand.Next().ToString();
            return this.customerID;
        }

        public Bookings getNumOfBookings()
        {
            return numOfBookings;
        }


    }
}
