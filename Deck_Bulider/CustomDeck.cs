// Name: Navjot Singh
// Student ID: 100931376
// Date: November 11, 2024
// Modified: November 11, 2024
// Description: This code defines a CustomDeck class inherits from Deck class,
// allows adding custom cards with specific suits and ranks to the deck....

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Bulider
{
    // CustomDeck class inherits from Deck...
    public class CustomDeck : Deck
    {
        // Adds custom card to the deck...
        public void AddCustomCard(string suit, string rank)
        {
            // Add a new card with the specified suit and rank...
            cards.Add(new Card(suit, rank));
        }
    }

}
