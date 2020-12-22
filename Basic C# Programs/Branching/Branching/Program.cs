using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 12 ? "Ah, that's a great number" : "I can't begin to express my disappointment; I'm a computer.";

            Console.WriteLine(results);
            Console.ReadLine();

            //Example of operators with user input
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what's your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + "! What's the current temperature?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if(currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is EXACTLY room temperature");
            //}
            //else if(currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("This room is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("This is an absolute catastophe...");
            //}
            //Console.ReadLine();


            //Example of branching operators
            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //string comparisonResults = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";
            //Console.WriteLine(comparisonResults);
            //Console.ReadLine();

            //if(currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature!");
            //}
            //else if(currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if(roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("The room is warmer than the current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It's not exactly room temperature...")
            //}
            //Console.ReadLine();
        }
    }
}
