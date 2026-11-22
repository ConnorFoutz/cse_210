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
        _goals[i-1].RecordEvent();
    }

}