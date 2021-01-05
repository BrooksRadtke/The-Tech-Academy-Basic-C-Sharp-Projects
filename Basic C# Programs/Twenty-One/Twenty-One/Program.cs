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
            
            Console.WriteLine("Hello, {0}! How much is you're buy-in today?", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Would you like to begin a game of 21?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now!");
            Console.ReadLine();
        }
    }
}
