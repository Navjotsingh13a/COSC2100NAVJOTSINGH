// Name: Navjot Singh
// Student Id: 100931376
// Date: October 18, 2024.
// Modified: October 18, 2024.
// Description: The Car class keeps track of car details and counts how many cars there are,
// using properties and methods to create and show the information...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotInventoryApp
{
    public class Car
    {
        // Private field to track the total number of cars...
        private static int count = 0;

        // Private fields for each thing...
        private int carIdentificationNumber = 0;
        private string carMake = string.Empty;
        private string carModel = string.Empty;
        private string carColour = string.Empty;
        private int carYear = 0;
        private bool carNewStatus = false;
        private decimal carPrice = 0.0M;

        // Default Constructor...
        public Car()
        {
            count++;
            carIdentificationNumber = count;
        }

        // Parameterized constructor...
        public Car(string make, string model, string colour, int year, decimal price, bool status) : this()
        {
            // Assign private values bsed on the parameterized passed in....
            Make = make;   
            Model = model; 
            Colour = colour; 
            Year = year; 
            Price = price; 
            IsNew = status; 
        }

        // Returns the total number of cars created...
        public static int GetCount()
        {
            return count;
        }

        // Property for IdentificationNumber (read-only)...
        public int IdentificationNumber
        {
            get { return carIdentificationNumber; }
        }

        // Property to get or set the car's make...
        public string Make
        {
            get 
            { 
                return carMake; 
            }
            set
            {
                carMake = value;
            }
        }

        // Property to get or set the car's model...
        public string Model
        {
            get 
            { 
                return carModel; 
            }
            set
            {
                carModel = value;
            }
        }

        // Property to get or set the car's colour...
        public string Colour
        {
            get 
            { 
                return carColour; 
            }
            set
            {
                carColour = value;
            }
        }

        // Property to get or set the car's year...
        public int Year
        {
            get 
            {
                return carYear; 
            }
            set
            {
                carYear = value;
            }
        }

        // Property to get or set the car's price...
        public decimal Price
        {
            get 
            { 
                return carPrice; 
            }
            set
            {
                carPrice = value;
            }
        }

        // Property to get or set if the car is new...
        public bool IsNew
        {
            get 
            { 
                return carNewStatus; 
            }
            set 
            { 
                carNewStatus = value; 
            }
        }

        // Override ToString to display car's details...
        public override string ToString()
        {
            string status = carNewStatus ? "New" : "Used";
            return "ID: " + carIdentificationNumber + ", Make: " + carMake +
                   ", Model: " + carModel + ", Colour: " + carColour +
                   ", Year: " + carYear + ", Price: $" + carPrice +
                   ", Status: " + status;
        }
    }
}