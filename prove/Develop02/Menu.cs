class menu
{
    public int ProcessMenu()
    {
        int input = 0;
         while (input < 1 || input >5)
        {
            Console.WriteLine("\n\nWelcome to the journal program");
            Console.WriteLine("Create Display, Save or Read Journal Entries.");
            Console.WriteLine("1. Create new Journal entry");
            Console.WriteLine("2. Display all Journal entries");
            Console.WriteLine("3. Save Journal to a file.");
            Console.WriteLine("4. Read Journal from a file.");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());



        }
        return input;
    }
}