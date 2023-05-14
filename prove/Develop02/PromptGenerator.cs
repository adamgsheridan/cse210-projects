public class PromptGenerator
{
  string welcome = "Welcome to the Journal Program!";
  static void Greeting()
  {
    PromptGenerator menu = new PromptGenerator();
    Console.WriteLine(menu.welcome);
    }
}













/*
public class PromptGenerator {
    public void GeneratePrompt() {
        string welcome = "Welcome to the Journal Program!";
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
    }
}*/
