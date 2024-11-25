using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2129Proj
{
    internal class CustomerManager
    {

        private Customer[] CustomerList;
        private int Choice;
        private int numOfCustomers;
        private int maxCustomers; 
    
       public CustomerManager(int Choice, int maxCustomers )
        {
            CustomerList = new Customer[maxCustomers];
            numOfCustomers = 0;
            this.Choice = int.Parse(Console.ReadLine());
        }
    


      public static void showMenu()
        {
            Console.WriteLine("XYZ Airlines Limited");
            Console.WriteLine("Please select an option below");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.View Customer");
        }
    public Customer addCustomer(string name, string phone, string customerID, Bookings numOfBookings)
        {
            if (Choice == 1) 
            {
                if (numOfCustomers < maxCustomers)
                {
                    CustomerList[maxCustomers] = new Customer( name,  phone,  customerID,numOfBookings);
                    numOfCustomers++;
                    return CustomerList[maxCustomers];
                }
            
            
            }
            return CustomerList[maxCustomers];
        }

        public Customer viewCustomer()
        {
            if (Choice == 2)
            {
                for (int i = 0; i < CustomerList.Length; i++)
                {
                    Console.WriteLine(CustomerList[i]);

                }

            }


            return null; //maybe incorrect     
          



        }
    
    }
}
