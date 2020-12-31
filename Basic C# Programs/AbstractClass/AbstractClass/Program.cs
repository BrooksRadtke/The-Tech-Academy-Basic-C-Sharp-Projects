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
            Employee<string> person1 = new Employee<string>();

            person1.firstName = "Sample";
            person1.lastName = "Student";

            // Call SayName() on object
            person1.SayName();

            // Use polymorphism to create an obj of IQuittable and call Quit()
            IQuittable emp = new Employee<string>();

            emp.Quit();
            Console.ReadLine();

            // Instantiate 2 employee objects and compare id properties
            Employee<string> employeeOne = new Employee<string>();
            Employee<string> employeeTwo = new Employee<string>();
            employeeOne.firstName = "Joey";
            employeeOne.lastName = "Docker";
            employeeOne.employeeID = 123;

            employeeTwo.firstName = "Bob";
            employeeTwo.lastName = "Malone";
            employeeTwo.employeeID = 123;

            // Compare the two employee ids
            if (employeeOne.employeeID == employeeTwo.employeeID)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }

            if (employeeOne.employeeID != employeeTwo.employeeID)
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

            // Instantiate an employee obj with string type parameter
            Employee<string> emp1 = new Employee<string>();
            Employee<int> emp2 = new Employee<int>();

            emp1.Things = new List<string>()
            { 
                "Coffee",
                "Computer",
                "PayCheck"
            };
            emp2.Things = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };
            
            for(var i = 0; i < emp1.Things.Count(); i++)
            {
                Console.WriteLine(emp1.Things[i]);
            }

            for (var j = 0; j < emp2.Things.Count(); j++)
            {
                Console.WriteLine(emp2.Things[j]);
            }

            Console.ReadLine();
        }
    }
}
