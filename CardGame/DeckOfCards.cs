using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class DeckOfCards : Card
    {
        private const int NumberOfCards = 52; // Antal kort i kortleken
        private Card[] deck; // En vektor med alla kort

        // Konstruktor:
        public DeckOfCards()
        {
            deck = new Card[NumberOfCards];
        }

        public Card[] getDeck => deck; // Hämtar nuvarande kortlek

        // Skapa kortlek med 52 kort: 13 värden vardera, med 4 olika kortbeklädnader


            // TODO: RETURNERA EN VEKTOR MED EN KORTLEK

        public void SetUpDeck()
        {
            int i = 0;

            // Loopa igenom kortbeklädnader
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                // För varje kortbeklädnad, lägg till kortvärde i kortlek
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                deck[i] = new Card {MySuit = s, MyValue = v};
                    i++;
                }  
            }
            
        }
    }
}
