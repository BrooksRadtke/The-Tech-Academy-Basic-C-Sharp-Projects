using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptParmMethod
{
    class Program
    {
        static void Main()
        {
            // Instantiate the class
            Operations obj1 = new Operations();

            // Ask user for input
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a second number, or skip by " +
                "entering nothing:");
            int y = Convert.ToInt32(Console.ReadLine());

            // Pass values to method
            obj1.Addition(x,y);

            Console.WriteLine(x + " + " + y + " = " + obj1.Addition(x,y), obj1.Addition(x, y));
            Console.ReadLine();
        }
    }
}
