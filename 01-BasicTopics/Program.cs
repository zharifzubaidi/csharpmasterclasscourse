// Basic topics in C#

using System.Globalization;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Example 1: Basic Input and Output
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        // Prints out a message to the console
        Console.Write("Enter something: ");

        // Takes user input and load it as a string
        string? userInput2 = Console.ReadLine();
        Console.WriteLine($"You entered: {userInput2}");

    }
    else if (userInput == "2")
    {
        // Example 2: Variable definition and initialization
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        // Variable definition
        string petsName;

        // Variable initialization
        petsName = "Fluffy";
        Console.WriteLine($"My pet's name is {petsName}.");

        // Variable override
        petsName = "Spot";
        Console.WriteLine($"My pet's name is {petsName}.");

    }
    else if (userInput == "3")
    {
        // Example 3: Convert from readline string to integer using int.Parse
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");
        
        // datatype variableName = initial value;
        int myNumber = 0;

        Console.Write("Enter a number: " + myNumber);

        // Need to convert the string input to an integer
        myNumber = int.Parse(Console.ReadLine());

    }
    else if (userInput == "4")
    {
        // Example 4: Simple integer calculator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        Console.Write("Enter the first whole number: ");
        int firstNumber = int.Parse(Console.ReadLine() ?? "0");  // Using null-coalescing operator to handle null input

        Console.Write("Enter the second whole number: ");
        int secondNumber = int.Parse(Console.ReadLine() ?? "0");

        int sum = firstNumber + secondNumber;

        // String interpolation to format the output
        Console.WriteLine(sum == 0 ? "The sum is zero" : $"The sum of {firstNumber} and {secondNumber} is {sum}");
    }
    else if (userInput == "5")
    {
        // Example 5: Calculator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        // Use CultureInfo.InvariantCulture for consistent parsing to handle decimal points correctly
        // dots vs commas in numbers

        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse((Console.ReadLine() ?? "0"), CultureInfo.InvariantCulture); 

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse((Console.ReadLine() ?? "0"), CultureInfo.InvariantCulture);

        double sum = firstNumber + secondNumber;

        Console.WriteLine(sum == 0 ? "The sum is zero" : $"The sum of {firstNumber.ToString(CultureInfo.InvariantCulture)} and {secondNumber} is {sum:F2}"); // F2 formats the number to 2 decimal places

    }
    else if (userInput == "6")
    {
        // Example 6: Data conversion and data types
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        // Explicitly typed variables
        string numberString = "123.45";
        int resultInt = int.Parse(numberString);
        Console.WriteLine($"Converted number: {resultInt}");

        string myBoolString = "true";
        bool resultBool = Convert.ToBoolean(myBoolString);
        Console.WriteLine($"Converted number: {resultBool}");

        // Implicitly typed variable
        var myFavNumber = 42;
        var myFavGenre = "LitRPGs";

        // Char data type. Any thing in UTF-16 can be a char (unicode)
        char myFavouriteCharacter = '☺';
        Console.WriteLine(myFavouriteCharacter);

    }
    else if (userInput == "7")
    {
        // Example 7: Operators and order of evaluation
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        int num1 = 105;
        Console.Write("Enter a whole number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Order of evaluation is from left to right
        // Not good -> Console.WriteLine("Substraction num1 - num2 = " + num1 - num2);
        Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2)); // Corrected with parentheses

    }
    else if (userInput == "8")
    {
        // Example 8: String manipulation methods
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");

        double num = 10.12541;
        double price = 19.9992;
        string name = "Widget";

        // String concatenation
        Console.WriteLine("Item: " + name.ToLower() + ", Quantity: " + 
            num.ToString("F2") + ", Price: " + price.ToString("C", CultureInfo.CurrentCulture));

        // String interpolation
        Console.WriteLine($"Item: {name.ToLower()}, Quantity: {num:F2}, Price: {price:C}");

        // String formatting with composite formatting
        Console.WriteLine("Item: {0}, Quantity: {1:F2}, Price: {2:C}", 
            name.ToLower(), num, price);

        // String with escape characters using backslash \
        Console.WriteLine("Item: \"{0}\", Quantity: {1:F2}, Price: {2:C}", 
            name.ToLower(), num, price);

    }
    else if (userInput == "9")
    {
        // Example
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 9:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "10")
    {
        // Example
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 10:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    //Console.ReadLine();
    Console.ReadKey();
}
else
{
    Console.WriteLine("Please try again");
}