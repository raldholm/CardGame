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
            DeckOfCards cardDeck = new DeckOfCards();
            
            Console.Write("{0,-19}", cardDeck.getDeck());

        }
        
        // Kortleken skall bestå av valbart antal kortlekar.
        // Dokumentera din lösning.
        // Skriv användartestfall.

        // Lösningen betraktas som klar då man kan blanda, sortera och dra kort ifrån kortspelet.

        //todo: designa webbgränsnitt i webbforms
    }
}
