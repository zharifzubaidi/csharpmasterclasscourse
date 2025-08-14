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

                    Car carZharif = new Car("Saga","Proton", false); // Create an instance/object of the Car class

                    Car carZaz = new Car("Myvi", "Perodua", false);

                    carZharif.UpdateCarModel("Persona");

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Car carLiz = new Car("Yaris", "Toyota", false);

                    Console.WriteLine("Please enter the brand name: ");
                    // Set brand property using the setter
                    carLiz.Brand = Console.ReadLine();
                    // Get brand property using the getter
                    Console.WriteLine("You have entered: " + carLiz.Brand); 

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Car carAang = new Car("Yaris", "Toyota", false);
                    Car carToph = new Car("i7", "BMW", true); 

                    Console.WriteLine("Brand is " + carAang.Brand);
                    Console.WriteLine("Brand is " + carToph.Brand);

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Customer larry = new Customer(); // Using the default constructor
                    Customer earl = new Customer("Earl");
                    Customer frankTheTank = new Customer("Frank The Tank", "123 Main St", "555-1234");

                    Console.WriteLine("The customer's name is: " + larry.Name);
                    Console.WriteLine("The customer's name is: " + earl.Name);
                    Console.WriteLine("The customer's address is: " + frankTheTank.Address);


                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Car myAudi = new Car("A3", "Audi", false);
                    myAudi.Drive();  // Accessing class method
                    Car myBmw = new Car("X5", "BMW", true);
                    myBmw.Drive();  // Accessing class method

                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Static method example
                    Customer.PrintWelcomeMessage(); // Calling the static method without creating an instance of the class

                    Customer earl = new Customer("Earl");
                    Customer frankTheTank = new Customer("Frank The Tank", "123 Main St", "555-1234");
                    Customer larry = new Customer();
                    Customer ilaRia = new Customer();
                    ilaRia.SetDetails("Ila Ria", "789 Oak St");

                    // Using the SetDetails method to set properties
                    larry.SetDetails("Larry", "456 Elm St", "555-5678");

                    Console.WriteLine("The customer's name is: " + larry.Name);
                    Console.WriteLine("The customer's address is: " + larry.Address);
                    Console.WriteLine("The customer's contact number is: " + larry.ContactNumber);
                    Console.WriteLine($"The customer's name is: {ilaRia.Name} with address of {ilaRia.Address} and phone number of {ilaRia.ContactNumber}");

                }
                else if (userInput == "7")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                                        
                    // Normal case
                    Console.WriteLine("Please enter your number: " + AddNum(15, 25));

                    // Named parameter - suitable for method with many parameter
                    Console.WriteLine(AddNum(firstNum: 15, secondNum: 25));
                    Console.WriteLine(AddNum(firstNum: 15, 25));


                }
                else if (userInput == "8")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Console.WriteLine("Please enter the height of the rectangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle();
                    rectangle.Height = height;
                    rectangle.Width = width;
                    
                    Console.WriteLine($"The area of this rectangle is {rectangle.Area}"); // Calling computed property

                }
                else if (userInput == "9")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Car car = new Car();
                    Car car2 = new Car("Model S", "Tesla", true);
                    Car car3 = new Car();

                    Console.WriteLine("Number of cars created: " + Car.NumberOfCars); // Accessing static field 

                }
                else if (userInput == "10")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Customer customer1 = new Customer();
                    Customer customer2 = new Customer("Jane Doe", "123 Main St", "555-1234");
                    Customer customer3 = new Customer();

                    customer1.GetDetails(); // Calling instance method to get details
                    customer2.GetDetails();
                    customer3.GetDetails();

                    Console.WriteLine("Customer 3 ID: ");
                    Console.WriteLine(customer3.Id);

                    customer3.Password = "securepassword"; // Setting password using write-only property
                    Console.WriteLine("Password for Customer 3 has been set successfully.");
                    // Note: We cannot read the password as it is a write-only property


                }
                else if (userInput == "11")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Rectangle rectShape1 = new Rectangle("Red");
                    Rectangle rectShape2 = new Rectangle("Blue");

                    rectShape1.Width = 5.0;
                    rectShape1.Height = 10.0;

                    rectShape2.Width = 3.0;
                    rectShape2.Height = 6.0;

                    Console.WriteLine("***************************");
                    Console.WriteLine($"\tRectangle 1");
                    Console.WriteLine("***************************");
                    rectShape1.DisplayInfo();
                    Console.WriteLine("***************************");
                    Console.WriteLine($"\tRectangle 2");
                    Console.WriteLine("***************************");
                    rectShape2.DisplayInfo();

                }
                else if (userInput == "12")
                {
                    // Quiz App
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Question[] questions = new Question[]
                    { 
                        new Question(
                            "What is the capital of Germany?",
                            new string[] {"Paris","Berlin", "London", "Madrid"},
                            1
                        )                    
                    };

                    Quiz quiz = new Quiz(questions);

                    quiz.DisplayQuestion(questions[0]);

                    Console.ReadLine();

                    //quiz.StartQuiz();

                }               
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
                }

                    Console.WriteLine("Thank you! Please press enter to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        // Methods
        // Static methods can be called without creating an instance of the class
        static int AddNum(int firstNum, int secondNum) 
        {
            return firstNum + secondNum;
        }      
    }
}
