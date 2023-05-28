using System;

class Program {
    static void Main(string[] args)
    {
        // Print out Welcome message.
        Console.WriteLine("Welcome to the Journal Program!");

        // Create journal variable from the journal class.
        Journal journal = new Journal();

        // Create prompt variable from the PromptGenerator class.
        PromptGenerator prompt = new PromptGenerator();

        // Calls the Greeting method.
        prompt.Greeting();

        // Creates the choice variable from the GetInput method.
        string choice = prompt.GetInput();

        // Loops as long as the user doesn't choose option 5.
        while (choice != "5")
        {
            // Performs necessary things to write in the journal.
            if (choice == "1")
            {
                // Creates a variable from the Write class.
                Write write = new Write();

                // Creates a variable from the Entry class using the 
                // WriteEntry Method from the Write class.
                Entry entry = write.WriteEntry();

                // This adds the entries to a list of multiple entries.
                journal._entries.Add(entry);
            }
            // Performs necessary things to display the journal.
            else if (choice == "2")
            {
                // Writes what is in the Journal array. Without the override 
                // the below code will show the journal's address.
                Console.WriteLine(journal);
            }
            // Loads whats in the file into the journal.
            else if (choice == "3")
            {
                // Asks the user for a filename.
                string filename = prompt.GetFilename();

                // Creates a variable from FileManager class.
                FileManager loadFileManager = new FileManager();

                // Updates the journal variable with what is on the file.
                journal = loadFileManager.LoadJournal("journal.txt");
            }
            // Saves whats in the journal into a document.
            else if (choice == "4")
            {
                // Prompt for the filename.
                string filename = prompt.GetFilename();

                // Creates a variable from the FileManager class.
                FileManager fileManager = new FileManager();

                // Calls the SaveJournal method from the FileManager to 
                // save the user's journal into the journal.txt file.
                fileManager.SaveJournal(journal, "journal.txt");
            }

            // Displays the greeting from the beginning.
            prompt.Greeting();

            // Asks the user for another prompt.
            choice = prompt.GetInput();
        }
    }
}
class Journal {
    public List<Entry> _entries = new List<Entry>();

    // Override the parent class's implementation of the ToString.
    public override string ToString()
    {
        // Makes the journalString string.
        string journalString = "";

        // Adds each journal entry to the journal.
        foreach (Entry entry in this._entries)
        {
            journalString += entry.ToString();
        }
        return journalString;
    }
}

public class Entry {
    public string _text;
    public string _prompt;
    public string _date;

    // Overrides the parent class's implementation of the ToString.
    public override string ToString()
    {
        // Returns the date, prompt, and journal entries in that order.
        return "Date: " + this._date + " - Prompt: " + this._prompt + "\n" + this._text + "\n\n";
    }
}