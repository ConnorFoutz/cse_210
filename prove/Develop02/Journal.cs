class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    // public void WriteToFile(string filename)​
    // {
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach(JournalEntry entry in entries)​
    //         {
    //             outputFile.WriteLine(_entry.ToString());
    //         }
    //     }
    // }
}