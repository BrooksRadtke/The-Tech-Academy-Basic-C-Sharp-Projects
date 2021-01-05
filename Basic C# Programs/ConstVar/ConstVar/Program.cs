using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const string lineOne = "Hello there!";

            // Create a variable with the 'var' keyword
            var lineTwo = "It's a beautiful day in the neighborhood!";

            // Chain two constructors together
            Console.WriteLine(lineOne + " " + lineTwo);
            Console.ReadLine();
        }
    }
}
