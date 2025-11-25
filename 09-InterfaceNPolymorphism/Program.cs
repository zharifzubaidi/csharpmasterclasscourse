
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
