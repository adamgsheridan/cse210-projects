using System;

class Program
{
    static void Main(string[] args)
    {
        //Gets the user's first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        //Gets the user's last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //Combines the above first and last name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}