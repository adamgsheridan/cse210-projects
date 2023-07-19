class Word
{
    private string _word;
    private bool _isHidden = false;
    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        if (_isHidden)
            return MakeHidden();
        return _word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    private string MakeHidden()
    {
        string letters = "";
        foreach (char letter in _word)
        {
            letters = letters + ("_");
        }

        return letters;
    }
}