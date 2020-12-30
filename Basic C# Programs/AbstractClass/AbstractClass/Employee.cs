using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Create "Employee" class that inherits from "Person"
    class Employee : Person, IQuittable
    {
        // Overide SayName() to impliment
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is " + firstName + " " + lastName);
        }

        // Inherit the interface and impliment method
        public void Quit(Employee employee)
        {
            Console.WriteLine("Please accept this letter as a " +
                "written notice of my resignation.");
        }
    }
}
