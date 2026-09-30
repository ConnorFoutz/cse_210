using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _name = "";

    public Resume()
    {}
    public List<Job> _jobs = new List<Job>();

    public void PrintResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job i in _jobs)
        {
            i.DisplayJob();
        }
    }
}