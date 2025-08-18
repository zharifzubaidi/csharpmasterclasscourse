using System.Collections;
using System.Diagnostics;
using System.Drawing;

namespace PolyInterface
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

                    // Basic List
                    // Declaring a list and initialise it
                    List<string> colors = new List<string>();

                    // Add new item to the list
                    colors.Add("Red");
                    colors.Add("Blue");
                    colors.Add("Green");
                    colors.Add("Red");
                    Console.WriteLine("After add items: ");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    Console.WriteLine("-----------------------------");

                    // Remove item from list. The first red found in list only will be deleted.
                    bool isDeletingSuccessful = colors.Remove("Red");
                    if (isDeletingSuccessful)
                    {
                        Console.WriteLine("Remove was successful");
                        Console.WriteLine("After remove item: ");
                        foreach (string color in colors)
                        {
                            Console.WriteLine($"Current color: {color}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remove was not successful");
                    }

                    Console.WriteLine("-----------------------------");

                    // Remove all read until unable to find red anymore
                    colors.Add("Blue");
                    Console.WriteLine("Before deleting");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    isDeletingSuccessful = colors.Remove("Blue");
                    while (isDeletingSuccessful)
                    {
                        isDeletingSuccessful = colors.Remove("Blue");
                    }

                    Console.WriteLine("Remove was successful");
                    Console.WriteLine("After remove item: ");
                    foreach (string color in colors)
                    {
                        Console.WriteLine($"Current color: {color}");
                    }

                    Console.WriteLine("-----------------------------");

                    // Initialisation of list with items directly
                    List<string> shapes =
                        [
                            "rectangle",
                            "square",
                            "circle",
                            "oval"
                        ];

                    Console.WriteLine("List of shapes: ");
                    foreach (string shape in shapes)
                    {
                        Console.WriteLine($"Current shape is {shape}");
                    }


                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Sorting List
                    List<int> listNumbers = new List<int> { 62, 12, 154, 78, 92, 7, 38 };

                    Console.Write("Unsorted numbers: ");
                    foreach (int number in listNumbers)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                    listNumbers.Sort();

                    Console.Write("Sorted numbers: ");
                    foreach (int number in listNumbers)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Findall method
                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // This will return a list of numbers that are 10 and higher
                    List<int> higherEqualTen = numbers.FindAll(x => x >= 10); // this is using lambda expression (=>) right side is the return
                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach(int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                    int numberSquare = Squaring(40);
                    Console.WriteLine($"The number square method result made using lambda expression: {numberSquare}");
                    
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Predicate
                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // Storing lambda expression inside a predicate and using in FindAll method
                    Predicate<int> isGreaterThanTen = x => x >= 10;

                    //List<int> higherEqualTen = numbers.FindAll(x => x >= 10);

                    List<int> higherEqualTen = numbers.FindAll(isGreaterThanTen);

                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach (int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");

                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    /*
                     * In C#, a delegate is like a pointer or a reference to a method
                     * It allows you to pass methods as arguments to the other methods,
                     * store them in variables, and call them later.
                     * This is useful when you want your code to be flexible and able
                     * to handle different behaviors that aren't predetermined.
                     * We can assigned a full method into a predicate.
                     */

                    List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 53, 72 };

                    Console.Write("Raw list: ");
                    foreach (int number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // Any method of List - Determine whether ANY element of a sequence exist or satisfies a condition
                    var hasLargeNumber = numbers.Any(x => x > 20);

                    if(hasLargeNumber )
                    {
                        Console.WriteLine("There is large numbers in the list");
                    }
                    else
                    {
                        Console.WriteLine("No large numbers in the list");
                    }

                    // Predicate
                    Predicate<int> isGreaterThanTen = IsGreaterThanTen; // A method name directly assigned to predicate without ()

                    List<int> higherEqualTen = numbers.FindAll(isGreaterThanTen);

                    Console.WriteLine("");
                    Console.Write("All numbers that is 10 and higher: ");
                    foreach (int number in higherEqualTen)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine("");


                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Create object based on a class
                    //List<Product> products = new List<Product>();
                    List<Product> products = new List<Product> 
                    {
                        new Product { Name = "Pineapple", Price = 4.32},
                        new Product { Name = "Banana", Price = 1.00},
                        new Product { Name = "Apple", Price = 1.30},
                        new Product { Name = "Grape", Price = 0.53}
                    };

                    products.Add(new Product { Name = "Berries", Price = 2.99 });

                    Console.WriteLine("Available Products: ");
                    foreach(Product product in products)
                    {
                        Console.WriteLine($"Product name: {product.Name} for {product.Price:C2}");
                    }

                }
                else if (userInput == "7")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Using list from LINQ
                    List<Product> products = new List<Product>
                    {
                        new Product { Name = "Pineapple", Price = 4.32},
                        new Product { Name = "Banana", Price = 1.00},
                        new Product { Name = "Apple", Price = 1.10},
                        new Product { Name = "Grape", Price = 0.53}
                    };

                    products.Add(new Product { Name = "Berries", Price = 2.99 });

                    Console.WriteLine("Available Products: ");
                    foreach (Product product in products)
                    {
                        Console.WriteLine($"Product name: {product.Name} for {product.Price:C2}");
                    }

                    /* Filter List based on predicate using lambda expression
                     P is the products' list item. Where() will return an IEnumerable
                     Collections is a category of data structure which are
                     List, Array, IEnumerable, Dictionaries, Sets, Queues(FIFO), Stacks (LIFO)
                    */
                    List<Product> cheapProducts = products.Where(p => p.Price < 1.20).ToList();
                    Console.WriteLine("Available products for less than $1.20: ");
                    foreach (Product product in cheapProducts)
                    {
                        Console.WriteLine($"Product name: {product.Name} for {product.Price}");
                    }



                }
                else if (userInput == "8")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Legacy List type: ArrayLists
                    // Undefined amount of objects
                    ArrayList myArrayList = new ArrayList();
                    // Defined amount of objects
                    ArrayList myArrayList2 = new ArrayList(100);

                    myArrayList.Add(25);
                    myArrayList.Add("Hello");
                    myArrayList.Add(13.37);
                    myArrayList.Add(25.35);
                    myArrayList.Add(128);
                    myArrayList.Add(13);
                    myArrayList.Add("World!");

                    double sum = 0;
                    string collectedString = "";

                    Console.WriteLine("The original obj in this array list: ");
                    foreach (object obj in myArrayList)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine("");

                    // Delete element with specific value from the arraylist
                    myArrayList.Remove(13.37);

                    // Delete element with specific position/index
                    myArrayList.RemoveAt(0);

                    Console.WriteLine("The manipulated obj in this array list: ");
                    foreach (object obj in myArrayList)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine("");

                    Console.WriteLine($"The obj count in array list: {myArrayList.Count}");
                    
                    // Object is the highest class in C# hence can work with any type in the list
                    foreach (object obj in myArrayList)
                    {
                        if (obj is int)
                        {
                            sum += Convert.ToDouble(obj);
                        }
                        else if (obj is double)
                        {
                            sum += (double)obj;
                        }
                        else if(obj is string)
                        {
                            collectedString += obj + " ";
                        }
                    }

                    Console.WriteLine($"The sum of the digits in the array list: {sum}");
                    Console.WriteLine($"The string in the array list: {collectedString}");

                }
                else if (userInput == "9")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Legacy List type: Hashtables
                    // Similar to dictionaries but can handle multiple types
                    // Key - Value
                    // UniqueID - Data

                    Hashtable studentsTable = new Hashtable();

                    Student stud1 = new Student(1, "Maria", 98);
                    Student stud2 = new Student(2, "John", 85);
                    Student stud3 = new Student(3, "Alice", 92);
                    Student stud4 = new Student(4, "Bob", 75);

                    // Add data to hashtable
                    studentsTable.Add(stud1.Id, stud1);
                    studentsTable.Add(stud2.Id, stud2);
                    studentsTable.Add(stud3.Id, stud3);
                    studentsTable.Add(stud4.Id, stud4);

                    // Fetch data from hashtable
                    Student storedStudent1 = (Student)studentsTable[1];
                    Student storedStudent2 = (Student)studentsTable[2];
                    Student storedStudent3 = (Student)studentsTable[stud3.Id];
                    Student storedStudent4 = (Student)studentsTable[stud4.Id];

                    Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
                    Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent2.Id, storedStudent2.Name, storedStudent2.GPA);
                    Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent3.Id, storedStudent3.Name, storedStudent3.GPA);
                    Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent4.Id, storedStudent4.Name, storedStudent4.GPA);

                    // Fetch all data in hashtable
                    // Struct call dictionary entry. A new dictionary entry is created for each key-value pair
                    // A hashtable is a collection of dictionary entries
                    // Start from the last item and go to the first item
                    // This is by design
                    foreach (DictionaryEntry entry in studentsTable)
                    {
                        Student student = (Student)entry.Value; // convert the object to Student type first. or model
                        Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, GPA: {student.GPA}");
                    }

                    foreach (Student student in studentsTable.Values)
                    {
                        Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, GPA: {student.GPA}");
                    }

                }
                else if (userInput == "10")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Nullable types
                    int? age = null;
                    int myAge = 24;

                    if(age.HasValue)
                    {
                        Console.WriteLine($"Age is: {age.Value}");
                        int sum = age.Value + myAge; // Use .Value to get the actual value of nullable type
                    }
                    else
                    {
                        Console.WriteLine("Age is not set.");
                    }

                }
                else if (userInput == "11")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Dictionaries Part 1
                    // Allow us to use collections of key-value pairs
                    // Key cannot be duplicate and null
                    // Declaring and initialising a dictionary
                    Dictionary<int, string> employees = new Dictionary<int, string>();

                    // Add items to dictionary
                    employees.Add(101, "John Doe");
                    employees.Add(102, "Bob Smith");

                    // Accessing items like array style via key instead of index
                    string name = employees[101];
                    Console.WriteLine(name);

                }
                else if (userInput == "12")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Dictionaries Part 2
                    Dictionary<int, string> employees = new Dictionary<int, string>();

                    // Add items to dictionary
                    employees.Add(101, "John Doe");
                    employees.Add(102, "Bob Smith");
                    employees.Add(103, "Rob Smith");
                    employees.Add(104, "Bob Doe");
                    employees.Add(105, "Dane Lars");
                    employees.Add(106, "Diane Roe");

                    // Accessing items like array style via key instead of index
                    string name = employees[101];
                    Console.WriteLine(name);

                    // Update items in a dictionary
                    employees[102] = "Jane Smith";

                    employees.Remove(101);

                    // Accessing all items in dictionary
                    foreach (KeyValuePair<int, string> employee in employees)
                    {
                        Console.WriteLine($"ID: {employee.Key} Name: {employee.Value}");
                    }

                }
                else if (userInput == "13")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Gracefully add and update dictionaries to handle duplicates
                    Dictionary<int, string> employees = new Dictionary<int, string>();

                    // Add items to dictionary
                    employees.Add(101, "John Doe");
                    employees.Add(102, "Bob Smith");
                    employees.Add(103, "Flob Smith");
                    employees.Add(104, "Bob Doe");
                    employees.Add(105, "Dane Lars");
                    employees.Add(106, "Diane Roe");

                    // Accessing items like array style via key instead of index
                    string name = employees[101];
                    Console.WriteLine(name);

                    // Update items in a dictionary
                    employees[102] = "Jane Smith";

                    employees.Remove(101);

                    Console.WriteLine("The original dictionary: ");
                    // Accessing all items in dictionary
                    foreach (KeyValuePair<int, string> employee in employees)
                    {
                        Console.WriteLine($"ID: {employee.Key} Name: {employee.Value}");
                    }

                    //employees.Add(104, "Mike Ross"); // this will run into an error due to duplicate key in dictionaries

                    // Check if a specific key exist or not
                    // Example 1: Hard code example
                    if (!employees.ContainsKey(104))
                    {
                        employees.Add(104, "Mike Ross");
                    }
                    else
                    {
                        employees.Add(107, "Mike Ross");
                    }

                    // Example 2: Use while checking
                    int counter = 101;
                    while (employees.ContainsKey(counter))
                    {
                        counter++;
                    }
                    // Add new employee using the first unused key
                    employees.Add(counter, "Harvey Specter");

                    // Example 3: Use Dictionary TryAdd()
                    bool added = employees.TryAdd(101, "Jack Gotham");
                    if (!added)
                    {
                        Console.WriteLine("Employee ID is already exists. Try with a new ID");
                    }

                    // Print the dictionary in a sorted way using LINQ
                    Console.WriteLine("The manipulated and sorted dictionary using LINQ: ");
                    foreach (KeyValuePair<int, string> employee in employees.OrderBy(e => e.Key))
                    {
                        Console.WriteLine($"ID: {employee.Key} Name: {employee.Value}");
                    }


                }
                else if (userInput == "14")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Add complex object such as a class in the dictionary
                    Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

                    employees.Add(1, new Employee("John Doe", 35, 100000));
                    employees.Add(2, new Employee("Jane Smith", 28, 85000));
                    employees.Add(3, new Employee("Bob Johnson", 45, 120000));
                    employees.Add(4, new Employee("Alice Brown", 30, 95000));
                    employees.Add(5, new Employee("Charlie White", 40, 110000));

                    foreach (var item in employees)
                    {
                        Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name} Age: {item.Value.Age} Yearly Salary: {item.Value.Salary}");
                    }


                }
                else if (userInput == "15")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Declare a dictionary with a list
                    Dictionary<string, List<int>> numberList = new Dictionary<string, List<int>>();
                    numberList.Add("default", new List<int> { 1, 2, 3 });

                    foreach (int num in numberList["default"])
                    {
                        Console.Write($"{num} ");
                    }
                }
                else if (userInput == "16")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Another way dictionary can be declare with string as a key
                    var codes = new Dictionary<string, string> 
                    {
                        ["NY"] ="New York",
                        ["CA"] = "California",
                        ["TX"] = "Texas",
                        ["FL"] = "Florida",
                        ["IL"] = "Illinois"
                    };

                    foreach (var code in codes)
                    {
                        Console.WriteLine($"Code: {code.Key}, State: {code.Value}");
                    }

                    // Get a value that is may or may not exist
                    if (codes.TryGetValue("NY", out string? state))
                    {
                        Console.WriteLine($"The state for NY is {state}");
                    }
                    else
                    {
                        Console.WriteLine("State not found for the given code");
                    }         
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

        /// <summary>
        /// Lambda expression consists of 2 parts
        /// 1. Parameters
        /// 2. Expression or statement block
        /// Parameters are written on the left side of =>
        /// (this symbol is read as "goes to" or "becomes").
        /// The expression or action to perform is on the right side
        /// This reads as:
        /// Take an input x and turn it into x multiplied by x
        /// x => x * x;
        /// </summary>
        /// <param name="num1">The number to square</param>
        /// <returns>The square of the input number</returns>
        public static int Squaring(int num1) => num1 * num1;

        // Normal method declaration
        //public static int Squaring(int num)
        //{
        //    return num * num;
        //}

        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
    }
}
