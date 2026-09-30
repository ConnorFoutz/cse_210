using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double num = -1;
        double sum = 0;
        double len;
        double max = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = double.Parse(Console.ReadLine());
            numbers.Add(num);
            
        }
        foreach (double i in numbers)
        {
            sum += i;
        }
        len = numbers.Count()-1;

        foreach (double i in numbers)
        {
            if (i > max)
            {
                max = i;
            }

        }
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {sum / len}");
        Console.WriteLine($"Max: {max}");

        
    }
}