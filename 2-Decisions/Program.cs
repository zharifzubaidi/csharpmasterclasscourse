// Decisions in C#

using System.Globalization;
using System.Threading.Tasks.Sources;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Example 1: Logical Operators
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        bool isRainy = false;
        bool hasUmbrella = false;

        Console.WriteLine("Is it raining? (true/false)");
        isRainy = bool.Parse(Console.ReadLine() ?? "false");
        Console.WriteLine("Do you have an umbrella? (true/false)");
        hasUmbrella = bool.Parse(Console.ReadLine() ?? "false");

        if (isRainy && hasUmbrella)
        {
            Console.WriteLine("You can go outside with your umbrella.");
        }
        else if (isRainy && !hasUmbrella)
        {
            Console.WriteLine("You should stay inside, it's raining and you don't have an umbrella.");
        }
        else if(!isRainy || !hasUmbrella)
        {
            Console.WriteLine("It's not raining, you can go outside without an umbrella.");
        }

    }
    else if (userInput == "2")
    {
        // Example 2: Relational Operators
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        int num1 = 0;
        int num2 = 10;
        int age = 18;

        bool isGreater = num1 > num2;

        if(age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if(age < 19 && age >= 13)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are a child.");
        }
    }
    else if (userInput == "3")
    {
        // Example 3:Equality operator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");
        
        int inputNumber = 0;
        
        Console.Write("Please enter a number: ");

        if (inputNumber == (int.Parse(Console.ReadLine() ?? "0"))) // null coalescing operator
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            Console.WriteLine("The numbers are not equal");
        }

    }
    else if (userInput == "4")
    {
        // Example 4:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine() ?? "0");
        //bool isWithParents = false;

        if(age >= 18)
        {
            Console.WriteLine("Go party in the club!");
        }
        else if (age >= 13)
        {
            Console.WriteLine("Are you with your parents? Answer with y or n?");
            string isWithParentsString = Console.ReadLine() ?? "0";
            if(isWithParentsString == "y")
            {
                Console.WriteLine("Go party in the club with your parents");
            }
            else
            {
                Console.WriteLine("No party for you today");
            }
        }
        else
        {
            Console.WriteLine("Cannot go to party!");
        }


    }
    else if (userInput == "5")
    {
        // Example 5: One line if statements
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        int month = 5;
        string monthName;

        if (month == 1)
        {
            monthName = "January";
        }
        else if (month == 2)
            monthName = "February";
        else if (month == 3)
            monthName = "March";
        else
            monthName = "Unknown";

        Console.WriteLine(monthName);

    }
    else if (userInput == "6")
    {
        // Example 6: Switch-case statements
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        int month = 0;

        Console.WriteLine("Please enter your month: ");
        month = int.Parse(Console.ReadLine() ?? "0");

        switch (month)
        {
            case 1:
                Console.WriteLine("The month is January");
                break;

            case 2:
                Console.WriteLine("The month is February");
                break;

            default:
                Console.WriteLine("No valid month was entered. Please try again.");
                break;
        }

    }
    else if (userInput == "7")
    {
        // Example 7: Quiz logic
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        string question1 = "What is the capital of Germany";
        string answer1 = "Berlin";

        string question2 = "What is 2 + 2?";
        string answer2 = "4";

        string question3 = "What color do you get by mixing blue and yellow?";
        string answer3 = "Green";

        int score = 0;

        Console.WriteLine(question1);
        string userAnswer1 = Console.ReadLine() ?? "Incorrect";
        if(userAnswer1.Trim().ToLower() == answer1.ToLower())
        {
            Console.WriteLine("Correct!");
            score = score++;
        }
        else
        {
            Console.WriteLine("Wrong, the correct answer is: " + answer1);
        }

        Console.WriteLine(question2);
        string userAnswer2 = Console.ReadLine() ?? "Incorrect";
        if (userAnswer2.Trim().ToLower() == answer2.ToLower())
        {
            Console.WriteLine("Correct!");
            score = score++;
        }
        else
        {
            Console.WriteLine("Wrong, the correct answer is: " + answer2);
        }

        Console.WriteLine(question3);
        string userAnswer3 = Console.ReadLine() ?? "Incorrect";
        if (userAnswer3.Trim().ToLower() == answer3.ToLower())
        {
            Console.WriteLine("Correct!");
            score = score++;
        }
        else
        {
            Console.WriteLine("Wrong, the correct answer is: " + answer3);
        }

        Console.WriteLine($"Quiz completed! Your final score is: {score}/3");

        if(score == 3)
        {
            Console.WriteLine("Excellent. You got all the answers right");
        }
        else if(score > 0)
        {
            Console.WriteLine("Good job but keep learning!");
        }
        else
        {
            Console.WriteLine("Please try again.");
        }

    }
    else if (userInput == "8")
    {
        // Example 8: Try parse to confirm user input is a number type
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");

        Console.WriteLine("Give me a number: ");
        string inputString = Console.ReadLine();
        //int num1 = int.Parse(inputString);      
        int num1 = 0;
        bool isNumber = int.TryParse(inputString, out num1);
        if (isNumber)   // need to ensure value loaded are integer type. Load default value of 0 if no integer was entered
        {
            num1++;
            Console.WriteLine("User entered number +1 " + num1);
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }
    }
    else if (userInput == "9")
    {
        // Example 9: Random number
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 9:");
        Console.WriteLine("*****************************");

        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.WriteLine("Guess the number: ");

        string inputString = Console.ReadLine();
        int num1 = 0;

        bool isNumber = int.TryParse(inputString, out num1);
        if (isNumber)
        {
            if(num1 == randomNumber)
            {
                Console.WriteLine("You guessed it right!");
            }
            else
            {
                Console.WriteLine("You guessed it wrong!");
            }
        }
        else
        {
            Console.WriteLine("You need to enter a number");
        }

    }
    else if (userInput == "10")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 10:");
        Console.WriteLine("*****************************");

        int num1 = 0;
        int num2 = 0;
        bool isNumber1 = false;
        bool isNumber2 = false;
        int result = 0;

        Console.WriteLine("Enter the first number: ");
        string firstNumber = Console.ReadLine();

        Console.WriteLine("Enter the second number: ");
        string secondNumber = Console.ReadLine();

        Console.WriteLine("Please select your operation (+, -, *, /) :");
        string operatorSelection = Console.ReadLine();

        isNumber1 = int.TryParse(firstNumber, out num1);
        isNumber2 = int.TryParse(secondNumber, out num2);

        if (isNumber1 && isNumber2)
        {
            switch (operatorSelection)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 *  num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a whole number");
        }

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Please try again");
}