using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethodTypes
{
    class Program
    {
        static void Main(string[] args)
        {   // **STEP 226**
            // Instantiate the class and pass in an int
            Operations obj1 = new Operations();
            obj1.Addition(5);
            Console.WriteLine(obj1.Addition(5));
            Console.ReadLine();

            // Passing in decimal, returning int
            Operations obj2 = new Operations();
            obj2.Decimal(12.75m);
            Console.WriteLine(obj2.Decimal(12.75m));
            Console.ReadLine();

            // Passing in string, return ing int if possible
            Operations obj3 = new Operations();
            obj3.NumberName("10");
            Console.WriteLine(obj3.NumberName("10"));
            Console.ReadLine();

        }
    }
}
