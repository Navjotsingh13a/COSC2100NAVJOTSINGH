// Name: Navjot Singh
// Student Id: 100931376
// Date: October 18, 2024.
// Modified: October 18, 2024.
// Description: This WPF application manages a car inventory, allowing users to add, reset, and
// shows car details with input validation.

using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace CarLotInventoryApp
{
    public partial class MainWindow : Window
    {
        // List to store the car inventory...
        private List<Car> carList = new List<Car>();

        public MainWindow()
        {
            InitializeComponent();
            // Load car manufacturers into the comboBox...
            LoadMakes();
            // Load car colours into the comboBox...
            LoadColours();
            // Load car years into the comboBox...
            LoadYears();
        }

        // Load car manufacturers into the Make comboBox...
        private void LoadMakes()
        {
            comboBoxMake.Items.Add("Toyota");
            comboBoxMake.Items.Add("Honda");
            comboBoxMake.Items.Add("Mercedes");
            comboBoxMake.Items.Add("Ford");
            comboBoxMake.Items.Add("Hyundai");
            comboBoxMake.Items.Add("BMW");
            comboBoxMake.Items.Add("Audi");
            comboBoxMake.Items.Add("Lexus");
            comboBoxMake.Items.Add("Volkswagen");
            comboBoxMake.Items.Add("Tesla");
        }

        // Load car colours into the Colour comboBox...
        private void LoadColours()
        {
            comboBoxColour.Items.Add("Red");
            comboBoxColour.Items.Add("Blue");
            comboBoxColour.Items.Add("Black");
            comboBoxColour.Items.Add("White");
            comboBoxColour.Items.Add("Yellow");
            comboBoxColour.Items.Add("Green");
            comboBoxColour.Items.Add("Orange");
            comboBoxColour.Items.Add("Brown");
            comboBoxColour.Items.Add("Purple");
            comboBoxColour.Items.Add("Sky");
        }

        // Load years from current year -- 50 years ago into the Year comboBox
        private void LoadYears()
        {
            for (int year = DateTime.Now.Year; year >= DateTime.Now.Year - 50; year--)
            {
                comboBoxYear.Items.Add(year);
            }
        }

        // Validate user inputs to ensure all fields are correctly filled or not ...
        private bool ValidateInputs()
        {
            labelResult.Content = "";
            if (comboBoxMake.SelectedItem == null)
            {
                labelResult.Content = "Please select a manufacturer of the car.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxModel.Text))
            {
                labelResult.Content = "Model cannot be empty. Please enter a model of the car.";
                return false;
            }
            if (comboBoxColour.SelectedItem == null)
            {
                labelResult.Content = "Please select the colour of the car.";
                return false;
            }
            if (comboBoxYear.SelectedItem == null)
            {
                labelResult.Content = "Please select the year of the car.";
                return false;
            }
            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || price < 0)
            {
                labelResult.Content = "Price must be number.";
                return false;
            }
            return true;
        }

        // Handle the Enter Button click to add a new car or update an existing one...
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs first...
            if (!ValidateInputs())
                return;

            decimal.TryParse(textBoxPrice.Text, out decimal Price);

            // If a car is selected, update it...
            if (dataGridCars.SelectedItem is Car selectedCar)
            {
                comboBoxMake.SelectedItem = selectedCar.Make;
                textBoxModel.Text = selectedCar.Model;
                comboBoxColour.SelectedItem = selectedCar.Colour;
                comboBoxYear.SelectedItem = selectedCar.Year;
                textBoxPrice.Text = selectedCar.Price.ToString();
                checkBoxNew.IsChecked = selectedCar.IsNew;
            
                labelResult.Content = $"Existed Car updated Successfully:";
                // Reset inputs after updating...
                ResetInputs();
            }
            // Or Add a new car if no car is selected...
            else
            {
                // Create a new car with entries ....
                Car newCar = new Car(comboBoxMake.Text, textBoxModel.Text, comboBoxColour.Text, (int)comboBoxYear.SelectedItem, Price, checkBoxNew.IsChecked == true);
                // Add the new car to the list...
                carList.Add(newCar);

                labelResult.Content = "New Car Added Succesfully...";

                ResetInputs();
            }
            // Refresh the DataGrid to show the updated car list...
            dataGridCars.ItemsSource = null;
            dataGridCars.ItemsSource = carList;
        }

        // Handle the Reset Button click to clear input fields...
        private void ButtonReset_Click(object sender, RoutedEventArgs e) 
        {
            ResetInputs();
            // Deselect any selected car...
            dataGridCars.SelectedIndex = -1;
            // Clear the message label...
            labelResult.Content = "";
        }

        // Clear all input fields and reset selections...
        private void ResetInputs()
        {
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBoxColour.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            textBoxPrice.Clear();
            checkBoxNew.IsChecked = false;
        }

        // Handle the Exit Button click to close the application...
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}