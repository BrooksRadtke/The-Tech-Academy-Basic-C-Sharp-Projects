using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Dealer
    {
        public string name { get; set; }
        public Deck deck { get; set; }
        public int balance { get; set; }

        public void Deal(List<Card> hand)
        {
            hand.Add(deck.Cards.First());
            Console.WriteLine(deck.Cards.First().ToString() + "\n");
            deck.Cards.RemoveAt(0);
        }
    }
}
