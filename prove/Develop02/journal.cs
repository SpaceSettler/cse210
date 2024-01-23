using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public void Display()
    {
        string[] lines = System.IO.File.ReadAllLines("journalGhost.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void Load()
    {
        Console.WriteLine("Where do you want to load the file from?");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            File.WriteAllText("journalGhost.txt", String.Empty);
            foreach (string line in lines)
            {
                using (StreamWriter outputFile = new StreamWriter("journalGhost.txt", true))
                {
                    outputFile.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("File does note exist!");
        }
    }

    public void Save()
    {
        Console.WriteLine("Where do you want to save the file too?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines("journalGhost.txt");
        foreach (string line in lines)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public void Add()
    {
        Prompt prompt1 = new Prompt();
        string prompt = prompt1.GeneratePrompt();
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        string fileName = "journalGhost.txt";
        DateTime now = DateTime.Now;
        string date = now.ToShortDateString();
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"Date: {date} Prompt: {prompt}\n{entry}\n");
        }
    }

    public string showMenu()
    {
        Console.WriteLine("1. Write\n2. Display\n3. Display by Date\n4. Save\n5. Load\n6. Quit");
        return Console.ReadLine();
    }
}