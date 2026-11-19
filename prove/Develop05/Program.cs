using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseGoal mygoal = new BaseGoal("BaseGoal");
        // Console.WriteLine(mygoal.GetConsoleString());

        SimpleGoal mySimpleGoal = new SimpleGoal();
        
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        mySimpleGoal.MarkComplete();
        Console.WriteLine(mySimpleGoal.GetConsoleString());

        
    }
}