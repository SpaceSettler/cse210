using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("James", "English");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("James", "English", "4", "21");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("James", "English", "Beans");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}