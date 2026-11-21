class Goals
{
    private List<BaseGoal> _goals = [];
    private int _score = 0;

    // Add LoadGoals and ReadGoals

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine($"\n{goal.GetConsoleString()}");
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

}