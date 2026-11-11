class Doctor : Person
{
    private string _tools;
    private string _degree;
    public Doctor(string firstName, string lastName, int age, double weight, string tools, string degree) : base(firstName, lastName, age, weight)
    {
        _tools = tools;
        _degree = degree;
    }

    public override string GetPersonInfo()
    {
        return $"tools: {_tools}\ndegree: {_degree}\n{base.GetPersonInfo()}";
    }

    public override double GetSalary()
    {
        return 555000;
    }
}