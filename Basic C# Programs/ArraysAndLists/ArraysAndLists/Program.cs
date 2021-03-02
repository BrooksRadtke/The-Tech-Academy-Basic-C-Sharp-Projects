using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            ////Long way of array input
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            ////More efficient way of input
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            ////Efficient shortcut
            // One-Dimensional array of integers
            int[] numArray2 = { 5, 2, 10, 200, 5000 };

            // One-Dimensional array of strings
            string[] strArray = { "John", "Jacob", "Jingle-Heimer", "Schmitt" };

            // Ask user to input a number for a given index value
            // If exists, display it to screen

            try
            {
                Console.WriteLine("Hello! Please enter a number to display a value from a stored array of numbers:");
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numArray2[userNum]);
                Console.ReadLine();

                Console.WriteLine("Cool digits, bro.\nYou didn't even ask my name? Enter a number to find one:");
                int userStr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(strArray[userStr]);
                Console.ReadLine();

                List<string> myStrings = new List<string>() { "John", "Jacob", "Jingle-Heimer", "Schmitt" };

                Console.WriteLine("I have a last name too! Guess a number and I'll tell you:");
                int userList = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(myStrings[userList]);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Eh, try a different value.");
                Console.ReadLine();
            }
       
            ////changing values of an index
            //numArray2[2] = 234987;

            //Console.WriteLine(numArray2[2]);
            //Console.ReadLine();
            
            //List using int
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();
        }
    }
}
