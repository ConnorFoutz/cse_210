class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public ScriptureReference(string bookName, int chapter, int startVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }

    public void DisplayScriptureReference()
    {
        Console.WriteLine(GetScriptureReference());
    }

    public string GetScriptureReference()
    {
        if(_endVerse == 0)
        {
            return $"{_bookName} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
        }
        
    }

}