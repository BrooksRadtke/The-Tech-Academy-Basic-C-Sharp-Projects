using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.TwentyOne;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a friendly game of Twenty-One! With whom " +
                "do I have the pleasure of playing with today?");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("Hello, {0}! How much is you're buy-in today?", playerName);
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if(!validAnswer)
                {
                    Console.WriteLine("Please enter only whole numbers. Thank you! Please try again:");
                }
            }
            
            Console.WriteLine("Would you like to begin a game of 21?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\brook\Documents\TechAcademy\GitHub\Tech-Academy-Projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic C# Programs\Twenty-One\Twenty-One\log.txt", true))
                {
                    file.WriteLine(player.ID);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Thank you. You will be escorted out by security " +
                            "personel immediately.");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Apolgies. An error has occurred. Please contact " +
                            "your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now!");
            Console.ReadLine();
        }
    }
}
