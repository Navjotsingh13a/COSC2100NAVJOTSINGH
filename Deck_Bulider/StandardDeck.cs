// Name: Navjot Singh
// Student ID: 100931376
// Date: November 11, 2024
// Modified: November 11, 2024
// Description: This code creates a StandardDeck class that makes a normal deck of cards with all suits and ranks....

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Bulider
{
    // StandardDeck class inherits from Deck to create a standard deck of cards...
    public class StandardDeck : Deck
    {
        // List of suits in the deck...
        private readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        // List of ranks in the deck...
        private readonly string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public StandardDeck()
        {
            // Add each card with a suit and rank to the deck...
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    // Add the card to the list...
                    cards.Add(new Card(suit, rank));
                }
            }
        }
    }
}
