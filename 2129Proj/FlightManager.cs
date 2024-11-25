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


        public Flight deleteFlight(int deleteNum) //edit this seems too long of code
        {
            if (Choice == 3)
            {
                Console.WriteLine("Please enter Flight Number: ");
                var selectedNum = Console.ReadLine(); //read user input of the flight number 

                if (selectedNum == null) //if statement is used to check if user has entered a flight number 
                {
                    Console.WriteLine("Please provide a flight number.");
                    return null;
                }

                if (int.TryParse(selectedNum, out int flightNumber)) // line converts the selected num from a string to an integer called flight number 
                {
                    if (flightNumber == deleteNum)
                    {
                        int indexDelete = 0;
                        for (int i = 0; i < numOfFlights; i++)
                        {
                            if (flightList[i].flightNumber == deleteNum)
                            {
                                indexDelete = i;
                                break;
                            }
                        }

                        if (indexDelete != -1)
                        {

                            Flight deleteFlight = flightList[indexDelete];
                            Flight[] newFlightList = new Flight[numOfFlights - 1];

                            for (int j = 0; j < indexDelete; j++)
                            {
                                newFlightList[j] = flightList[j];
                            }

                            for (int k = indexDelete + 1; k < numOfFlights; k++)
                            {
                                newFlightList[k - 1] = flightList[k];
                            }


                            flightList = newFlightList;
                            numOfFlights = flightList.Length;

                            return deleteFlight;
                        }
                        else
                        {
                            Console.WriteLine("Flight not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The provided flight number does not match.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid flight number.");
                }
            }

            return null;
        }

        public Flight ViewParticularFlight(int flightNum)
        {
            if (Choice == 4) { 

            for (int i = 0; i <= numOfFlights; i++)
            {
                    if (flightList[i].flightNumber == flightNum)
                    {
                        Console.WriteLine(flightList[i]);
                    }

                   
            }
        }
            else
            {
               return null;
            }
               return null;
        
        }

        //public Flight BackToMainMenu ()
        //{ 

        //}

    }

    }


