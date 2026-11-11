class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        
        // if(person is Doctor doctor)
        // {
        //     Console.WriteLine(doctor.GeDoctorInfo());
        // }
        // else if (person is Police police)
        // {
        //     Console.WriteLine(police.GetPoliceInfo());
        // }
        // else
        // {
            Console.WriteLine($"Salary: {person.GetSalary()}");
            Console.WriteLine(person.GetPersonInfo());
        //}
            
    }

    public static void Main()
    {
        Console.WriteLine("Ola, mundo");
        // Cannot declare person because it's abstract
        //Person John = new Person("John","Doe",82,170);
        //Console.WriteLine(John.GetPersonInfo());

        Doctor Bob = new Doctor("Bob","Firman",45,210,"scalpel","MRS.");
        //Console.WriteLine(Bob.GetPersonInfo());
        //Console.WriteLine(Bob.GetPersonInfo());

        Police police = new Police("Connor","Foutz",21,193,"shooty bang-bang","none");
        //Console.WriteLine(police.GetPersonInfo());

        List<Person> myPeople = new List<Person>();

        //myPeople.Add(John);
        myPeople.Add(Bob);
        myPeople.Add(police);
        foreach (Person p in myPeople)
        {
            DisplayPersonInformation(p);
        }

    
    }
}