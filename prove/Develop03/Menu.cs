class Menu
{
    public void Display(Scripture scripture)
    {
        while(scripture.GetNumberHidden() < scripture.GetScriptureLength())
            {
                string input;
                Console.WriteLine($"{scripture.GetScriptureReference()}");
                scripture.ShowScripture();
                Console.Write("\nPress enter to continue or 'quit' to finish. ");
                input = Console.ReadLine();
                if(input == "")
                {
                    scripture.HideWords();
                    Console.Clear();
                }
                else if(input == "quit")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input not understood. Press enter to continue or 'quit' to finish.");
                }

            }
            Console.WriteLine(scripture.GetScriptureReference());
            scripture.ShowScripture();
            Console.WriteLine("\nThank you!");
    }
}