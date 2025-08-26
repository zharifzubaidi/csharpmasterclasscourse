
using System.Globalization;

// Method 
void MyFirstMethod()
{
    Console.WriteLine("MyFirstMethod is called");
}
void Write() 
{
    Console.WriteLine("Writing....");
}

void WriteSomething(string myString)
{
    Console.WriteLine("This is what I'm writing:\n" + myString);
}

int AddTwoValue(int value1, int value2)
{
    return value1 + value2;
}


// Printing and method calls
string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Example 1:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        MyFirstMethod(); 
        Write();
        WriteSomething("Hello world!");
        


    }
    else if (userInput == "2")
    {
        // Example 2: 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        int inputValue1 = 0;
        int inputValue2 = 0;

        Console.Write("Enter your first whole number: ");
        int.TryParse(Console.ReadLine(), out inputValue1);

        Console.Write("Enter your second whole number: ");
        int.TryParse(Console.ReadLine(), out inputValue2);

        int result = AddTwoValue(inputValue1, inputValue2);

        Console.WriteLine($"The result of {inputValue1} and {inputValue2} is {result}");

    }
    else if (userInput == "3")
    {
        // Example 3:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");


    }
    else if (userInput == "4")
    {
        // Example 4:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

       
    }
    else if (userInput == "5")
    {
        // Example 5:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "6")
    {
        // Example 6:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");


    }
    else if (userInput == "7")
    {
        // Example 7:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");


    }
    else if (userInput == "8")
    {
        // Example 8:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "9")
    {
        // Example 9:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 9:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "10")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 10:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Please try again");
}