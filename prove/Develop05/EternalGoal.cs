class EternalGoal : BaseGoal
{
    public EternalGoal() : base("EternalGoal")
    {
        
    }

    public EternalGoal(string name, string description, int points, bool complete, string goalType) 
    : base (name, description, points, complete, goalType)
    {
        
    }

    public override int RecordEvent()
    {
        MarkComplete();
        return GetPoints();
    }
}