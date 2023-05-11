using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
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