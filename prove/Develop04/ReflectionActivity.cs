class ReflectionActivty : BaseActivity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    private List<string> _reflections = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];

    public void RunActivity()
    {
        StartActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        Random random = new Random();
        

        RunCountDownMessage("Get Ready", 4);
        StartTimer();
        int i = 0;
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        while (!HasTimerExpired())
        {
            Console.WriteLine(_reflections[i]);
            RunSpinnerMessage("",10);
            i ++;
            if(i>_reflections.Count())
            {
                i = 0;
            }
        }

        Console.Clear();

        DisplayEndMessage($"You have completed {GetDuration()} seconds of the reflection activity");


    }
}