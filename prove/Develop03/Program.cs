using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Alma";
        int chapter = 30;
        int verse = 44;
        int endVerse = 44;
        string scripture = "But Alma said unto him: Thou hast had signs enough; will ye tempt your God? Will ye say, Show unto me a sign, when ye have the testimony of all these thy brethren, and also all the holy prophets? The scriptures are laid before thee, yea, and all things denote there is a God; yea, even the earth, and all things that are upon the face of it, yea, and its motion, yea, and also all the planets which move in their regular form do witness that there is a Supreme Creator.";
        Console.WriteLine("Do you want to use your own scripture? Y/N");
        string response = Console.ReadLine();
        if (response.ToUpper() == "Y")
        {
            Console.WriteLine("What is the Book?");
            book = Console.ReadLine();
            Console.WriteLine("What is the chapter?");
            chapter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the first verse?");
            verse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the last verse?");
            endVerse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the scripture?");
            scripture = Console.ReadLine();
        }
        else if (response.ToLower() == "quit")
        {
            System.Environment.Exit(0);
        }
        Reference ref1 = new Reference(book, chapter, verse, endVerse);
        if (endVerse == verse)
        {
            ref1 = new Reference(book, chapter, verse);
        }
        Scripture scrip1 = new Scripture(ref1, scripture);
        while (scrip1.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(ref1.GetDisplayText());
            Console.WriteLine(scrip1.GetDisplayText());
            Console.WriteLine("Press enter to continue, type 'quit' to quit.");
            response = Console.ReadLine();
            if (response.ToLower() == "quit")
            {
                System.Environment.Exit(0);
            }
            scrip1.HideRandomWords(scripture.Split().Length/5);
        }
        Console.Clear();
        Console.WriteLine(ref1.GetDisplayText());
        Console.WriteLine(scrip1.GetDisplayText());
        Console.ReadLine();
    }
}