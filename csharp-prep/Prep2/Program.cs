using System;

class Program
{
    static void Main(string[] args)
    {
        string sgrade;
        string letter;

        Console.WriteLine("Welcome to the grade calculator");
        Console.Write("Please enter your grade: ");
        sgrade = Console.ReadLine();

        int grade = int.Parse(sgrade);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got an {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("You passed! Good job.");
        }
        else
            Console.WriteLine("You failed. Keep trying!");




    }
}