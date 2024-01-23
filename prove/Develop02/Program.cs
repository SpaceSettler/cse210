using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        string result = journal1.showMenu();
        if (result == "1")
        {
            journal1.Add();
        }
        else if (result == "2")
        {
            journal1.Display();
        }
        else if (result == "3")
        {
            entry1.Display();
        }
        else if (result == "4")
        {
            journal1.Save();
        }
        else if (result == "5")
        {
            journal1.Load();
        }
        else if (result == "6")
        {
            File.WriteAllText("journalGhost.txt", String.Empty);
        }
        if (result != "6")
        {
            Program.Main(args);
        }
    }
}