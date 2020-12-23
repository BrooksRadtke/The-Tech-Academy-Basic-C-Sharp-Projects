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
            arrayInput = Convert.ToInt32(Console.ReadLine());
            
            //checks if input was within range
            if(arrayInput <= 4 && arrayInput >= 0)
            {
                Console.WriteLine(fruitArray[arrayInput]);
                Console.ReadLine();
            }
            else
            {
                //response if answer doesn't have a value
                Console.WriteLine("Sorry. Please input a number between 0 and 4" +
                    " to see an item.");
                arrayInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fruitArray[arrayInput]);
                Console.ReadLine();
            }

            //array of int
            int arrayInput2;
            int[] numArray = { 23, 41, 5, 9690, 173029842 };
            Console.WriteLine("Thank you. Now I have 5 number items in an array container. " +
                "Please enter a number between 0 and 4 to display one:");
            arrayInput2 = Convert.ToInt32(Console.ReadLine());

            if(arrayInput2 <= 4 && arrayInput2 >= 0)
            {
                Console.WriteLine(numArray[arrayInput2]);
                Console.ReadLine();
            }
            else
            {
                //response if answer doesn't have a value
                Console.WriteLine("Sorry. Please input a number between 0 and 4" +
                    " to see an item.");
                arrayInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numArray[arrayInput2]);
                Console.ReadLine();
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
            listInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[listInput]);
            Console.ReadLine();
        }
    }
}
