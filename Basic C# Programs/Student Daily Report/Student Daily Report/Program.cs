using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            //Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? True or False");
            string needHelp = Console.ReadLine();
            bool getHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences that you would like to share?" +
                " Please give specifics.");
            string drResponse = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?" +
                " Please be specific.");
            string drFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today");
            string hoursStudied = Console.ReadLine(); 
            int myHours = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your response."
                + " An Instructor will respond to you shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
