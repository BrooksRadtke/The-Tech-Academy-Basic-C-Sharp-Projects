using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main()
        {
            // Instantiate the class
            Operations obj1 = new Operations();

            // Call the method in the class, passing in 2 numbers
            obj1.Assignment(5, 3);
            Console.ReadLine();

            // Call the method in the class, specify parameters by name
            // This changes the default values to specified ones
            obj1.Assignment(y: 10, x: 20);
            Console.ReadLine();
        }
    }
}
