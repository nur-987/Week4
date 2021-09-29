using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Customer
    {
        public int ID{ get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public static List<Customer> CustomerList = new List<Customer>();

        public Customer(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }

        public static void AddingCust(int id, string name, string address)
        {
            Customer customer = new Customer(id, name, address)
            {
                ID = id,
                Name = name,
                Address = address
            };

            CustomerList.Add(customer);

        }

        public static void DisplayAll()
        {
            foreach(Customer item in CustomerList)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Address);
            }
        }

        public void DisplaySelected(int i)
        {
            foreach (Customer item in CustomerList)
            {
                if(item.ID == i)
                {
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Address);
                }
                else
                {
                    Console.WriteLine("No such customer");
                }
            }
        }
    }




}
