namespace Lab1;

class Program
{
    static void Main(string[] args)
        // Step 1: Use Comments
    {   /* Name: [Mohammad Saber Sultani] 
           Title: [IT-1050-Lab1] */
        // Step 2: Basic Outsput
        Console.WriteLine("[Name]");
    }   Console.Writeline("[Title]");
        // Step 3: Declare and Use Variables
        int favoriteNumber = 7;
        string favoriteLanguage = "C#";
        double programsWritten = 5.5;
        bool hasExperience = true;
        Console.Writeline("My favorite number is:" + favoriteNumber); 
        Console.Writeline("My favorite programming language is:" + favoriteLanguage);
        Console.Writeline("Number of programms I have Written before this: + programsWritten);
        Console.Writeline("I have programming experience:" + hasexperience);
        // Step 4: Use Constants 
        const string schoolName = "My University";
        Console.Writeline("My school is:" + schoolName);
        // Step 5: Type Casting
        double originalDouble = 9.78;
        int convertedInt = (int)originalDouble;
        int numberToConvert = 42;
        string inToString = Convert.ToString(numberToConvert);
        bool boolToConvert = true;
        string boolToString = Convert.ToString(boolToConvert);
        Console.Writeline("Original double:" + originalDouble);
        Console.Writeline("Converted to int:" + converedInt);
        Console.Writeline("Converted int to string:" + intToString);
        // Step 6: User Input and Type Conversion
        Console.Writeline("Please enter your age:");
        string userName = Console.Readline();
        Console.Writeline("Please enter your age:");
        int userAge = Convert.ToInt32(Console.Readline());
        Console.Writeline("Hello{userName}! You are {userAge} Years old.");
        // Step 7: Arithmetic Opertators 
        int num1 = 15;
        int num2 = 7;
        Console.Writeline("Addition result:" + (num1 + 10));
        Console.Writeline("Subtraction result:" + (num1 - 2))
        Console.Writeline("Multiplication result:" + (num1 * 3));
        Console.Writeline("Division result:" (num1 / 2));
        Console.Writeline("Modulus result:" + (num1 % 2));
        // Step 8: Floating point precision
        float floatValue = 1.123456789f;
        double doubleValue = 1.123456789;
        Console.Writeline("Float value:" + floatValue);
        Console.Writeline("Double Value:" + doubleValue);
        // Step 9: Increment and Decrement
        int counter = 10;
        Console.Writeline("Original value:" + counter);
        counter++;
        Console.Writeline("After increment:" + counter);
        counter--;
        Console.Writeline("After decrement:" + counter):

}
