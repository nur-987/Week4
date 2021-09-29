using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestPart1
{
    delegate void interestDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();

            //multi cast delegate
            interestDelegate interestDelegate = new interestDelegate(calculator.GetPrincipal);
            interestDelegate += calculator.GetInterest;
            interestDelegate += calculator.GetTime;
            interestDelegate += calculator.CalculateSimpleInt;

            //run the delegate with multiple funcs
            interestDelegate();

            //event on a 2nd delegate
            calculator.CalculateInterest += Calculator_CalculateInterest;

            Console.ReadLine();

        }

        private static void Calculator_CalculateInterest(int result)
        {
            Console.WriteLine("Simple interest is; " + result);
        }
    }
}
