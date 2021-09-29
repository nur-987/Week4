using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Q5- Write a program to enter customer information to the customer collection. 
/// Customer information can contain id, name, address etc. 
/// Write methods and/or indexers to access the customer information by id and name.
/// if you access an customer information which is not present handle the exception and show appropriate messages.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Customer details would you like to see..");
            Console.WriteLine("Please input the customer's ID");
            int input = Int32.Parse(Console.ReadLine());

            Customer customer = new Customer();
            customer.SearchandDisplay(input);

            Console.ReadLine();



        }
    }
}
