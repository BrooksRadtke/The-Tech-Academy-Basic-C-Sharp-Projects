using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Create "Employee" class that inherits from "Person"
    class Employee : Person
    {
        // Overide SayName() to impliment
        public override void SayName()
        {
            base.SayName();
        }
    }
}
