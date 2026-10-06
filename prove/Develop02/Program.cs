using System;

class Program
{
    static void Main(string[] args)
    {
        menu mymenu = new menu();
        Console.WriteLine("Hello Develop02 World!");
        int response = 0;

        while (response != 5)
        {  
            response =  mymenu.ProcessMenu();


            switch(response)
            {
                case 1:
                    Console.WriteLine("Create: ");
                    //Call CreateJournalENtry
                    break;
                case 2:
                    Console.WriteLine("Display: ");
                    // Call DisplayJournal
                    break;
                case 3:
                    Console.WriteLine("Save: ");
                    // Call ReadFromFile()
                    break;
                case 4:
                    Console.WriteLine("Write: ");
                    // call WriteToFile()
                    break;
            }
        }
    }
}