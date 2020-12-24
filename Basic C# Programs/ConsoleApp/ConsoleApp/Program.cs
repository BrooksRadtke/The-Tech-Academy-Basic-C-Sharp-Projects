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
        {   //*PART 1*
            //Create a 1-dimensional string[]
            string[] stringArray = { "apples - ", "bananas - ", "cherries - ", "dates - ", "kiwi - " };

            //Create a loop that iterates through the array and adds
            //user input at the end of each string
            
            for(int i = 0; i < stringArray.Length; i++)
            {
                //ask the user to input text
                Console.WriteLine("How would you describe fruit? Such as 'apples are...'");
                stringArray[i] = stringArray[i] + Console.ReadLine();
                
            }

            //create a loop that prints each string in the [] on a separate line
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            //*PART 2*
            //create an infinite loop
            bool whileTrue = true;
            while(whileTrue)                 
            {
                //a while loop without a condition to switch to the other state
                //continues the loop
                Console.WriteLine("Always true!!");
                Console.ReadLine();
                whileTrue = false;
            }
            
            //*PART 3*
            //Create comparison loop with '<'
            for(int j = 0; j < 3; j++)
            {
                //this comparison loop will print the string 3x
                Console.WriteLine("And they just keep coming");
            }
            Console.ReadLine();
            //Create comparison loop with '<='
            //increments the value of 'n' per loop until its value
            //is <= to 4
            int n = 0;
            for(int k = 0; k <= 4; k++ )
            {
                n += 1;
                Console.WriteLine(n);
            }
            Console.ReadLine();

            //PART 4
            //Create a list of strings where each item is unique
            string userInput;
            List<string> fruitList = new List<string> { "apple", "banana", "cherrie", "dates", "kiwi" };

            //asks the user to input text to search the list
            Console.WriteLine("Please enter the name of a common fruit:");

            //code that loops to check if input item was on list,
            //if not, continues loop
            bool gotFruit = false;
            while(!gotFruit)
            {
                //takes user input for searching list
                userInput = Convert.ToString(Console.ReadLine());
                for(int i = 0; i < fruitList; i++)
                {
                    if (fruitList[i].Contains(userInput))
                    {
                        //once true, break the while loop
                        gotFruit = true;
                        Console.WriteLine(fruitList);
                        Console.ReadLine();
                    }
                    else
                    {
                        //Displays if the user input doesn't match an index string
                        Console.WriteLine("Sorry, please try a different fruit.");
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
