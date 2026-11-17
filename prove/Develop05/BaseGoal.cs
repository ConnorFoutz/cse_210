 class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;

    public BaseGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
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
        return $"[ ] Goal: {_name}\nDescription: {_description}\nPoints {_points}";
    }
}