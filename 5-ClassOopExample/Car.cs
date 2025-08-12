using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Car
    {
        // Member variables (fields) inside of the Car class
        // Private hide fields from other classes
        private string _model = "";
        private string _brand = "";

        // Property - allows controlled access to the private fields. The middleman between the field and the outside world.
        // Part of the encapsulation principle in OOP
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand;
            set {
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

        // Constructor
        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"{_brand} {_model} has been created!");

        }

        public void UpdateCarModel(string model)
        {
            Model = model;
            Console.WriteLine($"The car model has been updated to {_model}.");
        }
        
    }
}
