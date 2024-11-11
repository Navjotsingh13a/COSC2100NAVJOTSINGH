// Name: Navjot Singh
// Student ID: 100931376
// Date: November 11, 2024
// Modified: November 11, 2024
// Description: This code defines a Deck class that can store, shuffle, deal, reset, and view a list of playing cards...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Deck_Bulider
{
    public class Deck
    {
        // List to store the cards...
        protected List<Card> cards = new List<Card>();

        // Shuffles the deck by randomizing the order of the cards...
        public void Shuffle()
        {
            var random = new Random();
            cards = cards.OrderBy(card => random.Next()).ToList();
        }

        // Deals a specified number of cards from the deck...
        public List<Card> Deal(int count)
        {
            // get the top counted cards...
            var dealtCards = cards.Take(count).ToList();
            // remove the dealt cards from the deck...
            cards = cards.Skip(count).ToList();
            return dealtCards;
        }

        // Resets the deck by clearing all the cards...
        public void Reset()
        {
            cards.Clear();
        }

        // Returns a copy of the current deck of cards...
        public List<Card> ViewDeck()
        {
            return new List<Card>(cards);
        }
    }
}
