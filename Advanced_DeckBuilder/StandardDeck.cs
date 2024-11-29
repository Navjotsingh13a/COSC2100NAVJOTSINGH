// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class represents a standard deck of playing cards and provides methods to reset and clear the deck.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class StandardDeck : Deck
{
    // Define the suits....
    private readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
    // Define the card ranks....
    private readonly string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

    public StandardDeck()
    {
        ResetDeck();
    }

    // Clears all cards in the deck...
    public void ClearDeck()
    {
        cards.Clear();
    }

    // Resets the deck to include standard cards
    public void ResetDeck()
    {
        // Clear any existing cards in the deck...
        cards.Clear();

        // Add one card for each suit and rank combination...
        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                // Add the card to the deck...
                AddCard(new Card(suits[i], ranks[j]));
            }
        }
    }
}

