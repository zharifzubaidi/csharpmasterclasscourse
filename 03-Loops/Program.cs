// Loops

using System.Globalization;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Example 1: For loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");


        int length = 10;

        for (int i = 0; i < length; i++) // Run while true
        {
            Console.WriteLine($"I is {i}");
        }

    }
    else if (userInput == "2")
    {
        // Example 2: 
        Console.WriteLine("*****************************");

        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        string myString = "Hi \r\nHi";
        for (int counter = 10; counter >= 0; counter--)
        {
            Console.WriteLine("Counter is " + counter);
            //Console.WriteLine(myString);
            Thread.Sleep(1000);
        }
    }
    else if (userInput == "3")
    {
        // Example 3:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        // in strings \ is an "Escape Character"
        // \n stands for "new line"
        // \r - carriage return

        string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

        for (int counter = 10; counter >= 0; counter--)
        {
            Console.Clear();
            Console.WriteLine("Counter is " + counter);
            Console.WriteLine(rocket);
            rocket = "\r\n" + rocket;
            Thread.Sleep(1000);
        }
        Console.WriteLine("The Rocket has Landed!");

    }
    else if (userInput == "4")
    {
        // Example 4: While loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        //int counter = 0;
        //while(counter < 10)
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}

        //bool isGood = true;

        Console.WriteLine("Enter go or stay");

        string userChoice = Console.ReadLine();

        //while (isGood)  // Run while true
        while (userChoice == "go")
        {
            //Console.WriteLine("Life is good");
            //isGood = false;

            Console.WriteLine("Go for a mile");
            Console.WriteLine("Wanna keep going? Enter go.");
            userChoice = Console.ReadLine();
        }

        Console.WriteLine("You are staying. Bye bye.");

    }
    else if (userInput == "5")
    {
        // Example 5:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        Random random = new Random();

        int secretNumber = random.Next(1, 101);
        int userGuess = 0;
        int counter = 0;

        Console.WriteLine("Guess the number I'm thinking of between 1 and 100");

        while(userGuess != secretNumber)
        {
            counter++;
            Console.WriteLine("Enter your guess:");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess < secretNumber)
            {
                Console.WriteLine("Too low! Try again");
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("Too high! Try again");
            }
            else
            {
                Console.WriteLine($"You got it right! The number is {userGuess}. The number of tries needed was {counter}");
            }
        }

    }
    else if (userInput == "6")
    {
        // Example 6:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("Enter your character's name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine("Choose your character type (Warrior, Wizard, Archer");
        string characterType = Console.ReadLine();

        Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest.");
        Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

        string choice1 = Console.ReadLine();

        if (choice1.ToLower() == "enter")
        {
            Console.WriteLine("You bravely enter the forest");

        }
        else
        {
            Console.WriteLine("You decide to camp out and wait for daylight.");
        }

        bool gameContinues = true;

        while (gameContinues)
        {
            Console.WriteLine("You come to a fork in the road. Go left or right?");
            string direction = Console.ReadLine();
            if (direction.ToLower() == "left")
            {
                Console.WriteLine("You find a treasure chest!");
                gameContinues = false;
            }
            else
            {
                Console.WriteLine("You encounter a wild beast!");
                Console.WriteLine("Fight or flee? (fight/flee)");
                string fightChoice = Console.ReadLine();
                if (fightChoice.ToLower() == "fight")
                {
                    Random random = new Random();
                    int luck = random.Next(1, 11);
                    if (luck > 5)
                    {
                        Console.WriteLine("You beat the wild beast!");
                        if (luck > 8)
                        {
                            Console.WriteLine("The wild beast dropped a treasure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The beast attacked you where you didn't expect it!");
                        Console.WriteLine("It rammed it's tusks into your chest and you bleed out!");
                        gameContinues = false;
                    }
                }
            }
        }

        Console.WriteLine("Game Over!");
        Console.WriteLine("Thank you for playing the game!");

    }
    else if (userInput == "7")
    {
        // Example 7: Do-while loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        int counter = 0;
        int currentScore;
        int sum = 0;

        do
        {
            Console.WriteLine("Enter your students score. Enter -1 to finish!: ");
            currentScore = int.Parse(Console.ReadLine());
            if (currentScore > 0)
            {
                sum = sum + currentScore;
                counter++;
            }
        } while (currentScore != -1); // Will run at least one time

        int average = sum / counter;
        Console.WriteLine("The average score is: " + average);

    }
    else if (userInput == "8")
    {
        // Example 8: Array
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");

        int[] myIntArray = new int[5];
        int[] myIntArray2 = [1, 2, 3, 4, 5];
        string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

        myIntArray[0] = 324;
        myIntArray[1] = 123;
        myIntArray[2] = 450;
        myIntArray[3] = 13;
        myIntArray[4] = 155;

        for(int i = 0; i < myIntArray2.Length; i++)
        {
            Console.WriteLine(myIntArray2[i]);
        }

        foreach(int printInt in myIntArray)
        {
            Console.WriteLine(printInt);
        }

        foreach (string day in weekDays)
        {
            Console.WriteLine(day);
        }


    }
    else if (userInput == "9")
    {
        // Example 9: 2D Array and 3D array
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 9:");
        Console.WriteLine("*****************************");

        // 2D array
        int[,] array2DDeclaration = new int[3, 3];
        // [0] [0] [0]
        // [0] [0] [0]
        // [0] [0] [0]

        int[,] array2DInit = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        // [1] [2]
        // [3] [4]
        // [5] [6]

        Console.WriteLine("2D Array Example:");
        Console.WriteLine(array2DInit[0, 0]); // Accessing element at row 0, column 0

        string[,] ticTacToeField =
        {
            { "X", "O", "X" },
            { "O", "X", "O" },
            { "X", "O", "X" }
        };

        Console.WriteLine(ticTacToeField[1, 1]);

        // 3D array
        int[,,] array3DDeclaration = new int[3, 3, 3];

        string[,,] simple3DArray =
        {
            {
                {"825", "002" },    //0,0,0  ||  0,0,1
                {"010", "413" },
            },
            {
                {"230", "182" },
                {"062", "092" },
            },
            {
                {"444", "715" },
                {"216", "409" },
            }
        };
        Console.WriteLine(simple3DArray[0, 0, 0]);
        Console.WriteLine(simple3DArray[2, 0, 0]);

    }
    else if (userInput == "10")
    {
        // Example 10: Jagged array
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 10:");
        Console.WriteLine("*****************************");
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Printing elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    else if (userInput == "11")
    {
        // Example 11:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 11:");
        Console.WriteLine("*****************************");

        int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                rowSum += array2D[i, j];
            }
            Console.WriteLine($"{rowSum}");
        }

    }
    else if (userInput == "12")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 12:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "13")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 13:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "14")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 14:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "15")
    {
        // Example 10:
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 15:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Please try again");
}