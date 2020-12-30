using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class Player
    {
        public List<Card> hand { get; set; }
        public int balance { get; set; }
        public string name { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
