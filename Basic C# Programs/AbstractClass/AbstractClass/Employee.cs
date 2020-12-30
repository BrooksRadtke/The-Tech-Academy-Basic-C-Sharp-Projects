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
        public int employeeID;

        // Add generic list property to Employee class called "Things"
        //public List<T> things = new List<T>(); 

        // Overide SayName() to implement
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is " + firstName + " " + lastName);
        }

        // Inherit the interface and implement method
        public void Quit()
        {
            Console.WriteLine("Please accept this letter as a " +
                "written notice of my resignation.");
        }

        //Overload "==" so it checks if two employee objs are equal
        //By comparing their ID properties

        public static Boolean operator== (Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.employeeID == secondEmployee.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean operator!= (Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.employeeID != secondEmployee.employeeID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
