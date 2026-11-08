using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        int input = 0;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfullness program!\nChoose an activity from the options below.");
        while(input != 4)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Actvity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a number 1-4: ");
            input = int.Parse(Console.ReadLine());


            if (input == 1)
            {
                Console.Clear();
                BreathingActivity breath = new BreathingActivity();
                breath.RunActivity();

            }
            else if (input == 2)
            {
                Console.Clear();
                ReflectionActivty reflect = new ReflectionActivty();
                reflect.RunActivity();
            }
            else if (input == 3)
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.RunActivity();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thanks for using the mindfullness program!");
            }



        }



    }
}