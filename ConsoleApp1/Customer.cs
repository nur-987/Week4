using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; } 

      public static Customer[] arrayCust = new Customer[4];
        public static List<Customer> custList = new List<Customer>();

        Customer customer1 = new Customer()
        {
            CustId = 1,
            CustName = "aaa",
            CustAddress = "xxx"
        };
        Customer customer2 = new Customer()
        {
            CustId = 2,
            CustName = "bbb",
            CustAddress = "zzz"
        };
        Customer customer3 = new Customer()
        {
            CustId = 3,
            CustName = "ccc",
            CustAddress = "qqq"
        };
        Customer customer4 = new Customer()
        {
            CustId = 4,
            CustName = "eee",
            CustAddress = "hhh"
        };

        public void AddCust()
        {
         // List<Customer> custList = new List<Customer>();
            custList.Add(customer1);
            custList.Add(customer2);
            custList.Add(customer3);
            custList.Add(customer4);

            //Customer[] arrayCust = new Customer[4];
            //arrayCust.Append(customer1);
            //arrayCust.Append(customer2);
            //arrayCust.Append(customer3);
            //arrayCust.Append(customer4);

        }

        public void SearchandDisplay(int indexNum)
        {
            Console.WriteLine(arrayCust[indexNum].CustId);


        }


    }
}
