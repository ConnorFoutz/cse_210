using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);
        int guess = 0;
        
        Console.WriteLine("Number Guessing Game");
        Console.WriteLine("Guess a number between 1 and 100\n");
        do
        {
            Console.Write("Guess: ");
            guess = int.Parse(Console.ReadLine());
            if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }

        } while (guess != num);
        Console.WriteLine("That's right!");
        
        

    }
}