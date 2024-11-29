// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class represents a deck of cards and provides methods to add, shuffle, deal, and save/load the deck...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Windows.Controls;
using System.Windows.Documents;

public class Deck
{
    // List that holds the cards in the deck...
    protected List<Card> cards;

    public Deck()
    {
        // Creates an empty deck of cards...
        cards = new List<Card>();
    }

    // Method to add a card to the deck...
    public void AddCard(Card card)
    {
        // Adds a card to the deck...
        cards.Add(card);
    }

    // Method to deal the top card from the deck...
    public Card Deal()
    {
        // Checks if there are no cards left in the deck...
        if (cards.Count == 0)
            // Throws an error if deck is empty...
            throw new InvalidOperationException("No cards left in the deck.");

        // Gets the top card of the deck...
        Card topCard = cards[0];
        // Remove the top card...
        cards.RemoveAt(0);
        return topCard;
    }

    public List<Card> Cards
    {
        // Returns a new list containing all cards in the deck...
        get { return new List<Card>(cards); }
    }

    // Method to shuffle the deck of cards...
    public void Shuffle()
    {
        // Creates a random number generator...
        Random randomnumber = new Random();
        {
            // Loop through each card in the deck...
            for (int i = 0; i < cards.Count; i++)
            {
                // Pick a random card index between i and the end of the deck...
                int j = randomnumber.Next(i, cards.Count);
                var temp = cards[i];  // stores the card at index i temporarirly...
                cards[i] = cards[j];  // Swaps the card at index i with the card at index j...
                cards[j] = temp;  
            }
        }
    }

    // Method to save the deck to a JSON file...
    public void SaveToJson(string filePath)
    {
        try
        {
            // Serializes the deck's cards to JSON format...
            string json = JsonSerializer.Serialize(cards);
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            // Handles any errors during saving...
            throw new IOException($"Error saving deck to JSON: {ex.Message}");
        }
    }

    // Method to load the deck from a JSON file...
    public void LoadFromJson(string filePath)
    {
        try
        {
            // Checks if the JSON file exists...
            if (!File.Exists(filePath))
                // Throws an error if not found...
                throw new FileNotFoundException("The JSON file does not exist.");

            string json = File.ReadAllText(filePath);
            cards = JsonSerializer.Deserialize<List<Card>>(json) ?? new List<Card>();
        }
        catch (Exception ex)
        {
            // Handles any errors during loading....
            throw new IOException($"Error loading deck from JSON: {ex.Message}");
        }
    }

    // Method to save the deck to an XML file...
    public void SaveToXml(string filePath)
    {
        try
        {
            // Creates an XML serializer for the list of cards...
            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));
            using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fileStream, cards);
        }
        catch (Exception ex)
        {
            // Handles any errors during saving...
            throw new IOException($"Error saving deck to XML: {ex.Message}");
        }
    }

    // Method to load the deck from an XML file...
    public void LoadFromXml(string filePath)
    {
        try
        {
            // Checks if the XML file exists...
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The XML file does not exist.");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));
            using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // Deserializes the XML into a list of cards...
            cards = (List<Card>)(serializer.Deserialize(fileStream) ?? new List<Card>());

            // If deserialization fails, initializes an empty list.
            if (cards == null)
            {
                cards = new List<Card>();
            }

        }
        catch (Exception ex)
        {
            // Handles any errors during loading...
            throw new IOException($"Error loading deck from XML: {ex.Message}");
        }
    }
}
