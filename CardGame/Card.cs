using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public Card(string suit, string value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value + " of " + Suit;
        }
    }
}
