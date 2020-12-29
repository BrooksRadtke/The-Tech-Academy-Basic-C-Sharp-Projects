using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations obj1 = new Operations();

            Console.WriteLine("Input a number to be divided by 2:");
            int x = Convert.ToInt32(Console.ReadLine());
            obj1.DividedBy(x);

            Console.ReadLine();
        }
    }
}
