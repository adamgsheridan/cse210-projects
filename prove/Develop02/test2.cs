using System;
public class PromptGenerator
{
  string welcome = "Welcome to the Journal Program!";
  static void Main(string[] args)
  {
    PromptGenerator menu = new PromptGenerator();
    Console.WriteLine(menu.welcome);
    }
}