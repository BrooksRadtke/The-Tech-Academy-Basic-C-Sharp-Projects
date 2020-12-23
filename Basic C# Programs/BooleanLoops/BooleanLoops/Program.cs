using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLoops
{
    class Program
    {
        static void Main()
        {                                   //Example of while
            bool nameValidation = false;    //name set to false
            while(!nameValidation)          //! indicated false
            {
                Console.WriteLine("Enter your name:");
                string userName = Console.ReadLine();

                if(userName == "Brooks")
                {
                    nameValidation = true;  //if true, exits loop
                    Console.WriteLine("Welcome, " + userName);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid name: ");
                }
            }

            //example of boolean do-while
            Console.WriteLine("What's my favorite day of the week?");

            string day = Convert.ToString(Console.ReadLine());
            bool favDay = day == "Saturday";        //becomes true with specific value

            do
            {
                switch (day)                        //passing in input for 'day'
                {
                    case "Monday":
                        Console.WriteLine("Nope, not Monday");
                        Console.WriteLine("What's my favorite day of the week?");
                        day = Convert.ToString(Console.ReadLine());
                        break;
                    case "Friday":
                        Console.WriteLine("Sorry, not Friday");
                        Console.WriteLine("What's my favorite day of the week?");
                        day = Convert.ToString(Console.ReadLine());
                        break;
                    case "Saturday":
                        Console.WriteLine("That's right!");
                        favDay = true;              //breaks the loop
                        break;
                    default:                        //default message for any input not mentioned above
                        Console.WriteLine("Sorry, no.");
                        Console.WriteLine("What's my favorite day of the week?");
                        day = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!favDay);
            Console.ReadLine();
        }
    }
}
