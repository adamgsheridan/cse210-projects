using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in the class? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        /*
          * A >= 90
          * B >= 80
          * C >= 70
          * D >= 60
          * F < 60
         */
        bool pass = false;
        if (grade >= 90){
            Console.WriteLine("Your final grade is an A!");
            pass = true;
        }
        else if (grade >= 80){
            Console.WriteLine("Your final grade is a B.");
            pass = true;
        }
        else if (grade >= 70){
            Console.WriteLine("Your final grade is a C.");
            pass = true;
        }
        else if (grade >= 60){
            Console.WriteLine("Your final grade us a D.");
            pass = false;
        }
        else {
            Console.WriteLine("Your final grade is an F.");
            pass = false;
        }
        if (pass == true) {
            Console.WriteLine("You passed the class.");
        }
        else {
            Console.WriteLine("You failed the class.");
        }
    }
}