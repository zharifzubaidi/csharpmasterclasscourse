using System.Diagnostics;

namespace ClassOopExample
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

                    Car carZharif = new Car("Saga","Proton"); // Create an instance/object of the Car class

                    Car carZaz = new Car("Myvi", "Perodua");

                    carZharif.UpdateCarModel("Persona");

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");



                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                }

                Console.WriteLine("Thank you! Please press enter to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }
    }
}
