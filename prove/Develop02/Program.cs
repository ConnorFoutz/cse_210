using System;

class Program
{
    static void Main(string[] args)
    {
        menu mymenu = new menu();

        Journal myJournal = new Journal();
        string file = "";


        Console.WriteLine("Welcome to the Journal!");
        int response = 0;

        while (response != 5)
        {  
            response =  mymenu.ProcessMenu();


            switch(response)
            {
                case 1:
                    myJournal.CreateEntry();
                    //Call CreateJournalENtry
                    break;
                case 2:
                    Console.WriteLine("Display: ");
                    // Call DisplayJournal
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Save to what file? ");
                    file = Console.ReadLine();
                    myJournal.WriteToFile(file);
                    Console.WriteLine("Saved to file");
                    break;
                case 4:
                    Console.Write("Read from what file? ");
                    file = Console.ReadLine();
                    myJournal.ReadFromFile(file);
                    break;
            }
        }
    }
}