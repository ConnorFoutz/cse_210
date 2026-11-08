class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    public BaseActivity()
    {
        
    }

    public void StartActivity(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(3000);
        //Console.Clear();
        _duration = SetDuration();
        Thread.Sleep(1000);
        Console.Clear();
    }

    public int SetDuration()
    {
        Console.Write("How long, in seconds, would you like this to take? ");
        return int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        Console.WriteLine(message);
        while(DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
    
    public void DisplayEndMessage(string message)
    {
        Console.WriteLine("Well Done!");
        RunSpinnerMessage("",5);
        Console.WriteLine(message);
        Thread.Sleep(3000);
        Console.Clear();

    }
}