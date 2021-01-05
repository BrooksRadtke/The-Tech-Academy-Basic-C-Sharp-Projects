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

            // Instantiate a new obj of chained constructors
            Foo foo1 = new Foo();
            Console.WriteLine(foo1);
            Console.ReadLine();
        }
    }
}
