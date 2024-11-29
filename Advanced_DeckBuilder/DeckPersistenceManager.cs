// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class manages saving and loading a deck of cards using different persistence methods....

public class DeckPersistenceManager
{
    // Variable That holds the persistence method for saving/loading decks...
    private IDeckPersistence persistence;

    // // Initializes the persistence method....
    public DeckPersistenceManager(IDeckPersistence persistence)
    {
        this.persistence = persistence;
    }


    // Method to change the persistence method...
    public void SetPersistence(IDeckPersistence persistence)
    {
        // Updates the persistence method...
        this.persistence = persistence;
    }


    // Method to save the deck to a file...
    public void SaveDeck(Deck deck, string filePath)
    {
        persistence.Save(deck, filePath); 
    }


    // Method to load the deck from a file....
    public Deck LoadDeck(string filePath)
    {
        return persistence.Load(filePath); 
    }
}
