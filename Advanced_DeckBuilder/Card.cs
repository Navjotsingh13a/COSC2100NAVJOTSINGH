// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class represents a playing card with a suit and rank....

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    // The suit of the card like Hearts, Spades...
    public string Suit { get; set; }

    // The rank of the card like Ace, King...
    public string Rank { get; set; }

    // initialize the card with a suit and rank...
    public Card(string suit, string rank)
    {
        // Sets the card's suit and rank...
        Suit = suit;
        Rank = rank;
    }

    // Returns a string representation of the card...
    public override string ToString()
    {
        // Combines rank and suit into a readable string...
        return $"{Rank} of {Suit}";
    }
}
