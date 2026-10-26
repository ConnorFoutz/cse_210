using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        // Word myword = new Word("Secret");
        // myword.DisplayWord();
        // myword.Hide();
        // myword.DisplayWord();

        Scripture moses = new Scripture("Moses", 6, 34, 
        "Behold my Spirit is upon you, wherefore all thy words will I justify; and the mountains shall flee before you, and the rivers shall turn from their course; and thou shalt abide in me, and I in you; therefore walk with me.");

        Scripture mosiah = new Scripture("Mosiah",15,1,"And now Abinadi said unto them: I would that ye should understand that God himself shall come down among the children of men, and shall redeem his people.");

        Scripture proverbs = new Scripture("Proverbs",3,5,6,"Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        int choice;
        Menu menu = new Menu();


        Console.WriteLine("Welcome to the Scripture Memorization program!");
        Console.WriteLine("Choose one of the following scriptures to memorize.");
        Console.WriteLine($"1. {moses.GetScriptureReference()}");
        Console.WriteLine($"2. {mosiah.GetScriptureReference()}");
        Console.WriteLine($"3. {proverbs.GetScriptureReference()}");
        Console.Write("Which would you like to memorize today? (enter 1, 2 or 3) ");
        choice = int.Parse(Console.ReadLine());
        Console.Clear();

        if(choice == 1)
        {
            menu.Display(moses);
        }
        else if(choice == 2)
        {
            menu.Display(mosiah);
        }
        else if(choice == 3)
        {
            menu.Display(proverbs);
        }
        

    }

}