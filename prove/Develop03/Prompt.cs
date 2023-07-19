public class PromptContinue
{
    private string _direction;
    public void DisplayPrompt()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.WriteLine();
        _direction = Console.ReadLine();
        Console.WriteLine();
    }

    public bool ShouldContinue()
    {
        return _direction != "quit";
    }
}