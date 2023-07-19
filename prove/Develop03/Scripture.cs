public class Scripture
{
    public string GetReference()
    {
        string reference = "John 3:16-17";
        return reference;
    }
    public string GetScripture()
    {
        string scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life \nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        return scripture;
    }

    public string[] SortScripture()
    {
        Scripture OriginalScripture = new Scripture();
        string scripture = OriginalScripture.GetScripture();
        string[] SortedScriptures = scripture.Split(" ");
        return SortedScriptures;
    }
    
    //string[] scriptureReference = {"John 3:16-17"};
    //string[] scripture = {"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life \nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved."};
}