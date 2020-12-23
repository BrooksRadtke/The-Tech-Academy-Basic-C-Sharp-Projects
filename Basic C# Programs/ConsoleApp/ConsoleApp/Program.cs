using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Create a 1-dimensional string[]
            string[] stringArray = { "apples", "bananas", "cherries", "dates", "kiwi" };

            //Create a loop that iterates through the array and adds
            //user input at the end of each string
            
            for(int i = 0; i < stringArray.Length; i++)
            {
                //ask the user to input text
                Console.WriteLine("How would you describe fruit? Such as 'apples are...'");

                
            }

            //create a loop that prints each string in the [] on a separate line
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();
        }
    }
}
