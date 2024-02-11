public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and you can use it in other aspects if your life.";
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt.\n");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:  ");
        ShowCountDown(3);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                break;
            }
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(15);
        }
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rndInt = rnd.Next(4);
        string prompt = _prompts[rndInt];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int rndInt = rnd.Next(4);
        string prompt = _questions[rndInt];
        return prompt;
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}