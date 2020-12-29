using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Operations
    {
        // Create a void method that takes 2 assigned parameters
        public void Assignment(int x = 5, int y = 3)
        {
            // Do a math operation on parm 1
            int sum = x + 5;
            Console.WriteLine(x + " + 5 = " + sum);

            // Display int parm 2 to screen
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
