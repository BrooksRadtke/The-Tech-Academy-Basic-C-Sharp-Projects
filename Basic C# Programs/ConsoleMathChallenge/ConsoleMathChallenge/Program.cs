using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathChallenge
{
    class Program
    {
        static void Main()
        {
            int x;
            int y;
            int z;
            int a;
            int b;
            double result;
            bool getTruth;

            Console.WriteLine("Hi there! We're going to have some fun with numbers.");
            Console.WriteLine("To begin, type a number to multiply by 50:");
            x = Convert.ToInt32(Console.ReadLine());

            result = x * 50;
            Console.WriteLine("Ah yes, " + x + " * 50 is " + result);
            Console.ReadLine();

            Console.WriteLine("Let's try something else. Enter a number to add 25 to:");
            y = Convert.ToInt32(Console.ReadLine());

            result = y + 25;
            Console.WriteLine("Excellent " + y + " + 25 is " + result);
            Console.ReadLine();

            Console.WriteLine("Wonderful! Let's spice things up and divide a new number by 12.5");
            z = Convert.ToInt32(Console.ReadLine());

            result = z / 12.5;
            Console.WriteLine("That's wild! " + z + " / 12.5 is " + result);
            Console.ReadLine();

            Console.WriteLine("Enter a number, and I'll tell you if it's greater than 50:");
            a = Convert.ToInt32(Console.ReadLine());

            getTruth = a > 50;
            Console.WriteLine("The answer if " + a + " is always > 50 is " + getTruth);
            Console.ReadLine();

            Console.WriteLine("Ok, last one: give me a number, and I'll divide it by 7" +
                " and give you the remainder!");
            b = Convert.ToInt32(Console.ReadLine());

            result = b % 7;
            Console.WriteLine("Ta-da! The remainder of " + b + " / 7 is " + result);
            Console.ReadLine();

            Console.WriteLine("Thank you for all the fun! Good-bye!");
            Console.ReadLine();
        }
    }
}
