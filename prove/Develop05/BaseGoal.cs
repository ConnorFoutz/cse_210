 abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;


    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.Write($"What is the description of {_name} goal? ");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.Write($"How many points is {_name} worth? ");
        _points = int.Parse(Console.ReadLine());
    }


    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }
        return $"[{completeString}] Goal: {_name}\nDescription: {_description}\nPoints: {_points}";
    }

    public virtual string GetFileString()
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }
        //return $"[{completeString}]#Goal: {_name}#Description: {_description}#Points: {_points}";
        return $"{_complete}#{_name}#{_description}#{_points}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public abstract int RecordEvent();
}