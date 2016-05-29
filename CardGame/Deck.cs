using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        public enum Suit : int
        {
            Hearts = 0,
            Clubs = 1,
            Diamonds = 2,
            Spades = 3,

        }
        public enum Value : int
        {
            Ace = 0,
            Two = 1,
            Three = 2,
            Four = 3,
            Five = 4,
            Six = 5,
            Seven = 6,
            Eight = 7,
            Nine = 8,
            Ten = 9,
            Jack = 10,
            Queen = 11,
            King = 12
        }

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

        public void DrawCard()
        {
            // todo:


            /*
             * Dra kort skall visa det översta kortet i kortspelet tills dess att alla kort är dragna.
             * Alla kort ska kunna visas.
             *  
             */
        }

        public void ShuffleDeck()
        {
            // todo:


            /*
             * Blandning av korten skall lägga korten i kortspelet i slumpvis ordning.
             *             
             */
        }
    }
}
