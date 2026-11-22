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
                string goal_input;
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
                Thread.Sleep(3000);
            }
            else if (input == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                goals.WriteToFile(Console.ReadLine());
            }
            else if (input == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                goals.ReadFromFile(Console.ReadLine());                
            }
            else if (input == "5")
            {
                int eventInput;
                goals.ListGoalsEvent();
                Console.Write("Which goal did you acomplish? ");
                eventInput = int.Parse(Console.ReadLine());
                goals.RecordEvent(eventInput);   
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