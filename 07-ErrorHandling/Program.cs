
using System.Diagnostics;
using System.Numerics;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInput = "";
            Console.Write("Please select your example: ");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                if (userInput == "1")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Try and catch example
                    // Divide by zero example
                    int result = 0;
                    try
                    {
                        Console.WriteLine("Please enter a number");
                        int num1 = int.Parse(Console.ReadLine());
                        //int num1 = 0;
                        int num2 = 2;
                        result = num2 / num1;
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    Console.WriteLine($"The answer is: {result}");

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Debug log example

                    Debug.WriteLine("Main method is running");

                    int result = 0;
                    try
                    {
                        Console.WriteLine("Please enter a number");
                        int num1 = int.Parse(Console.ReadLine());
                        //int num1 = 0;
                        int num2 = 2;
                        result = num2 / num1;
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("Error: " + ex.Message);
                        Debug.WriteLine(ex.StackTrace); //ex.ToString() | Check debug message in Output window
                    }
                    finally
                    {
                        Console.WriteLine("Main method is ending");
                    }

                    Console.WriteLine($"The answer is: {result}");

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Throw example
                    try
                    {
                        double result = Divide(10, 0);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Throw custom exception example
                    Console.WriteLine("Please enter your age:");
                    string input = Console.ReadLine();
                    int age = GetUserAge(input);
                    Console.WriteLine($"Your age is: {age}");

                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Managing multiple types of exceptions example

                    Debug.WriteLine("Main method is running");

                    int result = 0;
                    try
                    {
                        Console.WriteLine("Please enter a number");
                        int num1 = int.Parse(Console.ReadLine());
                        //int num1 = 0;
                        int num2 = 2;
                        result = num2 / num1;
                    }
                    catch (DivideByZeroException ex)
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("Don't divide by zero! " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("Input format is incorrect! " + ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("The number is too big or too small! " + ex.Message);
                    }
                    catch (Exception ex)    //default exception handler
                    {
                        //Console.WriteLine(ex.ToString());
                        Console.WriteLine("Error: " + ex.Message);
                        Debug.WriteLine(ex.StackTrace); //ex.ToString() | Check debug message in Output window
                    }
                    finally
                    {
                        Console.WriteLine("Main method is ending");
                    }

                    Console.WriteLine($"The answer is: {result}");

                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // How exceptions work with the call stack
                    try
                    {
                        LevelOne();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error caught in Main: " + ex.Message);
                        Debug.WriteLine(ex.StackTrace);
                    }
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
                else if (userInput == "11")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "12")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "13")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "14")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "15")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }
                else if (userInput == "16")
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
    
        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("An error occurred in Level Two.");
        }

        public static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero."); // Will be caught in the calling method
            }
            return numerator / denominator;
        }

        public static int GetUserAge(string input)
        {
            int age;
            if(!int.TryParse(input, out age))            
            {
                throw new FormatException("Input is not a valid integer.");
            }
            if(age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
            }
            return age;
        }
    }
}
