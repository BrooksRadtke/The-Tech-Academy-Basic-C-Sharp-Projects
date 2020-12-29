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
        {   // Demonstrates Method Overloading
            // Instantiate the class and pass in an int
            Operations obj1 = new Operations();
            obj1.Assignment(5);
            Console.WriteLine(obj1.Assignment(5));
            Console.ReadLine();

            // Passing in decimal, returning int
            Operations obj2 = new Operations();
            obj2.Assignment(12.75m);
            Console.WriteLine(obj2.Assignment(12.75m));
            Console.ReadLine();

            // Passing in string, return ing int if possible
            Operations obj3 = new Operations();
            obj3.Assignment("10");
            Console.WriteLine(obj3.Assignment("10"));
            Console.ReadLine();

        }
    }
}
