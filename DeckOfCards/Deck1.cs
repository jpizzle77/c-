using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        List<string> cards = new List<string>();
        List<string> hand = new List<string>();
        string x;
       
        public Deck()
            {
                Card newDeck = new Card();
            }

        
        public void Deal()
        {
            cards.Remove("Ace Clubs");

        }

        

    }



}