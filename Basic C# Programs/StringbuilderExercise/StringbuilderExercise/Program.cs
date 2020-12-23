using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringbuilderExercise
{
    class Program
    {
        static void Main()
        {
            //Concatenates 3 strings
            Console.WriteLine("Hello! " + "This program is all about" +
                " simple exercises with strings! ");

            string upper = "this string is being made into only capitals! ";
            upper = upper.ToUpper();
            Console.WriteLine(upper);

            string a = "Hi there! ";
            string b = "This paragraph is made up of individual strings. ";
            string c = "They are part of an exercise using Stringbuilder. ";
            string d = "It is a powerful tool, and I'm looking forward to learning more about it. ";
            string e = "Thanks for reading! ";
            StringBuilder sb = new StringBuilder();
            sb.Append(a + b + c + d + e);
            Console.WriteLine(sb);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
