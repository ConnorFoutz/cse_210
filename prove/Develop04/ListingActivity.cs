using System.Formats.Asn1;

class ListingActivity : BaseActivity
{
    private List<string> _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];    
    
    private List<string> _responses = [];


    public void RunActivity()
    {
        StartActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\nAfter the prompt shows, list as many answers as you can, pressing enter after each one.\n");
        Random random = new Random();
        
        RunCountDownMessage("Get Ready", 4);
        StartTimer();
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        RunSpinnerMessage("",5);
        Console.WriteLine();
        while (!HasTimerExpired())
        {
            Console.Write("Answer: ");
            _responses.Add(Console.ReadLine());
            Console.Clear();
        }
        Console.WriteLine("Answers:");
        foreach (string item in _responses)
        {
            Console.WriteLine($" - {item}");
        }

        DisplayEndMessage($"You have completed {GetDuration()} seconds of the Listing activity");

    }
}