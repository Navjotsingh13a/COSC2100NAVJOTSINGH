// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class inherites from the Deck class and allows adding custom cards with a suit and rank.

using DeckBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomDeck : Deck
{
    // Adds a custom card with the specified suit and rank to the deck...
    public void AddCustomCard(string suit, string rank)
    {
        // Check if suit and rank are not empty or just spaces...
        if (!string.IsNullOrWhiteSpace(suit) && !string.IsNullOrWhiteSpace(rank))
        {
            // Add the new custom card to the deck...
            AddCard(new Card(suit, rank));
        }
        else
        {
            // Throw an exception if the suit or rank is invalid...
            throw new ArgumentException("Suit and Rank cannot be empty.");
        }
    }
}