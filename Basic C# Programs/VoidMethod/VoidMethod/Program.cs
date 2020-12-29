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

            // Pass in two numbers
            // How can it return values if VOID?
            Console.WriteLine(obj1.Assignment(5, 3));
        }
    }
}
