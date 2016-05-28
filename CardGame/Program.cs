using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Deck
    {
        public enum Suit
        {
            Spades, Diamonds, Clubs, Hearts
        }
        public enum Value
        {
            Ace, Two, Three, Four, Five, Six,
            Seven, Eight, Nine, Ten, Jack,
            Queen, King
        }

        public void CreateBaseDeck()
        {
            // Create deck 
        }

        public void ShuffleDeck()
        {
            // Shuffle deck
        }
    }
    class Card
    {
        public string suit { get; set; }
        public string value { get; set; }
        public Card(string suit, string value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
