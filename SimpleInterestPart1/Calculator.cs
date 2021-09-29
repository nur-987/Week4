using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestPart1
{
    public delegate void InterestEvent(int result);
    class Calculate
    {

        public event InterestEvent CalculateInterest;
        public int Principal { get; private set; }
        public int Interest { get; private set; }
        public int Time { get; private set; }

        public void GetPrincipal()
        {
            try
            {
                Console.WriteLine("Input Principal");
                Principal = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid! {ex.Message}");
            }

        }

        public void GetInterest()
        {
            try
            {
                Console.WriteLine("Input Interest");
                Interest = Int32.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid! {ex.Message}");
            }

        }

        public void GetTime()
        {
            try
            {
                Console.WriteLine("Input Time range");
                Time = Int32.Parse(Console.ReadLine());
            }


            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Invalid! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid! {ex.Message}");
            }

        }

        public void CalculateSimpleInt()
        {
            int result = 0;
            try
            {
                result = (Principal * Interest * Time) / 100;
                Console.WriteLine("Total Intrest is: " + result);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception raised {ex.Message}");
            }
            finally
            {
                if (CalculateInterest != null)
                {
                    CalculateInterest.Invoke(result);
                }
            }
        }
    }
}
