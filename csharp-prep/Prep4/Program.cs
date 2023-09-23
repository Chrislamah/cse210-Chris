// This program asks the user for a series of numbers, and appends each one to a list. 
//It stops when the user enters 0.
// Import the System namespace.
using System;
// Define the main class.
class NumberList
{
    // Define the main method.
    static void Main(string[] args)
    {
        // Create a list to store the numbers.
        List<int> numbers = new List<int>();
        // Get the user's input.
        Console.WriteLine("Enter a series of numbers, and enter 0 to stop:");
        int number = int.Parse(Console.ReadLine());
        // Add the numbers to the list.
        while (number != 0)
        {
            numbers.Add(number);
            number = int.Parse(Console.ReadLine());
        }
        // Compute the sum of the numbers.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        // Compute the average of the numbers.
        double average = (double)sum / numbers.Count;
        // Find the maximum number.
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        // Display the results.
        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The maximum number is: " + max);
    }
}