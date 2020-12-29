using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethodTypes
{
    class Operations
    {
        // Create a math operation class for an int
        public int Addition(int x)
        {
            int sum = x + 5;
            return sum;
        }

        public decimal Decimal(decimal x)
        {
            int difference = (int)(x - 5);
            return difference;
        }

        public int NumberName(string x)
        {
            int length = Int32.Parse(x);
            int product = length * 10;
            return product;
        }
    }
}
