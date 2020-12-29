using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main()
        {
            // Non-static instantiation
            //Operations obj1 = new Operations();
            
            Console.WriteLine("Input a number to be divided by 2:");
            int x = Convert.ToInt32(Console.ReadLine());
            // Static instantiation
            Operations.DividedBy(x);

            // Call overloaded method with output 
            Operations.DividedBy(out x);
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
