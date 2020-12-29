using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            // Instantiate and initialize Employee object
            Employee person1 = new Employee();
            person1.firstName = "Sample";
            person1.lastName = "Student";

            // Call superclass method on Employee object
            person1.SayName();
            Console.ReadLine();
        }
    }
}
