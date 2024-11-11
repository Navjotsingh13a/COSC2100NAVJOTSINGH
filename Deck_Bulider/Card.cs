// Name: Navjot Singh
// Student ID: 100931376
// Date: November 11, 2024
// Modified: November 11, 2024
// Description: This code defines Card class that holds the suit and rank of a card and shows them as formatted string....

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Bulider
{
    public class Card
    {
        // Stores the suit of the card like Hearts, Spades...
        public string Suit { get; set; }
        // Stores the rank of the card like Ace, 1, 2, King...
        public string Rank { get; set; }

        public Card(string suit, string rank)
        {
            // Set the suit and rank...
            Suit = suit;
            Rank = rank;
        }

        // Returns the card as a string...
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
