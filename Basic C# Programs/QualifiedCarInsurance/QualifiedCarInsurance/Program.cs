using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualifiedCarInsurance
{
    class Program
    {
        static void Main()
        {
            int age;
            bool isDUI;
            int speedTickets;
            bool getInsurance;

            //Displays request for the user's age
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            //Asks if user has ever received DUIs
            Console.WriteLine("Have you ever received a DUI? true or false");
            isDUI = Convert.ToBoolean(Console.ReadLine());

            //Displays request for number of speeding tickets
            Console.WriteLine("How many speeding tickets to do you have?");
            speedTickets = Convert.ToInt32(Console.ReadLine());

            //Checks each variable, Bool NEEDS '==' to function correctly
            Console.WriteLine("Qualified?");
            getInsurance = age > 15 && isDUI == false && speedTickets < 4;
            Console.WriteLine(getInsurance);
            Console.ReadLine();
        }
    }
}
