using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Hi there! Please enter a number, and I will " +
                "create a text file of it for you:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Log the number to a text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\brook\Documents\TechAcademy\GitHub\Tech-Academy-Projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic C# Programs\File IO\File IO\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.ReadLine();

            // Print the file back to the user
            string text = File.ReadAllText(@"C:\Users\brook\Documents\TechAcademy\GitHub\Tech-Academy-Projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic C# Programs\File IO\File IO\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
