
namespace EventsNDelegates
{
    // 1. Delegate Declaration:
    // Can declare inside or outside of the class
    // Recommended to declare outside of the class
    public delegate void Notify(string message);

    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Log to Console: {message}");
        }

        public void LogToFile(string message)
        {
            // Simulate logging to a file
            Console.WriteLine($"Log to File: {message}");
        }
    }

    public delegate int Comparison<T>(T x, T y);

    // Implementing generate delegate and generic
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)     // To check the first element
            {
                for (int j = i + 1; j < people.Length; j++)  // To check the next element
                {
                    if (comparison(people[i], people[j]) > 0)   // If more than 0, the first element is greater than the second and need to swap
                    {
                        // Swapping algorithm
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

    #region Example 1
    // Event example 1 - Basic notification event
    //public delegate void Notify(string message); // Already declared in previous example

    public class EventPublisher
    {
        // The "On" prefix makes it immediately clear that the method is
        // associated with an event. It signifies that the method is not just
        // a regular method but is specifically designed to raise or trigger
        // when a particular event occurs.
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            // Check if there are any subscribers before raising the event
            // Invoke the event if there are subscribers
            OnNotify?.Invoke(message);
        }

    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine($"Event received with message to subscriber class: {message}");
        }
    }
    #endregion

    #region Example 2
    // Event example 2 - Temperature change event
    // Using the Generic Delegate EventHandler<TEventArgs>
    public delegate void TemperatureChangedHandler(string message);

    // Event publisher class
    public class TemperatureMonitor
    {
        // Event based on delegate
        public event TemperatureChangedHandler OnTemperatureChanged;

        // Private field to hold temperature value
        private int _temperature;

        // Public property to set temperature
        public int Temperature { get { return _temperature; } 
            set
            {
                _temperature = value;
                if(_temperature > 30)
                {
                    // Raise event if temperature exceeds threshold
                    RaiseTemperatureChangedEvent($"Warning! Temperature has exceeded threshold! Current temperature: {_temperature}°C");
                }
            }
        }

        // Event invoker method
        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }

    // Event subscriber class
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine($"\nTemperature Alert: {message}");
        }
    }

    #endregion

    #region Example 3
    // Event example 3 - Stock price change event
    public delegate void StockPriceChangedHandler(string message);

    // Event publisher class
    public class Stock
    {
        // Event declaration based on delegate type
        public event StockPriceChangedHandler OnStockPriceChanged;

        // Private field to hold stock price and threshold
        private decimal _price;
        private decimal _threshold;

        // Public method
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if(_price > Threshold)
                {
                    RaiseStockPriceChangedEvent($"Stock price has exceeded the threshold! Current price: {_price}");
                }
            }
        }

        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        // Event invoker method
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Event subscriber class
    public class StockAlert
    {
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine($"\nStock Alert: {message}");
        }
    }
    #endregion

    #region Example 4
    // Event example 4 - Temperature change event using EventHandler and EventArgs
    // Using the Generic Delegate EventHandler<TEventArgs>
    // public delegate void TemperatureChangedHandler2(string message);

    // Custom EventArgs class (if needed)
    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property to hold temperature value
        public int Temperature { get; }

        // Constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    // Event publisher class
    public class TemperatureMonitor2
    {
        // Generic EventHandler with custom EventArgs
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // Event based on delegate
        //public event TemperatureChangedHandler2 OnTemperatureChanged;

        // Private field to hold temperature value
        private int _temperature;

        // Public property to set temperature
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    // Raise event if temperature exceeds threshold
                    _temperature = value;
                    OnRaiseTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        // Event invoker method
        protected virtual void OnRaiseTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Check if there are any subscribers before raising the event
            // To let every subscriber know who raised the event, we pass 'this' as the sender
            // This is the object invoke the event which is Event
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // Event subscriber class
    public class TemperatureAlert2
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"\nTemperature Alert: Temperature is {e.Temperature} sender is: {sender}");
        }
    }
    
    public class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"\nTemp Cooling Alert: Temperature is {e.Temperature} sender is: {sender}");
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

                    // Delegates define a method signature and any method assigned
                    // to that delegate must match the signature

                    // 2. Instantiation:
                    Notify notifyDelegate = ShowMessage;
                    //Notify notifyDelegate = new Notify(notifyDelegate);

                    // 3. Invocation:
                    notifyDelegate("Hello! This is a message from the delegate.");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Logger logger = new Logger();

                    LogHandler logHandler = logger.LogToConsole;                // Assign method to delegate

                    logHandler("This is a log message to the console.");        // Invoke delegate

                    logHandler = logger.LogToFile;                              // Reassign to another method

                    logHandler("This is a log message to the file.");           // Invoke delegate

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    int[] intArray = { 1, 2, 3, 4, 5 };
                    string[] stringArray = { "One", "Two", "Three", "Four", "Five" };

                    PrintArray(intArray);        // Call generic method with int array
                    PrintArray(stringArray);     // Call generic method with string array

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Implementing generic and delegate as a sorting algorithm
                    // Sort by age
                    Person[] people =
                    {
                        new Person{ Name = "Bob", Age = 30 },
                        new Person{ Name = "Alice", Age = 25 },
                        new Person{ Name = "Charlie", Age = 35 },
                        new Person{ Name = "Denis", Age = 18 }
                    };

                    PersonSorter sorter = new PersonSorter();                    
                    sorter.Sort(people, CompareByAge);
                    Console.WriteLine("\nSorted by Age:");
                    foreach (Person person in people)
                    {
                        Console.WriteLine($"{person.Name}, {person.Age}");
                    }

                    // Sort by name
                    Person[] people2 =
                    {
                        new Person{ Name = "Bob", Age = 30 },
                        new Person{ Name = "Alice", Age = 25 },
                        new Person{ Name = "Charlie", Age = 35 },
                        new Person{ Name = "Denis", Age = 18 }
                    };
                    sorter.Sort(people2, CompareByName);
                    Console.WriteLine("\nSorted by Name:");
                    foreach (Person person in people2)
                    {
                        Console.WriteLine($"{person.Name}, {person.Age}");
                    }
                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Multicast delegate example
                    // A delegate that holds references to more than one method
                    Logger logger = new Logger();
                    LogHandler logHandler = logger.LogToConsole;
                    logHandler += logger.LogToFile; // Add another method to the delegate

                    // Invoke multicast delegate where it will call both methods in console and file
                    logHandler("This is a log message to both console and file.");

                    // Check invocation list
                    foreach (LogHandler handler in logHandler.GetInvocationList())
                    {
                        try
                        {
                            handler("Invocation list message.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error invoking method: {ex.Message}");
                        }
                    }

                    // Check if a method is in the delegate before removing
                    if (IsMethodInDelegate(logHandler, logger.LogToFile))
                    {
                        // Remove one method from the delegate
                        logHandler -= logger.LogToFile;
                        Console.WriteLine("Removed LogToFile method from delegate.");
                    }
                    else
                    {
                        Console.WriteLine("Method not found in delegate.");
                    }

                    logHandler("This is a log message to console only.");

                    // Safe invocation of delegate for null check. Just in case no methods are assigned to the delegate
                    // We can use invocation list
                    if(logHandler != null)
                    {
                        InvokeSafely(logHandler, "This is a safe invocation of the delegate.");
                    }                   
                    
                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Events example
                    // A core concept build on top of delegates
                    EventPublisher publisher = new EventPublisher();
                    EventSubscriber subscriber = new EventSubscriber();

                    // Making subscribe class method subscribe to the event class
                    publisher.OnNotify += subscriber.OnEventRaised;

                    // Execute
                    publisher.RaiseEvent("Hello! This is an event notification.");
                }
                else if (userInput == "7")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Event example for temperature monitor
                    TemperatureMonitor monitor = new TemperatureMonitor();      // Event publisher
                    TemperatureAlert alert = new TemperatureAlert();            // Event subscriber

                    // Adding subscriber method to the event
                    monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

                    monitor.Temperature = 25; // No event triggered

                    Console.Write("Please enter the temperature value: ");
                    monitor.Temperature = int.Parse(Console.ReadLine() ?? "25"); // Default to 25 if no input. Event triggered if > 30

                }
                else if (userInput == "8")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Stock price change event example
                    Stock stock = new Stock();                  // Event publisher
                    StockAlert stockAlert = new StockAlert();   // Event subscriber

                    stock.OnStockPriceChanged += stockAlert.OnStockPriceChanged; // Subscribe to event

                    stock.Threshold = 100; // Set threshold

                    Console.Write("Please enter the stock price: ");
                    stock.Price = decimal.Parse(Console.ReadLine() ?? "0"); // Default to 0 if no input. Event triggered if > threshold

                }
                else if (userInput == "9")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Temperature change event using EventHandler and EventArgs
                    TemperatureMonitor2 monitor = new TemperatureMonitor2();      // Event publisher
                    TemperatureAlert2 alert = new TemperatureAlert2();            // Event subscriber
                    TempCoolingAlert coolingAlert = new TempCoolingAlert();       // Another event subscriber

                    // Adding subscriber method to the event
                    monitor.TemperatureChanged += alert.OnTemperatureChanged;
                    monitor.TemperatureChanged += coolingAlert.OnTemperatureChanged;

                    // Calling with same temperature to show no event triggered
                    monitor.Temperature = 20; // No event triggered
                    Console.Write("\nPlease enter the temperature value: ");
                    monitor.Temperature = int.Parse(Console.ReadLine() ?? "20"); // Default to 20 if no input. Event triggered if changed
                    
                    // Feels useful for logging
                }
                else
                {

                }

                Console.WriteLine("\nThank you! Please press enter to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        // Invoke safely method for delegates
        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        // Check if a method is in the delegate invocation list
        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }

        // Static method to implement Compare
        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }

        // Static method to show delegate usage
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Normal method
        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        // Generic method that takes in generic datatype example
        public static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
