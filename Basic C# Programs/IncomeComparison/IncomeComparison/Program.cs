using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            int person1Rate;
            int weeklyHours1;

            int person2Rate;
            int weeklyHours2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1 :");
            Console.WriteLine("Please enter hourly rate:");
            person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of hours worked weekly:");
            weeklyHours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2 :");
            Console.WriteLine("Please enter hourly rate:");
            person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of hours worked weekly:");
            weeklyHours2 = Convert.ToInt32(Console.ReadLine());

            int annualSalary1 = person1Rate * weeklyHours1 * 52;
            Console.WriteLine("Annual salary of person 1: " + annualSalary1);
            Console.ReadLine();

            int annualSalary2 = person2Rate * weeklyHours2 * 52;
            Console.WriteLine("Annual salary of person 1: " + annualSalary2);
            Console.ReadLine();

            bool compareIncome = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 have a higher income than Person 2?");
            Console.ReadLine();
            Console.WriteLine(compareIncome);
            Console.ReadLine();
        }
    }
}
