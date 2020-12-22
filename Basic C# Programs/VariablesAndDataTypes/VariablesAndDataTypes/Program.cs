using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //brief explanation and overview of datatypes
            bool isStudying = true;
            byte hoursWorked = 50;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';
            
            decimal moneyInBank = 100.25m;
            double heightInCentimeters = 211.48193;

            float secondsLeft = 2.122f;

            short temeratureOnMars = -241;

            string myName = "Brooks";

            //convert int to string
            int currentAge = 28;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = isRaining.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
