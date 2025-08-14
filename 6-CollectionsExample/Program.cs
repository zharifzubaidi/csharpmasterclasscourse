using System.Diagnostics;
using System.Drawing;

namespace CollectionsExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string? userInput = ""; // declare the string to expect a null value
            Console.Write("Please select your example: ");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                if (userInput == "1")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Basic List
                    // Declaring a list and initialise it
                    List<string> colors = new List<string>();

                    // Add new item to the list
                    colors.Add("Red");
                    colors.Add("Blue");
                    colors.Add("Green");
                    colors.Add("Red");
                    Console.WriteLine("After add items: ");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    Console.WriteLine("-----------------------------");

                    // Remove item from list. The first red found in list only will be deleted.
                    bool isDeletingSuccessful = colors.Remove("Red");
                    if (isDeletingSuccessful)
                    {
                        Console.WriteLine("Remove was successful");
                        Console.WriteLine("After remove item: ");
                        foreach (string color in colors)
                        {
                            Console.WriteLine($"Current color: {color}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remove was not successful");
                    }

                    Console.WriteLine("-----------------------------");

                    // Remove all read until unable to find red anymore
                    colors.Add("Blue");
                    Console.WriteLine("Before deleting");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    isDeletingSuccessful = colors.Remove("Blue");
                    while (isDeletingSuccessful)
                    {
                        isDeletingSuccessful = colors.Remove("Blue");
                    }

                    Console.WriteLine("Remove was successful");
                    Console.WriteLine("After remove item: ");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    Console.WriteLine("-----------------------------");

                    // Initialisation of list with items directly
                    List<string> shapes =
                        [
                            "rectangle",
                            "square",
                            "circle",
                            "oval"
                        ];

                    Console.WriteLine("List of shapes: ");
                    foreach (string shape in shapes)
                    {
                        Console.WriteLine($"Current shape is {shape}");
                    }


                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Sorting List
                    List<int> listNumbers = new List<int> { 62, 12, 154, 78, 92, 7, 38 };

                    Console.Write("Unsorted numbers: ");
                    foreach (int number in listNumbers)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                    listNumbers.Sort();

                    Console.Write("Sorted numbers: ");
                    foreach (int number in listNumbers)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Findall method
                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // This will return a list of numbers that are 10 and higher
                    List<int> higherEqualTen = numbers.FindAll(x => x >= 10); // this is using lambda expression (=>) right side is the return
                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach(int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                    int numberSquare = Squaring(40);
                    Console.WriteLine($"The number square method result made using lambda expression: {numberSquare}");
                    
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Predicate
                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // Storing lambda expression inside a predicate and using in FindAll method
                    Predicate<int> isGreaterThanTen = x => x >= 10;

                    //List<int> higherEqualTen = numbers.FindAll(x => x >= 10);

                    List<int> higherEqualTen = numbers.FindAll(isGreaterThanTen);

                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach (int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    /*
                     * In C#, a delegate is like a pointer or a reference to a method
                     * It allows you to pass methods as arguments to the other methods,
                     * store them in variables, and call them later.
                     * This is useful when you want your code to be flexible and able
                     * to handle different behaviors that aren't predetermined.
                     * We can assigned a full method into a predicate.
                     */

                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // Any method of List - Determine whether ANY element of a sequence exist or satisfies a condition
                    var hasLargeNumber = numbers.Any(x => x > 20);

                    if(hasLargeNumber )
                    {
                        Console.WriteLine("There is large numbers in the list");
                    }
                    else
                    {
                        Console.WriteLine("No large numbers in the list");
                    }

                    // Predicate
                    Predicate<int> isGreaterThanTen = IsGreaterThanTen; // A method name directly assigned to predicate without ()

                    List<int> higherEqualTen = numbers.FindAll(isGreaterThanTen);

                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach (int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");


                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "7")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "8")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "9")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "10")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else
                {

                }

                Console.WriteLine("Thank you! Please press enter to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        /// <summary>
        /// Lambda expression consists of 2 parts
        /// 1. Parameters
        /// 2. Expression or statement block
        /// Parameters are written on the left side of =>
        /// (this symbol is read as "goes to" or "becomes").
        /// The expression or action to perform is on the right side
        /// This reads as:
        /// Take an input x and turn it into x multiplied by x
        /// x => x * x;
        /// </summary>
        /// <param name="num1">The number to square</param>
        /// <returns>The square of the input number</returns>
        public static int Squaring(int num1) => num1 * num1;

        // Normal method declaration
        //public static int Squaring(int num)
        //{
        //    return num * num;
        //}

        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }

    }
}
