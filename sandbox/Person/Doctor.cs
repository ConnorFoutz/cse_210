class Doctor : Person
{
    private string _tools;
    private string _degree;
    public Doctor(string firstName, string lastName, int age, double weight, string tools, string degree) : base(firstName, lastName, age, weight)
    {
        _tools = tools;
        _degree = degree;
    }

    public string GeDoctorInfo()
    {
        return $"tools: {_tools}\ndegree: {_degree}\n{GetPersonInfo()}";
    }
}