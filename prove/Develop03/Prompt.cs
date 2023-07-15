public class PromptContinue
{
    public void DisplayPrompt()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
    public string GetDirection()
    {
        string direction = Console.ReadLine();
        return direction;
    }
}