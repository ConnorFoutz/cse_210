using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Word myword = new Word("Secret");
        myword.DisplayWord();
        myword.Hide();
        myword.DisplayWord();
    }
}