class Scripture
{
    private List<Word> _words;
    private Scripture _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
    }

    // Add constructer for scripture reference

    // ConvertToWordList() will recieve a paragraph and split it into words, making a list of class Word.
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(" ");
        foreach (string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }

    public void ShowScripture()
    {
        foreach (Word w in _words)
        {
            w.DisplayWord();
        }
    }
}