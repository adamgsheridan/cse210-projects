public class Write
{
    private PromptGenerator _prompt;
    // This is a constructor for the write class.
    public Write()
    {
        this._prompt = new PromptGenerator();
    }
    // Uses the given input from prompt from the list of prompts.
    Random rnd = new Random();
    public Entry WriteEntry()
    {
        // Puts the possible journal prompts in the inspiration string.
        string[] inspiration = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?"
         , "If I had one thing I could do over today, what would it be?"};

        // Sets prompt equal to a random prompt from the inspiration string.
        string prompt = inspiration[rnd.Next(5)];

        // Writes the prompt for the user.
        Console.Write(prompt + "\n> ");

        // Allows the user to input their journal entry.
        string entryText = this._prompt.GetInput();
        Entry entry = new Entry();
        entry._text = entryText;
        entry._prompt = prompt;
        
        // Formats the date.
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        return entry;
    }
}