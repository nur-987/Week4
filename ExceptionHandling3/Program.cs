using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    /// <summary>
    /// Q4- Create an array with 10 integers, 
    ///Write an indexer to access its values and set values.
    ///Handle the exception if an unknown index is accessed and set.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyIndex index = new MyIndex();
            index[0] = 1;
            index[1] = 2;
            index[2] = 3;
            index[3] = 4;
            index[4] = 5;
            index[5] = 6;
            index[6] = 1;
            index[7] = 2;
            index[8] = 3;
            index[9] = 4;

            //to see the number on selected index

            Console.WriteLine("Input index num you would like to see");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(index[a]);

            //to set new number

            Console.WriteLine("Input index num you would like to set");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input a new number..");
            int c = Int32.Parse(Console.ReadLine());
            index[b] = c;
            Console.WriteLine("new number in selected index: " + c);

            Console.ReadLine();

        }
    }

    class MyIndex
    {
        private int[] myArry = new int[10];

        public int this[int i]
        {
            get { return myArry[i]; }
            set { myArry[i] = value; }
        }


    }
}
