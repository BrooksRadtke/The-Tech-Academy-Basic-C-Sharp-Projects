using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you would like math operations " +
                "done on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Operations obj1 = new Operations();

            obj1.Addition(userInput);
            Console.WriteLine(obj1.Addition(userInput));

            obj1.Multiply(userInput);
            Console.WriteLine(obj1.Multiply(userInput));

            obj1.Divide(userInput);
            Console.WriteLine(obj1.Divide(userInput));

            Console.ReadLine();
        }
    }
}
