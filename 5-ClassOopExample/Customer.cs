using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Customer
    {
        // Use field in properties only when you need to control access to the data
        // Static field to hold the next ID available
        private static int nextId = 1;
        // Readonly fields are set once and cannot be changed after that
        private readonly int _id;
        // Backing field for write-only property - can only be set in the constructor
        private string? _password;

        // Properties
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        // Read only property - only has a getter, no setter
        public int Id {
            get
            {
                return _id; // Return the unique ID for this customer instance
            }
        }
        // Write-only property - only has a setter, no getter
        public string Password
        {
            set
            {
                // Here you can add logic to validate the password if needed
                _password = value; // Set the password to the provided value
            }
        }

        // Default constructor - when no arguments are provided
        public Customer()
        {
            Name = "Unknown";
            Address = "Unknown";
            ContactNumber = "Unknown";
            _id = nextId++; // Assign the current nextId to _id and then increment nextId for the next instance
        }

        // Custom constructor
        // shortcut ctor + tab to create a constructor
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
            _id = nextId++; // Assign the current nextId to _id and then increment nextId for the next instance
        }
        public Customer(string name)
        {
            Name = name;
            _id = nextId++; // Assign the current nextId to _id and then increment nextId for the next instance
        }

        // Methods
        public void SetDetails(string name, string address, string contactNumber = "NA") // Optional parameter with default value
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Address: {Address}, Contact Number: {ContactNumber}");
        }

        // Static method
        // Static method indicate that we can called this method without creating an instance of the class
        // In C#, static keyword is used to declare the member of the a class that belongs to the class
        // itself rather than to any specific instance of the class.
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Customer Management System!");
        }


    }
}
