using System.Diagnostics;

namespace FuncMethod2
{
    internal class Program
    {
        // Class field / instance variable / global variable to this class
        static int myResult;

        static void Main(string[] args)
        {
            string? userInput = ""; // declare the string to expect a null value
            Console.Write("Please select your example: ");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                if (userInput == "1")
                {
                    // Example 1: Basic methods 
                    Console.WriteLine("*****************************");
                    Console.WriteLine("\tExample 1:");
                    Console.WriteLine("*****************************");

                    int num1 = 0;

                    Console.WriteLine("Enter a number, I'l add 10 to it!");
                    int.TryParse(Console.ReadLine(), out num1);

                    myResult = AddTwoValues(num1, 10);
                    Console.WriteLine("The result is " + myResult);

                    Console.WriteLine("Enter a number, I'l subtract 2 to it!");
                    int.TryParse(Console.ReadLine(), out num1);

                    myResult = SubtractTwoValues(num1, 2);
                    Console.WriteLine("The result is " + myResult);

                }
                else if (userInput == "2")
                {
                    // Example 2: Weather simulator
                    Console.WriteLine("*****************************");
                    Console.WriteLine("\tExample 2:");
                    Console.WriteLine("*****************************");

                    Console.WriteLine("Enter the number of days you want to simulate:");
                    int.TryParse(Console.ReadLine(), out int days);

                    int[] temperature = new int[days];
                    string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy", "Windy" };
                    string[] weatherConditions = new string[days];

                    Random random = new Random();
                    for (int i = 0; i < days; i++)
                    {
                        temperature[i] = random.Next(-10, 40);
                        weatherConditions[i] = conditions[random.Next(conditions.Length)];
                    }

                    Console.WriteLine("Weather Simulation Results:");
                    for (int i = 0; i < days; i++)
                    {
                        Console.WriteLine($"Day {i + 1}: {temperature[i]}°C, {weatherConditions[i]}");
                    }

                    //double averageTemperature = CalculateAverage(temperature);
                    // Method can be called directly in the string interpolation
                    Console.WriteLine($"The average temperature is: {CalculateAverage(temperature)}");
                    Console.WriteLine($"The maximum temperature is: {CalculateMaxValue(temperature)}");
                    Console.WriteLine($"The minimum temperature is: {CalculateMinValue(temperature)}");
                    //Console.WriteLine($"The max temperature using array.Max() is: {temperature.Max()}");
                    Console.WriteLine($"Most common conditions: {MostCommonCondition(weatherConditions)}");

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Recursive countdown starting from 5:");
                    CountDown(5);
                }
                     
                Console.WriteLine("Thank you! Please press enter to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        static void CountDown(int number)
        {
            // Base case: Stop when we reach 0
            if (number == 0)
            {
                Console.WriteLine("Blast off!");
                return;
            }

            Console.WriteLine(number);

            // Recursive call: Reduce the number and call the function again
            CountDown(number - 1);
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for(int i = 0; i < conditions.Length;i++)
            {
                int tempCount = 0;
                for(int j =0; j < conditions.Length;j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateMaxValue(int[] numbers)
        {
            // Check if the array is empty to avoid errors
            if (numbers.Length == 0)
                return 0.0; 

            double max = numbers[0];    // Initialize max with the first element
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static double CalculateMinValue(int[] numbers)
        {
            // Check if the array is empty to avoid errors
            if (numbers.Length == 0)
                return 0.0; 

            double min = numbers[0];    // Initialize min with the first element
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        static double CalculateAverage(int[] numbers)
        {
            // Check if the array is empty to avoid division by zero
            if (numbers.Length == 0)
                return 0.0;

            // Calculate the sum of the numbers in the array
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }

        static int AddTwoValues(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }

        static int SubtractTwoValues(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
        }
    }
}
