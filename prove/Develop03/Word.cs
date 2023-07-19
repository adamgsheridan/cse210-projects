class Word {
    public int GetRandomNumber()
    {
        Scripture scripture = new Scripture();
        string[] script = scripture.SortScripture();
        Random rnd = new Random();
        int number = rnd.Next(script.Length);
        return number;
    }
    public string MakeHidden()
    {
        Scripture scripture = new Scripture();
        string[] WholeScripture = scripture.SortScripture();
        Word word = new Word();
        int RandomNumber = word.GetRandomNumber();
        String[] HiddenWord = new String[20];
        int counter = 0;
        for (int i = 0; i <= RandomNumber; i++)
        {
            if (i == RandomNumber)
            {
                //Console.Write(WholeScripture[i]);
                foreach (var whole in WholeScripture[i])
                {
                    counter++;
                }
            }
        }
        //Console.Write(counter);
        string letters = "";
        for (int i = 0; i < counter; i++)
        {
            letters = letters + ("_");
        }
        //Console.Write(letters);
        return letters;
    }

}