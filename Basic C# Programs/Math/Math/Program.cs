using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a basic math program where the user inputs values to view a result
            //Addition
            Console.WriteLine("Hello. This program is a simple math program");
            Console.ReadLine();
            Console.WriteLine("We will start with addition!");
            Console.ReadLine();

            int a = 2;
            int b = 2;
            int sum = a + b;

            Console.WriteLine("2 + 2 =");
            Console.ReadLine();
            Console.WriteLine(sum);
            Console.ReadLine();

            //Subtraction

            int c = 2;
            int d = 2;
            int difference = c - d;

            Console.WriteLine("Now subtraction:");
            Console.ReadLine();
            Console.WriteLine("2 - 2 =");
            Console.ReadLine();
            Console.WriteLine(difference);
            Console.ReadLine();

            //Multplication

            int e = 2;
            int f = 2;
            int product = e * f;

            Console.WriteLine("And multiplication:");
            Console.ReadLine();
            Console.WriteLine("2 * 2 =");
            Console.ReadLine();
            Console.WriteLine(product);
            Console.ReadLine();

            //Division

            int g = 2039481725;
            int h = 5;
            int division = g / h;

            Console.WriteLine("Finally, division:");
            Console.ReadLine();
            Console.WriteLine("What's 2,039,481,725 / 5 =");
            Console.ReadLine();
            Console.WriteLine(division + " of course.");
            Console.ReadLine();

            string part1 = "Thank you ";
            string part2 = "for using this program!";
            Console.WriteLine(part1 + part2);
            Console.ReadLine();
        }
    }
}
