namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Lab 2
        // Part 1: Operator Practice
        Int a = 10, b = 5, c = 15;
        Console.WriteLine("a > b:" + (a > b));
        Console.WriteLine("a < c:" + (a < c));
        Console.WriteLine("a > b &&v a > c:" + (a > b && a > c));
        Console.WriteLine("a > b || a > c:" + (a > b || a > c));
        // Out put
        a > b: True
        a < c: True
        a > b &&v a > c: False
        a > b || a > c: True   
        // Part 2: Boolean Logic
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You are to go!");
        }
        // Part 3: Conditional Logic-Movie Ticket Pricing
        Console.WriteLine("Please enter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child teicket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else 
        {
            Console.WriteLine("Senior ticket: $6");
        }
        // Part 4: Switch Statement
        Console.WriteLine("Enter a number (1-7) for the day of the week:");
        int day = int.Parse(Console.Readline());
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Cosole.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
                
            case 6:
                Console.WritLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;


            
            
    }
}
