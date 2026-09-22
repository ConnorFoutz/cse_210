using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bom dia gente!");
        Console.WriteLine("I have never dealt drugs.\n\n");

        int x = 11;
        int y = 20;
        int z = 40;

        if (x==10 && y == 20 || z == 40) //&& has higher precedence
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("dont' do drugs");
        }

        else if (x==20)
        {
            Console.WriteLine("X is 10");
        }
        else
        {
            Console.WriteLine("I'm tired");
        }



    }
}


// Indentation and white space makes no difference