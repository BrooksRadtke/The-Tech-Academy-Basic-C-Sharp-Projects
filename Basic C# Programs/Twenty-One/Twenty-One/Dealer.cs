using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Twenty_One
{
    public class Dealer
    {
        public string name { get; set; }
        public Deck deck { get; set; }
        public int balance { get; set; }

        public void Deal(List<Card> hand)
        {
            hand.Add(deck.Cards.First());
            string card = string.Format(deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //using (StreamWriter file = new StreamWriter(@"C:\Users\brook\Documents\TechAcademy\GitHub\Tech-Academy-Projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic C# Programs\Twenty-One\Twenty-One\log.txt", true))
            //{
            //    file.WriteLine(DateTime.Now);
            //    file.WriteLine(card);
            //}
            deck.Cards.RemoveAt(0);
        }
    }
}
