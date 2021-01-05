using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for their age
                Console.WriteLine("Hello. How old are you?");
                var age = Convert.ToInt32(Console.ReadLine());

                var today = DateTime.Today;
                var yearBorn = today.Year - age;
                bool validAnswer = false;
                while(!validAnswer)
                {
                    if (age < 1)
                    {
                        // Displays error message if input is less than 1
                        throw new Exception();
                    }
                    else if (age > 150)
                    {
                        // Displays error if input is over a range
                        throw new TooOldException();
                    }
                    else if (!validAnswer)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        // Display the year the user was born
                        Console.WriteLine("You were born {0}", yearBorn);
                        Console.ReadLine();
                    }
                }
            }
            // Thrown exception in the case of decimals or strings
            catch(FormatException)
            {
                Console.WriteLine("Please only enter whole numbers");
                Console.ReadLine();
            }
            // Thrown to catch unlikely ages
            catch(TooOldException)
            {
                Console.WriteLine("You're old enough to be my great, great, great...");
                Console.ReadLine();
            }
            // Thrown if user input is less that 1
            catch(Exception)
            {
                Console.WriteLine("Sorry, only enter an age equivalent to the " +
                    "number of rotations you have been on around the Sun relative to Earth.");
                Console.ReadLine();
            }
        }
    }
}
