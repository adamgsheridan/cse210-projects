using System;

class Program
{
    static void Main(string[] args)
    {
        //string scriptureReference = "John 3:16-17";
        Scripture Scriptures = new Scripture();
        string reference = Scriptures.GetReference();
        Console.Write(reference + " ");
        string[] SortedScriptures = Scriptures.SortScripture();
        foreach (var SortedScripture in SortedScriptures)
        {
            Console.Write($"{SortedScripture}" + " ");
        }
        Console.WriteLine();
        PromptContinue prompt = new PromptContinue();
        prompt.DisplayPrompt();
        Console.WriteLine();

        string direction = prompt.GetDirection();
        Console.WriteLine();















        while (direction != "quit")
        {
            Word word = new Word();
            int random = word.GetRandomNumber();
            string hidden = word.MakeHidden();
            Console.Clear();
            Console.Write(reference + " ");
            foreach (var SortedScripture in SortedScriptures)
            {
                if (SortedScripture == SortedScriptures[random])
                {
                    Console.Write($"{hidden}");
                }
                else
                {
                    Console.Write($"{SortedScripture}" + " ");
                }
            }
            Console.WriteLine();
            prompt.DisplayPrompt();
            Console.WriteLine();
            direction = prompt.GetDirection();
            Console.WriteLine();
        }
        //Word word = new Word();
        //word.MakeHidden();
    }
}