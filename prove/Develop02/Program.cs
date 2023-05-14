using System;

class Program {
    static void Main(string[] args)
    {
        //Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
        //"How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
        // "If I had one thing I could do over today, what would it be?
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
    }
}
class Journal {
    public List<Entry> _entries = new List<Entry>();
}
class Entry {
    public string _text;
    public string _prompt;
    public string _date;
}