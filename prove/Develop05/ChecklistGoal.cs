class ChecklistGoal : BaseGoal
{
    public ChecklistGoal() : base("ChecklistGoal")
    {
        
    }

    public ChecklistGoal(string name, string description, int points, bool complete, string goalType) 
    : base (name, description, points, complete, goalType)
    {
        
    }

    public override int RecordEvent()
    {
        return 0;
    }
}