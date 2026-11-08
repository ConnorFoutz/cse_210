class Police : Person
{
    private string _weapons;
    private string _degree;
    public Police(string firstName, string lastName, int age, double weight, string weapons, string degree) : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
        _degree = degree;
    }

    public string GetPoliceInfo()
    {
        return $"weapons: {_weapons}\ndegree: {_degree}\n{GetPersonInfo()}";
    }
}