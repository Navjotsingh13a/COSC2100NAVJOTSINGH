// Name: Navjot Singh
// Date: September 08, 2024
// Modified: September 08, 2024
// Description: This code creates a Tic Tac Toe game where players can enter their names,
// take turns, keep scores, and reset or exit the game using keyboard shortcuts.

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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        private string currentPlayer = "X"; // Current Player (X or O)...
        private Button[,] buttons = new Button[3, 3];  // 2D array to track buttons...
        private int scoreX = 0, scoreO = 0; // Scores for X and O...

        public MainWindow()
        {
            InitializeComponent();

            // Add buttons to the two - dimensional array...
            buttons[0, 0] = Button1;
            buttons[0, 1] = Button2;
            buttons[0, 2] = Button3;
            buttons[1, 0] = Button4;
            buttons[1, 1] = Button5;
            buttons[1, 2] = Button6;
            buttons[2, 0] = Button7;
            buttons[2, 1] = Button8;
            buttons[2, 2] = Button9;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Check if the button is empty...
            if (clickedButton.Content == null || clickedButton.Content.ToString() == string.Empty)
            {
                clickedButton.Content = currentPlayer;  // Set button to current player's symbol...
                clickedButton.IsEnabled = false;  // Disable the button...

                // Check if the current player won...
                if (CheckForWinner())
                {
                    MessageBox.Show($"{currentPlayer} wins!"); // if yes, show win message...
                    UpdateScore();  // Update the score...
                    ResetBoard();  // Reset the board...
                    return;
                }

                // Check if the board is full like match becomes a draw...
                if (IsBoardFull())
                {
                    MessageBox.Show("It's a draw!"); // Show the draw message...
                    ResetBoard();  // Reset the board...
                    return;
                }

                // Switch to the next player...
                currentPlayer = currentPlayer == "X" ? "O" : "X"; // Change current player...
                CurrentPlayerLabel.Content = $"Current Player: {currentPlayer}";  // Update the current player label
            }
        }

        // Check if a player won...
        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals...
            for (int index = 0; index < 3; index++)
            {
                // Check rows for a win...
                if (buttons[index, 0].Content != null && buttons[index, 1].Content != null && buttons[index, 2].Content != null &&
                    buttons[index, 0].Content.ToString() == currentPlayer && buttons[index, 1].Content.ToString() == currentPlayer && buttons[index, 2].Content.ToString() == currentPlayer)
                    return true;

                // Check columns for a win...
                if (buttons[0, index].Content != null && buttons[1, index].Content != null && buttons[2, index].Content != null &&
                    buttons[0, index].Content.ToString() == currentPlayer && buttons[1, index].Content.ToString() == currentPlayer && buttons[2, index].Content.ToString() == currentPlayer)
                    return true;
            }


            // Check diagonals for a win...
            if (buttons[0, 0].Content != null && buttons[1, 1].Content != null && buttons[2, 2].Content != null &&
                buttons[0, 0].Content.ToString() == currentPlayer && buttons[1, 1].Content.ToString() == currentPlayer && buttons[2, 2].Content.ToString() == currentPlayer)
                return true;

            if (buttons[0, 2].Content != null && buttons[1, 1].Content != null && buttons[2, 0].Content != null &&
                buttons[0, 2].Content.ToString() == currentPlayer && buttons[1, 1].Content.ToString() == currentPlayer && buttons[2, 0].Content.ToString() == currentPlayer)
                return true;
            // if no winner found, return false...
            return false;
        }

        // Check if the board is full...
        private bool IsBoardFull()
        {
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)  // If any button is still enabled, the board is not full...
                    return false;
            }
            // if the all buttons are disabled, means board is full...
            return true;
        }

        // Update the score labels...
        private void UpdateScore()
        {
            if (currentPlayer == "X")
                scoreX++; // Increment X's score...
            else
                scoreO++; // Increment O's score...

            XScoreLabel.Content = $"X: {scoreX}"; // Update X's score label...
            OScoreLabel.Content = $"O: {scoreO}"; // Update O's score label...
        }

        // Reset the board for another game...
        private void ResetBoard()
        {
            foreach (Button button in buttons)
            {
                button.Content = null;  // Clear the content of each button...
                button.IsEnabled = true;  // Re-enable all buttons for another game...
            }

            // Reset current player to X...
            currentPlayer = "X";
            CurrentPlayerLabel.Content = $"Current Player: {currentPlayer}"; // Update label...
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetBoard();  // Reset the board...
            scoreX = 0;  // Reset the scores...
            scoreO = 0;
            XScoreLabel.Content = $"X: {scoreX}"; // Update X's score label...
            OScoreLabel.Content = $"O: {scoreO}"; // Update O's score label...
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Close the application
        }
    }
}