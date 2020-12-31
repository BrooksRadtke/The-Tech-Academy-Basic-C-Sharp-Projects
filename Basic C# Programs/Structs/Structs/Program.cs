using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main()
        {
            // Create an object of data type Number, and assign amount 
            // Obj.specification
            Number myNumber;
            myNumber.Amount = 9.82m;
        }

        // Create a struct called Number with a property called Amount as a decimal type
        struct Number
        {
            public decimal Amount;
        }
    }
}
