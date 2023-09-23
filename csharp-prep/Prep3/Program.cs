// This is a simple guessing number game in C#.
// The program will generate a random number between 1 and 100, 
//and the user will have to guess the number.
// Import the System namespace.
using System;
// Define the main class.
class GuessingNumberGame
{
    // Define the main method.
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100.
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        // Get the user's guess.
        Console.WriteLine("Enter your guess:");
        int guess = int.Parse(Console.ReadLine());
        // Check if the guess is correct.
        while (guess != randomNumber)
        {
            // If the guess is too high, tell the user to guess lower.
            if (guess > randomNumber)
            {
                Console.WriteLine("Your guess is too high. Guess lower:");
                guess = int.Parse(Console.ReadLine());
            }
            // If the guess is too low, tell the user to guess higher.
            else
            {
                Console.WriteLine("Your guess is too low. Guess higher:");
                guess = int.Parse(Console.ReadLine());
            }
        }
        // If the guess is correct, tell the user they won.
        Console.WriteLine("Congratulations! You guessed the correct number.");
    }
}