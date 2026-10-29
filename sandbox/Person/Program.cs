class Program
{
    public static void Main()
    {
        Console.WriteLine("Ola, mundo");
        Person John = new Person("John","Doe",82,170);
        Console.WriteLine(John.GetPersonInfo());

        Doctor Bob = new Doctor("Bob","Firman",45,210,"scalpel","MRS.");
        Console.WriteLine(Bob.GetPersonInfo());
        Console.WriteLine(Bob.GeDoctorInfo());
    }
}