using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class Operations
    {
        

        public Addition()
        {
            // Adds userInput to itself
            int userInput = Convert.ToInt32(Console.ReadLine());
            int sum = userInput + userInput;
            return sum; 
        }

        public Multiply()
        {
            // Multiplies userInput by itself
            int userInput = Convert.ToInt32(Console.ReadLine());
            int product = userInput * userInput;
            return product;
        }
        
        public Divide()
        {
            // Divides userInput by itself
            int userInput = Convert.ToInt32(Console.ReadLine());
            int divide = userInput / userInput;
            return divide;
        }
    }
}
