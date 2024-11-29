// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This file defines methods for saving and loading a deck of cards.
public interface IDeckPersistence
{
    // Method to save a deck of cards to a file....
    void Save(Deck deck, string filePath);

    // Method to load a deck of cards from a file...
    Deck Load(string filePath);
}
