
namespace PolyInterface
{
    // Interface aka the template/blueprint
    #region Payment Polymorphism Example
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");        
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }

    // Class that implement interface commonly known as Service
    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
    #endregion

    // Interface becomes a blueprint / template for classes
    #region Interface Example
    public interface IAnimal
    {
        void MakeSound();
        string Eat(string food);
    }
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public string Eat(string food)
        {
            return $"The dog is eating {food}.";
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public string Eat(string food)
        {
            return $"The cat is eating {food}.";
        }
    }
    #endregion

    // Polymorphism example with normal class inheritance
    #region Polymorphism Example
    public class Species
    {
        public virtual void MakeAnimalSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    public class Lion : Species
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Roar!");
        }
    }  

    public class Snake : Species
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Hiss!");
        }
    }

    #endregion

    // Logger example
    #region Logger Example
    // Logger interface
    public interface ILogger
    {
        void Log(string message);
    }

    // File logger type implementation
    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Users\zharif.aizuddin\01Software_Dev\csharpmasterclasscourse\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Will create text if not exist and append if exist
            File.AppendAllText(filePath, message + "\n");
        }
    }

    // Database logger implementation
    public class DatabaseLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database. {message}");
        }
    }


    // Application class that use the database logger
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started" + "\n");
            _logger.Log("Work completed!" + "\n");
        }
    }

    #endregion

    // Dependency injection types example
    #region Dependency Injection Example

    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public class UserService
    {
        private readonly IEmailService _emailService;

        // Injecting dependency via constructor
        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterUser(string name)
        {
            Console.WriteLine($"User {name} registered successfully.");
            _emailService.SendEmail($"Welcome {name}!");
        }
    }
        
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    // Constructor dependency injection example
    /*
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        // Simple dependency example        
        //public Builder()
        //{
        //    // Builder depend on the hammer and saw
        //    _hammer = new Hammer(); // Builder is responsible for creating its dependency
        //    _saw = new Saw();
        //}
        

        // Constructor dependency injection example
        public Builder(Hammer hammer, Saw saw) // Inject dependency via constructor
        {
            // Builder depend on the hammer and saw
            _hammer = hammer; // Builder is responsible for creating its dependency
            _saw = saw;
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House is built");
        }
    }
    */
    
    // Setter dependency injection example
    /*
    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw {get; set;}

        // Setter DI here. No constructor. Just use the default constructor.

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House is built");
        }
    }
    */

    // Interface dependency injection example
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Builder: IToolUser // Inject dependency via interface
    {
        private Hammer _hammer;
        private Saw _saw;

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House is built");
        }

        // Inject dependency via interface implementation
        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }

    #endregion

    // Multiple inheritance example using interface
    #region Multiple Inheritance Example
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Print document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }

    #endregion

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

                    Dog dog = new Dog();
                    dog.MakeSound();
                    Console.WriteLine(dog.Eat("bone"));
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Cat cat = new Cat();
                    cat.MakeSound();
                    Console.WriteLine(cat.Eat("fish"));
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // 2nd Part of Polymorphism Example
                    // you store a Snake instance in a variable typed as its base class Species.
                    Species mySomething = new Snake();
                    mySomething.MakeAnimalSound();

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Declares a variable that in compile time is IPaymentProcessor but in runtime it is CreditCardProcessor
                    // An instance that implement the contract of IPaymentProcessor via CreditCardProcessor
                    // Loose coupling reason. Declared as interface but you can swap the implementation (creditCardProcessor) anytime
                    // Declaring the variable as the interface type makes the code depend on the abstraction, not the concrete class,
                    // so implementations can be swapped without changing callers.
                    IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
                    
                    // Create a payment service and injecting dependency of creditCardProcessor into the service
                    PaymentService paymentService = new PaymentService(creditCardProcessor);

                    // Ask the service to use the method inside the dependency
                    paymentService.ProcessOrderPayment(100.00m);

                    // Reuse the code with easy swap of dependency on processor (creditCard - PayPal)
                    IPaymentProcessor paypalProcessor = new PayPalProcessor();
                    paymentService = new PaymentService(paypalProcessor);
                    paymentService.ProcessOrderPayment(100.00m);

                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    string directoryPath = @"C:\Users\zharif.aizuddin\01Software_Dev\csharpmasterclasscourse\Logs";
                    string filePath = Path.Combine(directoryPath, "log.txt");
                    string message = "This is a log entry";

                    if(!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Will create text if not exist and append if exist
                    File.AppendAllText(filePath, message + "\n");

                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Decoupling code and enhance testability

                    // Load fileLogger implementation. Write at file.txt
                    ILogger fileLogger = new FileLogger();                    
                    Application app = new Application(fileLogger);  // decoupling example in application class
                    app.DoWork();

                    // Load databaseLogger implementation. Write at CLI.
                    ILogger dbLogger = new DatabaseLogger();        
                    app = new Application(dbLogger);                // decoupling example in application class
                    app.DoWork();

                }
                else if (userInput == "7")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Dependency injection example 1
                    IEmailService emailService = new EmailService();
                    UserService userService = new UserService(emailService);
                    userService.RegisterUser("John Doe");

                }
                else if (userInput == "8")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Dependency injection example 2
                    // 01 Constructor DI
                    /*
                    Hammer hammer = new Hammer();
                    Saw saw = new Saw();
                    Builder builder = new Builder(hammer, saw);
                    */

                    // 02 Setter DI
                    /*
                    Hammer hammer = new Hammer();
                    Saw saw = new Saw();

                    Builder builder = new Builder();

                    builder.Hammer = hammer;    // Inject dependencies via Setters
                    builder.Saw = saw;          // Inject dependencies via Setters
                    */

                    // 03 Interface DI
                    Hammer hammer = new Hammer();
                    Saw saw = new Saw();

                    Builder builder = new Builder();

                    builder.SetHammer(hammer);
                    builder.SetSaw(saw);

                    // Call action
                    builder.BuildHouse();

                }
                else if (userInput == "9")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    
                    // Multiple inheritance. Inherit multiple interface at once
                    MultiFunctionPrinter printer = new MultiFunctionPrinter();
                    printer.Print();
                    printer.Scan();

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
    }
}
