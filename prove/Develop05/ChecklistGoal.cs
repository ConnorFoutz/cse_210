class ChecklistGoal : BaseGoal
{
    private int _iterations;
    private int _iterationsComplete = 0;
    private int _bonus;
    public ChecklistGoal() : base("ChecklistGoal")
    {
        SetBonus();
        SetIterations();
    }

    public ChecklistGoal(string name, string description, int points, bool complete, string goalType) 
    : base (name, description, points, complete, goalType)
    {
        
    }

    public void SetBonus()
    {
        Console.Write("How many bonus points do you get for finishing this goal? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public void SetIterations()
    {
        Console.Write("How many times do you need to complete this goal? ");
        _iterations = int.Parse(Console.ReadLine());
    }

    public override string GetConsoleString()
    {
        //return $"[{completeString}] Goal: {Get} ({_description}) ({_points})";

        return $"{base.GetConsoleString()} -- Currently completed: {_iterationsComplete}/{_iterations}";
    }

    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_iterations}#{_iterationsComplete}#{_bonus}";
    }

    public override int RecordEvent()
    {
        _iterationsComplete += 1;
        if (_iterationsComplete == _iterations)
        {
            MarkComplete();
            return _bonus + GetPoints();
        }
        else
        {
            return GetPoints();
        }
        
    }
}