using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseGoal mygoal = new BaseGoal("BaseGoal");
        // Console.WriteLine(mygoal.GetConsoleString());

        // SimpleGoal mySimpleGoal = new SimpleGoal();
        
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        // mySimpleGoal.MarkComplete();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        Console.Clear();
        Menu menu = new Menu();
        Goals goals = new Goals();
        string input = "";
        while (input != "6")
        {
            //Console.Clear();
            Console.WriteLine($"You have {goals.DisplayScore()} points. \n");
            menu.DisplayMenu();
            input = Console.ReadLine();

            if (input == "1")
            {  
                string goal_input = "";
                menu.GoalMenu();
                goal_input = Console.ReadLine();
                if (goal_input == "1")
                {
                    SimpleGoal newSimpleGoal = new SimpleGoal();
                    goals.AddGoal(newSimpleGoal);
                }
                else if (goal_input == "2")
                {
                    EternalGoal newEternalGoal = new EternalGoal();
                    goals.AddGoal(newEternalGoal);
                }
                else
                {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    goals.AddGoal(newChecklistGoal);
                }
            }
            else if (input == "2")
            {
                goals.ListGoals();
            }
            else if (input == "3")
            {
                Console.WriteLine("Save Goals");
            }
            else if (input == "4")
            {
                Console.WriteLine("Load Goals");                
            }
            else if (input == "5")
            {
                Console.WriteLine("Record Event");                
            }
            else if (input == "6")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Input invalid. Please try again");
            }
        }
        
    }
}