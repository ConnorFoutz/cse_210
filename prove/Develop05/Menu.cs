class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");

    }

    public void GoalMenu()
    {
        Console.WriteLine("\n Select the type of goal:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("What kind of goal would you like to make? ");
        
    }

    
}