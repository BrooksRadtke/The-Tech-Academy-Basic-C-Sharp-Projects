using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class called person and give it a fname and lname properties
    class Person
    {
        public string firstName;
        public string lastName;
        
        // Create a void method to display name
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
