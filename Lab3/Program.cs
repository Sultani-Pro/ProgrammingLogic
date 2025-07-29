namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop
        Console.WriteLine("Problem 1: Numbers 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            console.WriteLine(i);
        }

        // Problem 2: Even Numbers from 1 to 20
        Console.WriteLine("Problem 2: Even Numbers 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine9(i);
        }

        // Prblem 3: While Loop Countdown
        Console.WriteLine("prblem 3: Countdown from 5");
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        // Prb0lem 4: While Loop-Multiples of 10 from 10 to 1000
        Console.WriteLine ("problem 4: Mutiples of 10 (10-1000)");
        int multiple = 10;
        while (multiple <= 1000)
        {
            Console.WritLine(multiple);
            multiple += 10;
        }

        // Problem 5: Seasons of the Year
        Console.WriteLine("Problem 5: Seasons")
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // Problem 6: Days of the Week (1-7)
        Console.WriteLine("Problem 6: Days of the Week");
        string[] days = { "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WritLine("Day {dayNumber} is {days[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // Problem 7: Favorite Books and Authors
        Console.WriteLine("Problem 7: Favorite Books");
        string[] books = { "The Hobbit", "Dune", "1984" };
        string[] authors = { "J.R.R. Tolkien", "Frank Herbert", "George Orwell" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine("{books[i]} by {authors[i]}");
        }

        // Problem 8: Temperature Tracker
        Console.WriteLine("Problem 8: Temperature Tracker");
        int[] temperatures = { 72, 68, 75, 80, 65 };
        Array.Sort(temperatures);
        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Highest temperature: {temperatures[temperatures.Length - 1]}");
        Console.WriteLine("Lowest temerature: {temperatures[0]}");

        // Reverse Countdown
        Console.WriteLine("Problem 9: Reverse Countdown");
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        Console.WriteLine("Reversed countdown:");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }   
    }
}
