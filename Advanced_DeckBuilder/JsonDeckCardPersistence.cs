// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class handles saving and loading a deck of cards in JSON format...



using System.IO;
using System.Text.Json;

public class JsonDeckCardPersistence : IDeckPersistence
{
    // Method to save a deck of cards to a JSON file...
    public void Save(Deck deck, string filePath)
    {
        // Serializes the deck's cards to JSON format....
        string json = JsonSerializer.Serialize(deck.Cards);

        // Writes the JSON string to a file...
        File.WriteAllText(filePath, json);
    }

    // Method to load a deck of cards from a JSON file...
    public Deck Load(string filePath)
    {
        // Checks if the JSON file exists; throws an error if it does not...
        if (!File.Exists(filePath))
            throw new FileNotFoundException("The JSON file does not exist.");

        // Reads the JSON content from the file...
        string json = File.ReadAllText(filePath);

        // Deserializes the JSON content into a list of cards...
        var cards = JsonSerializer.Deserialize<List<Card>>(json);

        // Creates a new deck and adds each card from the list...
        Deck deck = new Deck();
        for (int i = 0; i < cards.Count; i++) 
        {
            // Adds a card to the deck....
            deck.AddCard(cards[i]);
        }
        return deck;
    }
}
