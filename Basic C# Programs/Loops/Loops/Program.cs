using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;  //comparison expression, remains false until value it met
            bool looping = true;

            // Demonstrates while loop
            while(looping)
            {
                // Demonstrates do while loop
                do
                {
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number:");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number:");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number:");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. That's correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("Sorry. Try again.");
                            Console.WriteLine("Guess a number:");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                }
                while (!isGuessed);
                looping = false;
                Console.Read();
            }
        }
    }
}
