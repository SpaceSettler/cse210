public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds would you like your session?");
        _duration = Int32.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell Done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        seconds = seconds * 1000;
        while (seconds > 0)
        {
            Console.Write("\b|");
            Thread.Sleep(250);
            seconds = seconds - 250;
            Console.Write("\b/");
            Thread.Sleep(250);
            seconds = seconds - 250;
            Console.Write("\b-");
            Thread.Sleep(250);
            seconds = seconds - 250;
            Console.Write("\b\\");
            Thread.Sleep(250);
            seconds = seconds - 250;
        }
        Console.Write("\b \n");
    }
    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write($"\b{seconds}");
            Thread.Sleep(1000);
            seconds = seconds - 1;
        }
        Console.Write("\b");
    }
}