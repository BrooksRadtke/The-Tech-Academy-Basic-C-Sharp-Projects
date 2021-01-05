using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime
{
    class Program
    {
        public void Main(string[] args)
        {
            DateTime datetime = new DateTime.Now;
            Console.WriteLine(datetime);

            Console.WriteLine("\n Hello! Please enter a number, and I will " +
                "tell you what time it will be in that many hours from now:");
            int userInput = Convert.ToInt32(Console.ReadLine());


        }
    }
}
