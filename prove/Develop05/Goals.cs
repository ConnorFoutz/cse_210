class Goals
{
    private List<BaseGoal> _goals = [];
    private int _score = 0;

    // Add LoadGoals and ReadGoals

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetConsoleString()}");
        }
        // foreach (BaseGoal goal in _goals)
        // {
        //     Console.WriteLine($"\n{goal.GetConsoleString()}");
        // }
    }

    public void ListGoalsEvent()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }


    public int DisplayScore()
    {
        return _score;
    }

    public List<BaseGoal> GetGoals()
    {
        return _goals;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int i)
    {
        int newPoints = _goals[i-1].RecordEvent();
        Console.WriteLine($"Congrats! You just earned {newPoints} points!");
        _score += newPoints;
        //Console.WriteLine($"You now have {_score} points.");


    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        string[] liness = lines[1..];
        foreach (string line in liness)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string goalText = parts[1];
            if (type == "SimpleGoal")
            {
                string[] goalParts = goalText.Split("#");
                bool complete = bool.Parse(goalParts[0]);
                string name = goalParts[1];
                string description = goalParts[2];
                int points = int.Parse(goalParts[3]);

                SimpleGoal newGoal = new SimpleGoal(name,description,points,complete,type);
                AddGoal(newGoal);
            }
            else if (type == "EternalGoal")
            {
                string[] goalParts = goalText.Split("#");
                bool complete = bool.Parse(goalParts[0]);
                string name = goalParts[1];
                string description = goalParts[2];
                int points = int.Parse(goalParts[3]);

                EternalGoal newGoal = new EternalGoal(name,description,points,complete,type);
                AddGoal(newGoal);
                
            }
            else if (type == "ChecklistGoal")
            {
                string[] goalParts = goalText.Split("#");
                bool complete = bool.Parse(goalParts[0]);
                string name = goalParts[1];
                string description = goalParts[2];
                int points = int.Parse(goalParts[3]);
                int iterations = int.Parse(goalParts[4]);
                int iterationsComplete = int.Parse(goalParts[5]);
                int bonus = int.Parse(goalParts[6]);

                ChecklistGoal newGoal = new ChecklistGoal(name,description,points,complete,type,iterations,iterationsComplete,bonus);
                AddGoal(newGoal);
            }


            
            
        }
    }


}