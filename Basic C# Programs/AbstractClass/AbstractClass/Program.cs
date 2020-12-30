using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main()
        {
            // Instantiate with first/lastname values
            Employee<T> person1 = new Employee<T>();

            person1.firstName = "Sample";
            person1.lastName = "Student";

            // Call SayName() on object
            person1.SayName();

            // Use polymorphism to create an obj of IQuittable and call Quit()
            IQuittable emp = new Employee<T>();

            emp.Quit();
            Console.ReadLine();

            // Instantiate 2 employee objects and compare id properties
            Employee<T> employeeOne = new Employee<T>();
            Employee<T> employeeTwo = new Employee<T>();
            employeeOne.firstName = "Joey";
            employeeOne.lastName = "Docker";
            employeeOne.employeeID = 123;

            employeeTwo.firstName = "Bob";
            employeeTwo.lastName = "Malone";
            employeeTwo.employeeID = 123;

            // Compare the two employee ids
            if(employeeOne.employeeID == employeeTwo.employeeID)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }

            if (employeeOne.employeeID != employeeTwo.employeeID)
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
