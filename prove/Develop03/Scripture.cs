using System.ComponentModel.DataAnnotations;

class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;


    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, verse);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _words = ConvertToWordList(text);
        _reference = reference;
    }


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

    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }

    public int GetScriptureLength()
    {
        return _words.Count();
    }

    public int GetNumberHidden()
    {
        int i = 0;
        foreach (Word w in _words)
        {
            if(w.IsHidden() == true)
            {
                i ++;
            }
        }
        return i;
    }

    public void HideWords()
    {
        if(GetScriptureLength() - GetNumberHidden() <5)
        {
            foreach (Word w in _words)
            {
                w.Hide();
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                int randWord = Random.Shared.Next(_words.Count());
                if(_words[randWord].IsHidden() == false)
                {
                    _words[randWord].Hide();
                }
                else
                {
                    i--;
                }
            }
        }
        
    }
}