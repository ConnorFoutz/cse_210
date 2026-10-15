using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction first = new Fraction();
        Console.WriteLine(first.GetDecimalValue());
        Fraction second = new Fraction(5,2);
        Console.WriteLine(second.GetDecimalValue());
        Fraction third = new Fraction(5,3);
        Console.WriteLine(third.GetFractionString());

        Random num = new Random();
        Fraction looped = new Fraction();

        for (int i = 0; i < 20; i ++)
        {
            int top = num.Next(1,15);
            int bottom = num.Next(1,15);
            looped.SetTop(top);
            looped.SetBottom(bottom);
            Console.WriteLine($"Fraction {i+1} \nDecimal: {looped.GetDecimalValue()} \nFraction: {looped.GetFractionString()}");


            


        }

    }
}