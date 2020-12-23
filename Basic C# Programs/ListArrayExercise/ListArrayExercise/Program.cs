using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayExercise
{
    class Program
    {
        static void Main()
        {
            //array of strings
            int arrayInput;
            string[] fruitArray = { "apple", "banana", "cherry", "dates", "kiwi" };
            Console.WriteLine("Hi there. I have 5 fruit items in an array container. " +
                "Please enter a number between 0 and 4 to display one:");

            bool isCorrect = false;
            while (!isCorrect)
            {
                //takes in user input value
                arrayInput = Convert.ToInt32(Console.ReadLine());

                //checks if input was within range
                if (arrayInput <= fruitArray.Length)
                {
                    isCorrect = true;
                    Console.WriteLine(fruitArray[arrayInput]);
                    Console.ReadLine();
                }
                else
                {
                    //response if answer doesn't have a value
                    Console.WriteLine("Sorry. Please input a number between 0 and 4" +
                        " to see an item.");
                }
            }

            //array of int
            int arrayInput2;
            int[] numArray = { 23, 41, 5, 9690, 173029842 };
            Console.WriteLine("Thank you. Now I have 5 number items in an array container. " +
                "Please enter a number between 0 and 4 to display one:");

            bool isCorrect2 = false;
            while(!isCorrect2)
            {
                //takes in user input value
                arrayInput2 = Convert.ToInt32(Console.ReadLine());

                if (arrayInput2 <= numArray.Length)
                {
                    isCorrect2 = true;
                    Console.WriteLine(numArray[arrayInput2]);
                    Console.ReadLine();
                }
                else
                {
                    //response if answer doesn't have a value
                    Console.WriteLine("Sorry. Please input a number between 0 and 4" +
                        " to see an item.");
                }
            }
            
            //list of strings
            int listInput;
            List<string> stringList = new List<string>();
            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("cherry");
            stringList.Add("dates");
            stringList.Add("kiwi");

            Console.WriteLine("Excellent. Finally, I have 5 fruit items in list container. " +
                "Please enter a number between 0 and 4 to display one:");

            bool isCorrect3 = false;
            while(!isCorrect3)
            {
                //takes in user input value
                listInput = Convert.ToInt32(Console.ReadLine());

                if (listInput <= stringList.Count)
                {
                    isCorrect3 = true;
                    Console.WriteLine(stringList[listInput]);
                    Console.ReadLine();
                }
                else
                {
                    //response if answer doesn't have a value
                    Console.WriteLine("Sorry. Please input a number between 0 and 4" +
                        " to see an item.");
                }
            }
        }
    }
}
