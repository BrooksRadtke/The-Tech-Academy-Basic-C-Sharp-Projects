using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Create "Employee" class that inherits from "Person"
    // Make employee class take a generic parameter
    class Employee<T> : Person, IQuittable
    {
        public int employeeID;

        // Add generic list property to Employee class called "Things"
        // that matches class generic type
        public List<T> Things = new List<T>();

        // Instantiate an Employee obj with type string as generic parameter
        // Assign a list of strings
        public Things<string> stringThings = new Things<string>()
        {
            "Coffee",
            "Computer",
            "Pay-Check"
        };

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

        public static Boolean operator== (Employee<T> firstEmployee, Employee<T> secondEmployee)
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

        public static Boolean operator!= (Employee<T> firstEmployee, Employee<T> secondEmployee)
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
