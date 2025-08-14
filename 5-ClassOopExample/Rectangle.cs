using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Rectangle
    {
        // Constant field to represent the number of sides in a rectangle.
        // Need to initialise at compile time during declaration.
        // Can be same for each instance of the class.
        public const int NumberOfSides = 4;
        // Readonly field to represent the color of the rectangle, set once in the constructor.
        // It can be assigned during runtime but only once.
        // Can be different for each instance of the class.
        public readonly string? Color;

        // Default constructor - when no arguments are provided
        public Rectangle()
        {
            Color = "No Color"; // Assign a default color
        }
        // Custom constructor to initialize the Color property
        public Rectangle(string? color)
        {
            Color = color; // Assign the color to the readonly field
        }

        // Property
        public double Width { get; set; }  
        public double Height { get; set; }

        // Computed property to calculate the area of the rectangle
        // If only getter is defined, it becomes a read-only property
        // If only setter is defined, it becomes a write-only property
        public double Area
        {
            get
            {
                return Width * Height; // Calculate area as width multiplied by height
            }
        }

        // Methods
        public void DisplayInfo()
        {
            // Display the rectangle's information
            Console.WriteLine($"Rectangle Color: {Color}");
            Console.WriteLine($"Width: {Width}, Height: {Height}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Number of Sides: {NumberOfSides}");
        }
    }
}
