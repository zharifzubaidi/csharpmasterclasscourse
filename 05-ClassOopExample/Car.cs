using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Car
    {
        
        // Overall class data access flow is constructor -> properties -> methods
        // Member variables (fields) inside of the Car class
        // Backing field of the property
        // Always private
        //private string _model = "";
        private string _brand = "";
        private bool _isLuxury;
        public static int NumberOfCars = 0; // Static field to keep track of the number of Car instances created

        // Property - allows controlled access to the private fields. The middleman between the field and the outside world.
        // Part of the encapsulation principle in OOP
        // Property that encapsulates the model private field - gatekeep with rules for setter and getter

        //public string Model { get => _model; set => _model = value; }
        public string? Model { get; set; } // default set and get to behave like a normal variable
        
        // Override how variable behaves with custom logic for getter and setter with backing fields
        public string? Brand {
            get
            {   // Getter logic to return a formatted string based on the luxury status
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {   // Setter logic to validate the value before setting it
                if (string.IsNullOrEmpty(value)) // Check if the value is null or empty
                {
                    Console.WriteLine("Brand cannot be null or empty.");
                    _brand = "No Brand";
                    //throw new ArgumentException("Brand cannot be null or empty.");
                }
                else
                {
                    _brand = value;
                }
            } 
        }

        // Use lambda expression for simple getters and setters with backing fields
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Default constructor - when no arguments are provided
        public Car()
        {
            Model = "Unknown";
            Brand = "Unknown";
            IsLuxury = false;           
            Console.WriteLine("A new car has been created!");
            NumberOfCars++; // Increment the static field to keep track of the number of cars
        }

        // Custom Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;

            Console.WriteLine($"{_brand} {Model} has been created!");

            IsLuxury = isLuxury;
            NumberOfCars++;
        }

        // Methods
        public void UpdateCarModel(string model)
        {
            Model = model;
            Console.WriteLine($"The car model has been updated to {Model}.");
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }
        
    }
}
