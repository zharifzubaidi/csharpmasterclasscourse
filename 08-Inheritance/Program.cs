
namespace InheritanceExample
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

                    // Basic Inheritance Example

                    Dog myDog = new Dog();

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Access Modifiers Example
                    BaseClass baseObj = new BaseClass();
                    baseObj.ShowFields();

                    DerivedClass deriveObj = new DerivedClass();
                    deriveObj.ShowFields();

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Override keyword example

                    Dog myDog = new Dog();
                    myDog.MakeSound();

                    Cat myCat = new Cat();
                    myCat.MakeSound();

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Using base keyword in derived class
                    Dog myDog = new Dog();
                    myDog.MakeSound();


                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    //Person person = new Person("Alice", 30);
                    Employee employee = new Employee("Bob", 40, "Manager", "E123");

                    //person.DisplayPersonInfo();
                    employee.DisplayEmployeeInfo();

                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    Manager managerCharlies = new Manager("Charlie", 45, "Sales Manager", "E456", "Sales", 10);
                    managerCharlies.DisplayManagerInfo();
                    managerCharlies.BecomeOlder(5);
                    managerCharlies.DisplayManagerInfo();
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

    // Constructor inheritance
    public class Person
    {
        // Properties
        public string Name { get; private set; } // only settable in the constructor
        public int Age { get; private set; }
        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person (base class) constructor called.");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>
        /// Adding age to the person's current age
        /// </summary>
        /// <param name="years">Hold the amount of age the object should age
        /// </param>
        /// <returns> The new age of the person
        /// </returns>
        public int BecomeOlder(int years)
        {
            Age += years;
            return Age;
        }
    }
      
    public class Employee : Person
    {
        // Property
        public string EmployeeID { get; private set; }
        public string JobTitle { get; private set; }
        // Constructor
        // Call the base class constructor to pass derived class parameters
        public Employee(string name, int age, string jobTitle, string employeeID) : base(name, age)        
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (employee class) constructor called.");
        }
        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }

    // Another derived class from Employee. Multi layer inheritance example
    public class Manager: Employee
    {
        public string Department { get; private set; }
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobTitle, string employeeID, string department, int teamSize)
            : base(name, age, jobTitle, employeeID)
        {
            Department = department;
            TeamSize = teamSize;
            Console.WriteLine("Manager (derived class) constructor called.");
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Department: {Department}, Team Size: {TeamSize}");
        }
    }

    // Base / parent / super class
    // The class that is being inherited from
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
        // Method override example
        // Virtual is required to allow overriding in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making a generic sound.");
        }
    }

    // Derived / child / sub class
    // The class that inherits from the base class

    // Single level inheritance example
    class Dog : Animal
    {
        // Override is needed to override the base class method
        public override void MakeSound()
        {
            base.MakeSound();                           // Call the base class method
            Console.WriteLine("The dog is barking.");
        }
    }

    // Hierarchical inheritance example. Multiple class inherit from the same base class
    class Cat : Animal
    {
        // Override is needed to override the base class method
        public override void MakeSound()
        {
            Console.WriteLine("The cat is meowing.");
        }
    }

    // Multi-level inheritance example
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("The collie is going nuts!");
        }
    }

    // Access modifiers example
    class BaseClass
    {
        // access modifiers
        public int publicField;
        protected int protectedField;
        private int privateField;   // Only accessible in this class

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " + 
                $"Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;    // Accessible in derived class. Declared in base class
            protectedField = 2; // Accessible in derived class. Declared in base class
            // privateField = 3; // Not accessible
        }
    }
}
