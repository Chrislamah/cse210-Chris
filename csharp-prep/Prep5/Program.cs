// Import the System namespace.
using System;
// Define the main class.
class Program
{
    // Define the main method.
    static void Main(string[] args)
    {
        // Display the welcome message.
        DisplayWelcome();
        // Prompt the user for their name.
        string name = PromptUserName();
        // Prompt the user for their favorite number.
        int number = PromptUserNumber();
        // Square the user's favorite number.
        int squaredNumber = SquareNumber(number);
        // Display the result.
        DisplayResult(name, squaredNumber);
    }
    // Define the DisplayWelcome method.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    // Define the PromptUserName method.
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    // Define the PromptUserNumber method.
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    // Define the SquareNumber method.
    static int SquareNumber(int number)
    {
        return number * number;
    }
    // Define the DisplayResult method.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine("{0}, your favorite number squared is {1}.", name, squaredNumber);
    }
}