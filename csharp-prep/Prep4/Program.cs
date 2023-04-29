using System;

class Program
{
    static void Main(string[] args)
    {
        // This is equivalent to the line below this one: List<int> numbers = new List<int>();
        var numbers = new List<int>();

        
        while (true) {
            Console.Write("Please enter a number (Enter 0 to STOP): ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0) {
                break;
            }

            numbers.Add(number);
        }

        // Starts the total and number counter at 0.
        int total = 0;
        int counter = 0;
        // Adds the user's input and counts how many numbers have been entered.
        foreach (var num in numbers) {
            total += num;
            counter += 1;
        }
        // Writes out the total of all of the numbers.
        Console.Write($"The total is {total}. ");

        // Calculates the average using the total and counter variables.
        float average = (float)total / (float)counter;
        // Writes out the average of the user's input.
        Console.Write($"The average of those numbers is {average}.");
    }
}