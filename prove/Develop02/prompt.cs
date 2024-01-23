using System;

public class Prompt
{
    public string GeneratePrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was someone who made you smile today?",
            "What was the funniest thing you saw today?",
            "How did you overcome a problem in your life today?",
            "What was something that happened today that reminded you of God?",
            "If you could redo one thing today, what would you change?"
        };
        Random rand = new Random();
        return prompts[rand.Next(0, 4)];
    }
}