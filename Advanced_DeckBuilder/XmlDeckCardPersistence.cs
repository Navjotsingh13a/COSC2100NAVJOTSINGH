// Name: Navjot Singh
// Date: November 28, 2024
// Modified: November 28, 2024
// Description: This class handles saving and loading a deck of cards in XML format...

using System.IO;
using System.Xml.Serialization;


public class XmlDeckCardPersistence : IDeckPersistence
{
    // Method to save a deck of cards to an XML file...
    public void Save(Deck deck, string filePath)
    {
        // Creates a serializer for a list of cards...
        XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));

        // Opens a file and writes the deck's cards into it in XML format...
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            // Serialize the deck's cards and write to the file...
            serializer.Serialize(fileStream, deck.Cards);
        }
    }

    // Method to load a deck of cards from an XML file.
    public Deck Load(string filePath)
    {
        // Checks if the XML file exists; throws an error if it doesn't...
        if (!File.Exists(filePath))
            throw new FileNotFoundException("The XML file does not exist.");
        // Creates a serializer for a list of cards...
        XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));

        // Opens the file and reads the list of cards...
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            var cards = (List<Card>)serializer.Deserialize(fileStream);
            Deck deck = new Deck();
            // Adds each card from the list into the deck...
            for (int i = 0; i < cards.Count; i++) 
            {
                deck.AddCard(cards[i]);
            }
            return deck;
        }
    }
}
