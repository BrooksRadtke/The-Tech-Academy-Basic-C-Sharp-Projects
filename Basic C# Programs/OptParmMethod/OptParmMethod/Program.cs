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
            string y = Console.ReadLine();

            //Checks if input for 2ns number was null or empty
            bool b1 = string.IsNullOrEmpty(y);

            // Converts value of input if !null
            if(b1 != true)
            {
                int z = Convert.ToInt32(y);

                // Pass values to method
                obj1.Addition(x, z);

                Console.WriteLine(x + " + " + z + " = " + obj1.Addition(x, z), obj1.Addition(x, z));
                Console.ReadLine();
            }
            else
            {
                // Passes in default value!
                Console.WriteLine(x + " + 1 = " + obj1.Addition(x), obj1.Addition(x));
                Console.ReadLine();
            }
        }
    }
}
