using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    //todo:
    /* SKAPA OCH SORTERA KORTLEK METOD:
     * Sortering skall sortera korten i kortspelet enligt färg och valör: 
     * Hjärter(Ess,2,3 ... Kung), ruter, klöver och spader.
     * Alla kortlekar som ingår i spelet skall sorteras.
     * 
     * TAKE CARD METOD:
     * Dra kort skall visa det översta kortet i kortspelet tills dess att alla kort är dragna.
     * Alla kort ska kunna visas.
     *  
     * BLANDA KORTLEK METOD:
     * Blandning av korten skall lägga korten i kortspelet i slumpvis ordning.             
    */
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
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }

        }
    }
}
