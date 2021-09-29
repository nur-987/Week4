using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    /// <summary>
    /// Hover on methods to see the exceptions u need to handle
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ExceptionHandling();
            Console.ReadLine();

            Console.WriteLine("Type a number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type a number");
            int b = Int32.Parse(Console.ReadLine());

            CarryOutAction(a, b);
            Console.ReadLine();
            #endregion

            Console.ReadLine();
        }

        #region
        private static void ExceptionHandling()
        {
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                int res = a / 0;

                int[] b = new int[5] { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= 5; i++)
                {
                    //trying to access the 6th
                }
                object obj = 12;
                string str = (string)obj;
            }
            //ex predefined by c#
            catch (FormatException ex) //only this exptn will be handed 
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
                //catch blk cannot be empty
                //cos it isnt "handling"
            }
            //Generic ex to handel all
            catch (Exception ex)
            {
                //Always at the last of a list of exptn
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            finally
            {
                //always run irrespective of wether it pass or was catched. 
                //eg: to close a con string, save a file
            }
        }
        #endregion

        private static void CarryOutAction(int a, int b)
        {
            try
            {
                int res = a / b;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block!");
            }

        }
    }
    }
}
