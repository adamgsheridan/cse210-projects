public class Scripture
{
    private string _reference = "John 3:16-17";
    private string _scripture = "16.For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. \n17.For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
    private List<Word> _words = new List<Word>();
    public Scripture()
    {
        foreach (string word in _scripture.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }
    public void PrintScripture()
    {
        Console.Write($"{_reference} ");
        foreach (var word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }
    private int GetRandomNumber(int length)
    {
        
        Random rnd = new Random();
        int number = rnd.Next(length);

        
        return number;
    }
    public bool HasWordToHide()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return true;
            }
        }
        return false;
    }
    private void HideRandomWord()
    {
        if (HasWordToHide())
        {
            int random = GetRandomNumber(_words.Count);

            while (_words[random].IsHidden())
            {
                random = GetRandomNumber(_words.Count);
            }
            _words[random].Hide();
        }
    }
    private void HideNumberOfRandomWords(int numberOfRandomWords)
    {
        for (int i = 0; i < numberOfRandomWords; i++)
            HideRandomWord();
    }
    public void WriteScriptureWithHiddenWords()
    {
        HideNumberOfRandomWords(3);
        PrintScripture();
        Console.WriteLine();

    }
}