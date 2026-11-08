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

        Police police = new Police("Connor","Foutz",21,193,"shooty bang-bang","none");
        Console.WriteLine(police.GetPoliceInfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(John);
        myPeople.Add(Bob);
        myPeople.Add(police);

        foreach (Person person in myPeople)
        {
            if(person is Doctor doctor)
            {
                Console.WriteLine(doctor.GeDoctorInfo());
            }
            else
            {
                Console.WriteLine(person.GetPersonInfo());
            }
            
        }
    }
}