// Name: Navjot Singh
// Student ID: 100931376
// Date: November 11, 2024
// Modified: November 11, 2024
// Assignment: 3 -> Inheritance, Collections, and Exception Handeling...
// Description: The code creates and manages a deck of cards, allowing users to add custom cards,
// shuffle, deal, and view them by suit and rank....

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

namespace Deck_Bulider
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Create a deck of custom cards...
        private CustomDeck customDeck = new CustomDeck();

        // When Add Custom button is clicked, get suit and rank from textboxes...
        private void AddCustomButton_Click(object sender, RoutedEventArgs e)
        {
            string suit = SuitTextBox.Text.Trim();
            string rank = RankTextBox.Text.Trim();

            // If the input is valid, add the card...
            if (IsValidCardInput(suit, rank))
            {
                customDeck.AddCustomCard(suit, rank);
                SuitTextBox.Clear();
                RankTextBox.Clear();
            }
            // Show error message if the input is not valid...
            else
            {
                MessageBox.Show("Please enter valid Suit and Rank....");
            }
        }

        // Check if suit and rank are not empty...
        private bool IsValidCardInput(string suit, string rank)
        {
            return !string.IsNullOrWhiteSpace(suit) && !string.IsNullOrWhiteSpace(rank);
        }

        // When View Deck button is clicked, show the deck in the ListView...
        private void ViewDeckButton_Click(object sender, RoutedEventArgs e)
        {
            DeckListView.ItemsSource = customDeck.ViewDeck();
        }

        // When Deal button is clicked, try to get number of cards to deal...
        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(DrawTextBox.Text, out int count) && count > 0 && count < customDeck.ViewDeck().Count)
            {
                // Deal the cards and show them...
                CardsDealtListView.ItemsSource = customDeck.Deal(count);
            }
            // Otherwise, show error if the number is invalid...
            else
            {
                MessageBox.Show("Enter a valid number of cards to draw.....");
            }
        }

        // When Shuffle button is clicked, shuffle the deck and update the view...
        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            customDeck.Shuffle();
            DeckListView.ItemsSource = customDeck.ViewDeck();
        }

        // When Reset button is clicked, reset the deck and clear everything...
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            customDeck.Reset();
            SuitTextBox.Clear();
            RankTextBox.Clear();
            DrawTextBox.Clear();
            DeckListView.ItemsSource = null;
            CardsDealtListView.ItemsSource = null;
        }

        // When Exit button is clicked, close the application....
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}