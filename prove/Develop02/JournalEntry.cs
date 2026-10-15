class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public List<string> _prompts = ["How was your day?","What would you do over today?", "Would an apple pie have made your day better? Why?","What made you happy today?"];
    public int randint;

    

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToString();
        Random rand = new Random();
        randint = rand.Next(_prompts.Count);
        _prompt = _prompts[randint];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}