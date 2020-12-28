using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class Card
    {
        // Contructor - "values assigned to an object upon creation"
        public Card()
        {
            suit = "Spades";
            face = "2";
        }
        public string suit { get; set; }
        public string face { get; set; }
    }
}
