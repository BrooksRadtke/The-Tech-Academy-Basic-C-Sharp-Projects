using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ent your first name:");
            string date = DateTime.Today.ToShortDateString();
            string fname = Console.ReadLine();
            string msg = $"\nWelcome back {fname}! Today is {date}.";
            Console.WriteLine(msg);

            double tScore = 0.0;
            string path = @"C:\Users\brook\Documents\TechAcademy\GitHub\Tech-Academy-Projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic C# Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            Console.WriteLine("\nStudent Scores:\n");

            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);


            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
