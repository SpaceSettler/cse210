public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                break;
            }
            Console.Write("\n\nBreath in....");
            ShowCountDown(4);
            Console.Write("\nNow Breath out....");
            ShowCountDown(6);
        }
    }
}