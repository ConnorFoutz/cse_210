using System;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your number? ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("What year were you born? ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, your number squared is {SquareNumber(square)}.");
        Console.WriteLine($"{name}, you turn {2026-year} years old this year.");
    }




    static void Main(string[] args)
    {
        string name;
        int number;
        int year;
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        PromtUserBirthYear(out year);
        DisplayResult(name,number,year);



    }
}