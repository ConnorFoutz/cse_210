class ListingActivity : BaseActivity
{
    private List<string> _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];    
    
    private List<string> _responses;


    public void RunActivity()
    {
        StartActivity("This activity will help you reflect on the good things in your \nlife by having you list as many things as you can in a certain area.");
        Random random = new Random();
        
        RunCountDownMessage("Get Ready", 4);
        StartTimer();
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        RunSpinnerMessage("",5);
        

    }
}