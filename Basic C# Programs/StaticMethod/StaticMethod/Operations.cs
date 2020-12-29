using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    static class Operations
    {
        // Create a void method that outputs an int
        // Data passed into it is divided by 2
        public static void DividedBy(int x)
        {
            int product = x / 2;
            Console.WriteLine(x + " / 2 = " + product);
        }

        // Create a method with output parameters
        // Overload a method
        // Declare class static
        public static void DividedBy(out int x)
        {
            x = 30;
            x += x;
            Console.WriteLine();
        }
    }
}
