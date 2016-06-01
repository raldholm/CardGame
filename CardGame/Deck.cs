using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        public void CreateAndSortDeck()
        {
         
            //todo:

            /* 
             * Sortering skall sortera korten i kortspelet enligt färg och valör: 
             * Hjärter(Ess,2,3 ... Kung), ruter, klöver och spader.
             * Alla kortlekar som ingår i spelet skall sorteras.
             * 
             */
        }

        public void TakeCard()
        {
            // todo:

            /*
             * Dra kort skall visa det översta kortet i kortspelet tills dess att alla kort är dragna.
             * Alla kort ska kunna visas.
             *  
             */
            
        }

        public void Shuffle()
        {
            // todo:

            /*
             * Blandning av korten skall lägga korten i kortspelet i slumpvis ordning.
             *             
             */
        }
        //public static List<Card> NewDeck()
        //{
        //    List<Card> newDeck = new List<Card>();
        //    foreach (Card  in Enum.GetValues(typeof(Card)))
        //    {
        //        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
        //        {
        //            newDeck.Add(new Card(suit, rank));
        //        }
        //    }
        //    return newDeck;
        //}
    }
}
