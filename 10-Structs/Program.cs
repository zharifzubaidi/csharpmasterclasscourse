
namespace StructExample
{
    #region Struct vs Class example
    public struct Point
    {
        // It is a common practice to make structs immutable
        // by declaring all fields as readonly and providing only
        // get accessors for properties

        // Property
        public double X { get; set; }
        public double Y { get; set; }

        // Field
        //public int X;
        //public int Y;

        public Point(double x, double y) 
        { 
            X = x;
            Y = y;
        }
        
        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    
    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    #endregion

    #region Enum example
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

    #endregion

    internal class Program
    {
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
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

                    // Struct example 1 using fields
                    /*          
                    Point p1 = new Point(40,25);
                    p1.Display();

                    Point p2;
                    p2.X = 10;
                    p2.Y = 10;
                    p2.Display();

                    // Struct is value type. Can overwrite the data
                    Point p3 = p1;
                    p3.X = 50;
                    p1.Display();
                    p3.Display();
                    */

                    // Struct example 2 using immutable properties
                    Point p1 = new Point(10, 20);
                    p1.Display();

                    Point p2 = new Point(20, 30);
                    p2.Display();

                    double distance = p1.DistanceTo(p2);
                    Console.WriteLine($"Distance between points: {distance:F3}");

                    // Struct is value type. Can overwrite the data
                    Point p3 = p1;
                    p1.Display();
                    p3.Display();

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Value type (Struct) vs Reference type (Class)
                    Point p1 = new Point(10,20);
                    p1.Display();

                    Point p2 = p1;
                    p2.Display();
                    p2.X = 25;
                    Console.WriteLine("After changing p2.X to 25");
                    p1.Display();
                    p2.Display();

                    Console.WriteLine("Now come the class objects");
                    PointClass pC1 = new PointClass(1, 2);
                    PointClass pC2 = pC1;
                    pC1.Display();
                    pC2.Display();

                    pC2.X = 3;  // Changes p1.X as well since p1 and p2 reference the same class
                    Console.WriteLine("After changing pC2.X to 3");
                    pC1.Display();
                    pC2.Display();

                    // Same because pointing to the same memory due to class being reference type
                    bool isEqual = pC1.Equals( pC2 );
                    Console.WriteLine("is it equal? " + isEqual );
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    // Enums example
                    // A set of immutable constant

                    Day fr = Day.Fri;
                    Day su = Day.Sun;

                    Day a = Day.Fri;

                    Console.WriteLine(fr == a);

                    Console.WriteLine(Day.Mon);

                    Console.WriteLine((int)Day.Mon);

                    Console.WriteLine((int)Month.Feb);

                }
                else if (userInput == "4")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");

                    //Date time is an important struct
                    DateTime dateTime = new DateTime(1996, 12, 18);

                    Console.WriteLine("My birthday is {0}", dateTime);

                    // Write today on screen
                    Console.WriteLine(DateTime.Today);
                    // Write current time on screen
                    Console.WriteLine(DateTime.Now);
                    DateTime tomorrow = GetTomorrow();
                    // Write tomorrow time
                    Console.WriteLine("Tomorrow will be the {0}", tomorrow);
                    // Write the day of the week
                    Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
                    // Write the first day of the year
                    Console.WriteLine(GetFirstDayOfYear(2023));

                    int days = DateTime.DaysInMonth(2021, 2);
                    Console.WriteLine("Days in Feb 2021: {0}", days);
                    days = DateTime.DaysInMonth(2022, 2);
                    Console.WriteLine("Days in Feb 2022: {0}", days);
                    days = DateTime.DaysInMonth(2023, 2);
                    Console.WriteLine("Days in Feb 2023: {0}", days);

                    DateTime now = DateTime.Now;
                    Console.WriteLine("Minutes: {0}", now.Minute);

                    // Display time in this structure x o'clock, y minutes and z seconds
                    Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

                    Console.WriteLine("Write a date in this format: yyyy-mm-dd");
                    string input = Console.ReadLine();
                    if(DateTime.TryParse(input, out dateTime))
                    {
                        Console.WriteLine(dateTime);
                        TimeSpan daysPassed = now.Subtract(dateTime);
                        Console.WriteLine("Days passed since: {0}", daysPassed.Days);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                else if (userInput == "5")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    
                    // Math class example
                    Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
                    Console.WriteLine("Floor: " + Math.Floor(15.3));

                    int num1 = 13;
                    int num2 = 9;
                    Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
                    Console.WriteLine("Higher of num1 {0} and num2 {1} os {2}", num1, num2, Math.Max(num1, num2));

                    Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3,5));
                    Console.WriteLine("PI is: {0}", Math.PI);
                    Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));

                    Console.WriteLine("Always positive is {0}", Math.Abs(-25));

                    Console.WriteLine("cos of 1 is {0}", Math.Cos(1));
                }
                else if (userInput == "6")
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"\tExample {userInput}:");
                    Console.WriteLine("*****************************");
                    // Garbage Collection


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
