using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public abstract class Game
    {
        public List<Player> players { get; set; }
        public string name { get; set; }
        public string dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach(Player player in players)
            {
                Console.WriteLine(player.name);
            }
        }
    }
}
