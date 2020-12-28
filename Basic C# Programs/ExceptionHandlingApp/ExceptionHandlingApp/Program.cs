using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers to be divided by
                List<int> myList = new List<int> { 2, 6, 14, 25, 58 };
                // Ask the user to enter a number to divide the list by
                Console.WriteLine("Please enter a number to divide the list by: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int outputNumber;

                for (int i = 0; i < myList.Count(); i++)
                {
                    outputNumber = myList[i] / userInput;
                    Console.WriteLine(outputNumber);
                }
            }
            catch(DivideByZeroException ex)
            {
                // Create prompt when user tries to divide by zero
                Console.WriteLine("Please do not divide by zero!");
            }
            catch(FormatException ex)
            {
                // Create prompt when user divides by string
                Console.WriteLine("Sorry, you cannot divide a number by a word...yet.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
