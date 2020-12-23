using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 95, 70, 82, 34, 91, 90, 94 };

            //for(int i = 0; i < testScores.Length; i++)
            //{
            //    if(testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] name = { "Jesse", "Erik", "Dan", "Adam" };
            
            //for(int j = 0; j < name.Length; j++)
            {
                //STATEMENT THAT LOOKS FOR EQUIVALENT VALUE
                //if(name[j] == "Jesse")
                //{
                //    Console.WriteLine(name[j]);
                //}

                //Prints all values in array
                //Console.WriteLine(name[j]); 
            }
            //Console.ReadLine();

            //Example of foreach loop using values in list
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(71);
            //testScores.Add(68);

            ////'score' is a variable representing value in list
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Dan", "Adam" };

            //foreach(string name in names)
            //{
            //Prints name equivalent to value
            //if(name == "Jesse")
            //{
            //    Console.WriteLine(name);
            //}

            //Prints all names in console
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //takes number of passing scores, counts number from list, and prints number
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 88 };
            List<int> passingScores = new List<int>();

            foreach(int score in testScores)
            {
                if(score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
