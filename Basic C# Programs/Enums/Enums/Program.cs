using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.WriteLine("Hello! Please enter what day it is today:");
                string userInput = Convert.ToString(Console.ReadLine());
                // Converts enum to string, which is used to check with userInput string
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine(userInput);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter a day that actually exists on the" +
                    " gregorian calendar, wise-guy...");
            }
            finally
            {
                Console.WriteLine("Oh yes. Thank you for reminding me!");
                Console.ReadLine();
            }
        }

        // Create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
