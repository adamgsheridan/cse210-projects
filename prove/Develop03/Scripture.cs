public class Scripture
{
    public string GetScripture()
    {
        string scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life \nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        return scripture;
    }

    //public List<string> SortScripture()
    void SortScripture()
    {
        Scripture OriginalScripture = new Scripture();
        string scripture = OriginalScripture.GetScripture();

        //List<String> SortedScripture = new List<String>();
        //SortedScripture.Add("hello");
        //Console.WriteLine(SortedScripture);
        //int counter = 0;
        //for (int i = 0; i <= scripture.Length; i++)
        //{
            //SortedScripture.Add(i);
        //}
        //foreach(var i in scripture.Split(" "))
        //{
            //Console.WriteLine(i);
        //    SortedScripture.Add(i);
            //Console.WriteLine(SortedScripture);
            //counter++;
        //}
        //return SortedScripture;
    }
    
    //string[] scriptureReference = {"John 3:16-17"};
    //string[] scripture = {"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life \nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved."};
}