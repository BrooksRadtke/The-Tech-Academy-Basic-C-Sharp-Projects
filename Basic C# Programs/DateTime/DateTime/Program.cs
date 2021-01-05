using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeProj
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DateTime keyword was throwing errors because the namespace was named the same
            // Changing namespace resolved errors 

            DateTime data = DateTime.Now;
            Console.WriteLine(data);

            // Ask user to input a number to be converted into additional hours from now
            Console.WriteLine("\nHello! Please enter a number, and I will " +
                "tell you what time it will be in that many hours from now:");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Convert input to display time
            DateTime later = data.AddHours(userInput);

            Console.WriteLine("It will be {0} {1} hour(s) from now", later, userInput);
            Console.ReadLine();
        }
    }
}
