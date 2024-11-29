// Name: Navjot Singh
// Student ID: 100931376
// Date: November 28, 2024
// Modified: November 28, 2024
// Assignment 5 -> Data Persistence and UI
// Description: This WPF application helps to create, manage, shuffle, deal, and reset a deck of cards with a user-friendly interface,
// including features for saving and loading decks in JSON or XML, adding custom cards, and switching persistence formats...

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Advanced_DeckBuilder
{
    public partial class MainWindow : Window
    {
        // The main deck of cards...
        private StandardDeck standardDeck;
        // Manages saving and loading the deck...
        private DeckPersistenceManager deckpersistenceManager;

        public MainWindow()
        {
            InitializeComponent();
            // Creates a standard deck...
            standardDeck = new StandardDeck();
            // Default saves in JSON format...
            deckpersistenceManager = new DeckPersistenceManager(new JsonDeckCardPersistence());
        }

        // Shows the current deck in the list view...
        private void ViewDeckButton_Click(object? sender, RoutedEventArgs? e)
        {
            // Clears the list first...
            DeckListView.Items.Clear();
            for (int i = 0; i < standardDeck.Cards.Count; i++)
            {
                // Adds each card to the list....
                DeckListView.Items.Add(standardDeck.Cards[i].ToString());
            }
        }

        // Shuffles the deck and updates the view...
        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            standardDeck.Shuffle();
            ViewDeckButton_Click(null, null);
            MessageBox.Show("Deck shuffled..", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Deals cards and displays them...
        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            // Validates input....
            if (!int.TryParse(DrawTextBox.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Please enter a positive number for the cards to draw...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Checks if enough cards are available...
            if (count > standardDeck.Cards.Count)
            {
                MessageBox.Show("Not enough cards to draw...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Clears the dealt cards list...
            DealtCardsListBox.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                var card = standardDeck.Deal();
                DealtCardsListBox.Items.Add(card.ToString());
            }

            // Updates the main deck view...
            ViewDeckButton_Click(null, null);
            MessageBox.Show($"{count} card(s) dealt successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Saves the deck to a file...
        private void SaveDeckMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath;

                // Decides the format...
                if (deckpersistenceManager is XmlDeckCardPersistence)
                {
                    filePath = "deck.xml";
                }
                else
                {
                    filePath = "deck.json";
                }
                // Saves the deck....
                deckpersistenceManager.SaveDeck(standardDeck, filePath);
                MessageBox.Show($"Deck saved successfully to {filePath}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving deck: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Loads the deck from a file...
        private void LoadDeckMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath;

                // Decides the format...
                if (deckpersistenceManager is XmlDeckCardPersistence)
                {
                    filePath = "deck.xml";
                }
                else
                {
                    filePath = "deck.json";
                }

                standardDeck = (StandardDeck)deckpersistenceManager.LoadDeck(filePath);
                MessageBox.Show($"Deck loaded successfully from {filePath}.");
                // Updates the view....
                ViewDeckButton_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading deck: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Switches to XML for saving/loading...
        private void SwitchToXml_Click(object sender, RoutedEventArgs e)
        {
            deckpersistenceManager.SetPersistence(new XmlDeckCardPersistence());
            MessageBox.Show("Now using XML Persistence...", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Switches to JSON for saving/loading...
        private void SwitchToJson_Click(object sender, RoutedEventArgs e)
        {
            deckpersistenceManager.SetPersistence(new JsonDeckCardPersistence());
            MessageBox.Show("Now using JSON Persistence...", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Clears the deck and updates the view....
        private void ClearAllMenuItem_Click(object sender, RoutedEventArgs e)
        {
            standardDeck.ClearDeck();
            DeckListView.Items.Clear();
            DealtCardsListBox.Items.Clear();
            MessageBox.Show("Deck is now empty....", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Displays a help message...
        private void HelpMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application helps you to create, shuffle, and manage a deck of cards...", "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Displays an about message...
        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DeckBuilder App build by Mr.Navjot Singh...", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Handles the exit process with a confirmation....
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Do you want to discard unsaved changes before exiting?",
                "Exit Confirmation",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question
            );

            // Resets the deck and exits...
            if (result == MessageBoxResult.Yes)
            {
                standardDeck.ResetDeck();
                Application.Current.Shutdown();
            }
            // Exits without resetting....
            else if (result == MessageBoxResult.No)
            {
                Application.Current.Shutdown();
            }
        }

        // Export the deck to a JSON file...
        private void ExportToJsonMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Define the file path for saving in JSON format...
                string filePath = "deck.json";
                deckpersistenceManager.SaveDeck(standardDeck, filePath);
                MessageBox.Show("Deck saved to JSON successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving deck to JSON: { ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Export the deck to an XML file...
        private void ExportToXmlMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Define the file path for saving in XML format...
                string filePath = "deck.xml";
                deckpersistenceManager.SaveDeck(standardDeck, filePath);
                MessageBox.Show("Deck saved successfully to XML...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving deck to XML: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Adds a custom card to the deck...
        private void AddCustomButton_Click(object sender, RoutedEventArgs e)
        {
            string suit = SuitTextBox.Text.Trim();
            string rank = RankTextBox.Text.Trim();

            // Checks if suit is empty....
            if (string.IsNullOrWhiteSpace(suit))
            {
                MessageBox.Show("Suit cannot be blank or just spaces...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Checks if rank is empty....
            if (string.IsNullOrWhiteSpace(rank))
            {
                MessageBox.Show("Rank cannot be blank or just spaces...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            standardDeck.AddCard(new Card(suit, rank));
            SuitTextBox.Clear();
            RankTextBox.Clear();
            // Updates the deck view...
            ViewDeckButton_Click(null, null);
            MessageBox.Show("Custom card added...", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Resets the deck to a standard deck....
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            standardDeck.ResetDeck();
            // Clears and update the list view...
            DeckListView.Items.Clear();
            ViewDeckButton_Click(null, null);
            MessageBox.Show("Deck reset...", "Reset", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}