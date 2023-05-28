public class PromptGenerator
{
    public void Greeting()
    {
        // Asks the user to select one of the 5 options on the menu.
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }

    public string GetInput()
    {
        // Get's the users input for the menu.
        string choice = Console.ReadLine();
        return choice;
    }

    public string GetFilename()
    {
        // Gets the filename where the user will put their journal entry.
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();
        return filename;
    }
}