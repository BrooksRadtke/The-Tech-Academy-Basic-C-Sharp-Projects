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
        {   // *PART 1*
            // Create a 1-dimensional string[]
            string[] stringArray = { "apples - ", "bananas - ", "cherries - ", "dates - ", "kiwi - " };

            // Create a loop that iterates through the array and adds
            // User input at the end of each string
            
            for(int i = 0; i < stringArray.Length; i++)
            {
                // Ask the user to input text
                Console.WriteLine("How would you describe fruit? Such as \'{0}\'", stringArray);
                stringArray[i] = stringArray[i] + Console.ReadLine();
                
            }

            // Create a loop that prints each string in the [] on a separate line
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            // *PART 2*
            // create an infinite loop
            bool whileTrue = true;
            while(whileTrue)                 
            {
                // a while loop without a condition to switch to the other state
                // continues the loop
                Console.WriteLine("Always true!!");
                Console.ReadLine();
                whileTrue = false;
            }
            
            // *PART 3*
            // Create comparison loop with '<'
            for(int j = 0; j < 3; j++)
            {
                // this comparison loop will print the string 3x
                Console.WriteLine("And they just keep coming");
            }
            Console.ReadLine();
            // Create comparison loop with '<='
            // increments the value of 'n' per loop until its value
            // is <= to 4
            int n = 0;
            for(int k = 0; k <= 4; k++ )
            {
                n += 1;
                Console.WriteLine(n);
            }
            Console.ReadLine();

            // *PART 4*
            // Create a list of strings where each item is unique
            string userInput;
            List<string> nameList = new List<string> { "John", "Jacob", "Jingle-Heimer", "Schmitt", "Fred" };

            // asks the user to input text to search the list
            Console.WriteLine("Please enter a name like, \"John\", \"Jacob\", \"Jingle-Heimer\",\n \"Schmitt\", \"Fred\", or something else:");

            // code that loops to check if input item was on list,
            // if not, continues loop
            bool gotName = false;
            while(!gotName)
            {
                //takes user input for searching list
                userInput = Convert.ToString(Console.ReadLine());
                if(nameList.Contains(userInput))
                {
                    // loops through the entire list by the number of indexes
                    for (int i = 0; i < nameList.Count(); i++)
                    {
                        if (userInput == nameList[i])
                        {
                            //once true, break the while loop
                            gotName = true;
                            Console.WriteLine(userInput + " - " + i);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                else
                {
                    // Displays if the user input doesn't match an index string
                    Console.WriteLine("Sorry, please try a different name.");
                }
            }

            // *PART 5*
            // Add a list of strings with at least two identical values
            List<string> myList2 = new List<string> { "New Years Day", "Valentines", 
                "4th of July", "Christmas Day", "Christmas Day" };

            // Create prompt asking user to search of it
            Console.WriteLine("Please search for an American holiday, but first search \"Christmas Day\".");

            // Create a loop that searches through the list and displays the matching indexes
            bool gotHoliday = false;
            while(!gotHoliday)
            {
                userInput = Convert.ToString(Console.ReadLine());
                if(myList2.Contains(userInput))
                {
                    // Loops through the entire list by the number of indexes
                    for(int i = 0; i < myList2.Count(); i++)
                    {
                        if(userInput == myList2[i])
                        {
                            gotHoliday = true;
                            Console.Write(userInput + " - " + i + " ");
                        }
                    }
                }
                else
                {
                    // Displays if the user input doesn't match an index string
                    Console.WriteLine("Sorry, please try a different holiday name.");
                }
            }

            // *PART 6*
            // Create a list that contains at least one identical string with another
            List<string> myList3 = new List<string> { "pig", "horse", "duck", "cow", "pig" };

            // Create a list to filter duplicated out of myList3
            List<string> myFilteredList3 = new List<string> { };
            // Create a foreach loop that evaluates the list, 
            // and returns a message if a match is found within it

            foreach(string animal in myList3)
            {
                // Checks if the filtere list contains the current string
                // If it does, it is a duplicate
                if(myFilteredList3.Contains(animal))
                {
                    Console.WriteLine("{0} has already appeared in the list", animal);
                }
                else // If the filtered list does not contain the current string,
                    // then add it to the list and state it is not a duplicate
                {
                    myFilteredList3.Add(animal);
                    Console.WriteLine("This is the first time {0} has appeared in the list", animal);
                }
            }
            Console.ReadLine();
        }
    }
}
