using COMP2129;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2129Proj
{
    internal class FlightManager
    {

        private Flight[] flightList;
        private int Choice;
        private int numOfFlights;
        private int maxFlight;

        public FlightManager(int maxFlight, int Choice)
        {
            Choice = int.Parse(Console.ReadLine());
            numOfFlights = 0;
            flightList = new Flight[maxFlight];
        }




        public static void showMenu()
        {
            Console.WriteLine("XYZ Airlines Limited");
            Console.WriteLine("Flight Menu");
            Console.WriteLine("Please select choice from Menu below:");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. View Flight");
            Console.WriteLine("3. Delete Flight");
            Console.WriteLine("4. View particular Flight");
            Console.WriteLine("5. Back to Main Menu");



        }
        public Flight addFlight(int flightNumber, string origin, string destination, int maxSeats, int numOfPassengers)
        {
            if (Choice == 1)
            {
                if (numOfFlights < maxFlight)
                {
                    flightList[numOfFlights] = new Flight(flightNumber, origin, destination, maxSeats, numOfPassengers);
                    numOfFlights++;
                    return flightList[numOfFlights];
                }

            }
            return flightList[maxFlight];
        }


        public Flight viewFlights()
        {
            if (Choice == 2)
            {
                for (int i = 0; i < numOfFlights; i++)
                {
                    Console.WriteLine(flightList[i]);
                }
            }

            return null;
        }


        public Flight deleteFlight(int deleteNumber)
        {
            //handling for flight number user enters 
            Console.WriteLine("Please enter the number of the flight you want to delete: ");
            Console.ReadLine();
            if (Choice == 3)
            {
                for (int i = 0; i < numOfFlights; i++)
                {
                    if (flightList[i].flightNumber == deleteNumber)
                    {
                        
                    }
                }
            }
        }

        public Flight deleteFlight(int deleteNum)
        {
            if (Choice == 3)
            {
                Console.WriteLine("Pleace enter Flight Number: ");
                var selectedNum = Console.ReadLine();
                if(selectedNum == null)
                {
                    Console.WriteLine("Please put in flight number.");

                }
                else if(selectedNum == deleteNum.ToString()) 
                {
                        for (int i = 0; i < numOfFlights; i++) 
                        { 
                            
                        
                        }
                }
            
            }
    }


    }
 
    





}


