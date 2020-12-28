using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class Operations
    {
        public int Addition(int x)
        {
            // Adds userInput to itself
            int sum = x + x;
            return sum; 
        }

        public int Multiply(int x)
        {
            // Multiplies userInput by itself
            int product = x * x;
            return product;
        }
        
        public int Divide(int x)
        {
            // Divides userInput by itself
            int divide = x / x;
            return divide;
        }
    }
}
