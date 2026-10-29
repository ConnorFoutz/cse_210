using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment myAssignment = new MathAssignment("Connor", "Math review", "5", "1,4,6,9-13");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine(myAssignment.GetHomeworkList());

        WritingAssignment gradeInflation = new WritingAssignment("Connor Foutz", "Eng 301","Effects of Grade Inflation on student success");
        Console.WriteLine(gradeInflation.GetSummary());
        Console.WriteLine(gradeInflation.GetWritingInfo());

    }
}