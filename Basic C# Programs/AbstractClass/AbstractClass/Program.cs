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
            Employee person1 = new Employee();

            person1.firstName = "Sample";
            person1.lastName = "Student";

            // Call SayName() on object
            person1.SayName();

            // Use polymorphism to create an obj of IQuittable and call Quit()
            IQuittable emp = new Employee();

            emp.Quit();
            Console.ReadLine();
        }
    }
}
