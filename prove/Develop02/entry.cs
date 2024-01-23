using System;

public class Entry
{
    public string _date;
    public List<Prompt> _prompts;

    public void Display()
    {
        Console.WriteLine("What Date? (M/DD/YYY)");
        _date = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines("journalGhost.txt");
        bool NextLine = false;
        bool GotOne = false;
        foreach (string line in lines)
        {
            if (NextLine == true)
            {
                Console.WriteLine(line);
                Console.WriteLine();
                NextLine = false;

            }
            if (line.StartsWith($"Date: {_date}"))
            {
                Console.WriteLine(line);
                GotOne = true;
                NextLine = true;
            }
            
        }
        if (!GotOne)
        {
            Console.WriteLine("No entries with that date.\nMaybe it wasn't a real date?");
        }
    }
}