using COMP2129;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2129Proj
{
    internal class BookingsManager
    {

        private Bookings[] bookingslist;
        private int maxBookings;
        private int numOfBookings;
        private int Choice;

        public BookingsManager(int Choice, int MaxBookings)
        {
            bookingslist = new Bookings[MaxBookings];
            numOfBookings = 0;
            Choice = int.Parse(Console.ReadLine());
        }

        public static void showMenu()
        {
            Console.WriteLine("XYZ Airlines Limited");
            Console.WriteLine("Please select an option below");
            Console.WriteLine("1.Make Bookings ");
            Console.WriteLine("2.View Bookings");
        }


        public Bookings makeBookings(string date, Customer customer, Flight _flight, int bookingNumber)
        {
            if (Choice == 1)
                if (numOfBookings < maxBookings)
                {
                    bookingslist[maxBookings] = new Bookings(date, customer, bookingNumber, _flight);
                    numOfBookings++;
                    return bookingslist[maxBookings];

                }
            return bookingslist[maxBookings];
        }

        public Bookings viewBookings()
        {
            if (Choice == 2)
            {
                for (int i = 0; i < numOfBookings; i++)
                {
                   Console.Write(bookingslist[i]);
                
                }
            }

            return null; //maybe incorrect 
        }
    }
}