using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    /// <summary>
    /// Q1- Write a program which can take two integers to multiply and divide.
    /// Handle different Exceptions e.g.divide by zero exception, overflow exception etc.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("Please input in the first number");

            num1 = GetIntegerInput(num1);

            Console.WriteLine("Please input in the second number");
            int num2 = Int32.Parse(Console.ReadLine());

            Calculate(num1, num2);
        }

        //instead of having try catch for int.Parse in Main method
        //put it in a function instead
        private static int GetIntegerInput(int num1)
        {
            try
            {
                num1 = Int32.Parse(Console.ReadLine());

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }

            return num1;
        }

        public static void Calculate(int x, int y)
        {
            try
            {
                int res1 = (x / y);
                int res2 = (x * y);
                Console.WriteLine("Divide Answer: " + res1);
                Console.WriteLine("Mulitply Answer: " + res2);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to calculate");
                Console.WriteLine($"{ex.Message}");
            }
            
            
        }
    }
}
