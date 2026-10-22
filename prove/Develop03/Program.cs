using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // Word myword = new Word("Secret");
        // myword.DisplayWord();
        // myword.Hide();
        // myword.DisplayWord();

        Scripture myscrip = new Scripture("Moses", 6, 34, 
        "Behold my Spirit is upon you, wherefore all thy words will I justify; and the mountains shall flee before you, and the rivers shall turn from their course; and thou shalt abide in me, and I in you; therefore walk with me.");

        myscrip.ShowScripture();
    }
}