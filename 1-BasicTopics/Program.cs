// Basic topics in C#

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your topic: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tTopic 1:");
        Console.WriteLine("*****************************");

        // Prints out a message to the console
        Console.WriteLine("Hello world");

        // Takes user input and load it as a string
        string? userInput2 = Console.ReadLine();
        Console.WriteLine($"You entered: {userInput2}");


    }
    else if (userInput == "2")
    {
        // Convert from if else to switch
        Console.WriteLine("*****************************");
        Console.WriteLine("\tTopic 2:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "3")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tTopic 3:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}