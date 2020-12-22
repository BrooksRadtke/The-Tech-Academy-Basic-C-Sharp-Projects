using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main()
        {
            //Exercise using the if-else statements
            string answer;
            string answer2;
            int answer3;
            int answer4;

            Console.WriteLine("Are you having a good day?");
            answer = Convert.ToString(Console.ReadLine());
            if(answer == "yes")
            {
                Console.WriteLine("Glad to hear!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Bummer...");
            }
            else
            {
                Console.WriteLine("Well, it's nothing a little coffee can't fix.");
            }
            Console.ReadLine();

            //Exercise using !=
            Console.WriteLine("May I ask you another question?");
            answer2 = Convert.ToString(Console.ReadLine());
            if(answer2 != "yes")
            {
                Console.WriteLine("Why? Are you tired of me??");
            }
            else
            {
                Console.WriteLine("Oh...Nevermind...");
            }
            Console.ReadLine();

            //Utilizes > && <=
            Console.WriteLine("Actually, I've always wondered: " +
                "how many cups of sugar does it take to get to the moon?");
            answer3 = Convert.ToInt32(Console.ReadLine());
            if(answer3 > 3.5)
            {
                Console.WriteLine("Madness, I tell you, madness!");
            }
            //Uses more specific criteria
            else if (answer3 <= 3.5 && answer3 > 1)
            {
                Console.WriteLine("That's not much, let's give it a try!");
            }
            else
            {
                Console.WriteLine("Oh, boo. You're not fun.");
            }
            Console.ReadLine();

            //Using ternary operator
            Console.WriteLine("In any case, if I have 5 apples, how many do you need" +
                " to have more than me?");
            answer4 = Convert.ToInt32(Console.ReadLine());
            string result = answer4 > 5 ? "You're a sharp one, kiddo." : "Gracious, no...";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
