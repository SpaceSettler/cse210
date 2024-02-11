public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.WriteLine($"List as many responses you can to the following prompt:\n\n{GetRandomPrompt()}\n\nYou may begin in:  ");
        ShowCountDown(3);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                break;
            }
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rndInt = rnd.Next(5);
        string prompt = _prompts[rndInt];
        return prompt;
    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}