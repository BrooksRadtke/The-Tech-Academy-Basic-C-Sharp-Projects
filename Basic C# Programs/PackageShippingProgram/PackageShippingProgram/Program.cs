using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingProgram
{
    class Program
    {
        static void Main()
        {
            //introduction
            Console.WriteLine("Welcome to Package Express. " +
                "Please follow the instructions below: ");
            Console.ReadLine();

            //takes weight input from user
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Checks if weight is too high
            if(weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. " +
                    "Have a good day.");
                Console.ReadLine();
            }
            //if the package is less than 50, continue with the process
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                //checks the package meets the volume requirement
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                //if the package height is less than 50, continue with the process
                else
                {   
                    //variable included in this 'else' statement because
                    //they are local to each block of the branches. 
                    //Next time, store globally....
                    int shippingCost = ((width * height * length) * weight) / 100;
                    Console.WriteLine("Your estimated shipping cost for this package " +
                        "is: $" + shippingCost + ".00 \nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
