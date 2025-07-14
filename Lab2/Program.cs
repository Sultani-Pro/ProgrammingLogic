namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Lab 2
        // Part 1: Operator Practice
        Int a = 10, b = 5, c = 15;
        Console.Writeline("a > b:" + (a > b));
        Console.Writeline("a < c:" + (a < c));
        Console.WriteLine("a > b &&v a > c:" + (a > b && a > c));
        Console.Writeline("a > b || a > c:" + (a > b || a > c));
        // Part 2: Boolean Logic
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining && !haveUmbrella)
        {
            Console.Writeline("Take an umbrella!");
        }
        else
        {
            Console.Writeline("You are to go!");
        }
        // Part 3: Conditional Logic-Movie Ticket Pricing
        Console.Writeline("Please enter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age < 5)
        {
            Console.Writeline("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.Writeline("Child teicket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else 
        {
            Console.Writeline("Senior ticket: $6");
        }
        // Part 4: Switch Statement
        Console.Writeline("Enter a number (1-7) for the day of the week:");
        int day = int.Parse(Console.Readline());
        switch (dayNumber)
        {
            case 1:
                ConsoleWritelin("Monday");
                break;
            case 2:
                CosoleWritelin("Tuesday");
                break;
            case 3:
                ConsoleWritelin("Wednesday");
                break;
            case 4:
                ConsoleWriteline("Thursday");
                break;
            case 5:
                ConsoleWritelin("Friday");
                break;
                
            case 6:
                ConsoleWritlin("Saturday");
                break;
            case 7:
                ConsoleWritelin("Sunday");
                break;
            default:
                Console.Writelin("Invalid day!");
                break;


            
            
    }
}
