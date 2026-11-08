class BreathingActivity : BaseActivity

{
    public BreathingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        StartActivity("This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.");

        RunCountDownMessage("Get Ready", 4);
        StartTimer();
        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breath in",4);
            RunCountDownMessage("Breath out",6);
        }
        Console.Clear();

        DisplayEndMessage($"You have completed {GetDuration()} the breathing activity");
        
    }

    


}