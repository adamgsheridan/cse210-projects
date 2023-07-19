using System;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.PrintScripture();

        PromptContinue prompt = new PromptContinue();
        prompt.DisplayPrompt();
        

        while (prompt.ShouldContinue() && scripture.HasWordToHide())
        {
            Console.Clear();
            scripture.WriteScriptureWithHiddenWords();
            prompt.DisplayPrompt();
            
        }
        
    }
}