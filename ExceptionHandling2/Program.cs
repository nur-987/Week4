using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    /// <summary>
    /// Q3- Create a stack to add integers to stack, implement Push and Pop. 
    ///Handle the exceptions which can handle conditions 
    ///if you pop more than available items from stack.
    /// </summary>
    class Program
    {
        public static Stack<int> myStack = new Stack<int>();

        static void Main(string[] args)
        {
            bool b = true;
            Console.WriteLine("Welcome to stack application");
            while (b)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Add numbers       2) Take away numbers    3)Display All   4)Quit");
                int input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Input the number you would like to add");
                    int tempNum = Int32.Parse(Console.ReadLine());
                    Add(tempNum);
                }
                else if (input == 2)
                {
                    Delete();
                }
                else if (input == 3)
                {
                    Display();
                }
                else if (input == 4)
                {
                    Console.WriteLine("Exiting..........");
                    b = false;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again");
                }
            }
           

        }

        public static void Add(int i)
        {
            try
            {
                myStack.Push(i);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            

        }
        public static void Delete()
        {
            try
            {
                myStack.Pop();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("unable to perform action");
                Console.WriteLine($"{ex.Message}");
            }


        }
        public static void Display()
        {
            Console.WriteLine("The numbers in the stack are: ");

            foreach (int i in myStack)
            {
                Console.Write(i+", ");
            }
        }
    }
}
