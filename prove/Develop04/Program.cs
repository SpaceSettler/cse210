using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        ListingActivity list = new ListingActivity();
        int times = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Menu options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\n\nYou've done {times} activities.");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    breath.DisplayStartingMessage();
                    breath.Run();
                    breath.DisplayEndingMessage();
                    times++;
                    break;
                case "2":
                    reflect.DisplayStartingMessage();
                    reflect.Run();
                    reflect.DisplayEndingMessage();
                    times++;
                    break;
                case "3":
                    list.DisplayStartingMessage();
                    list.Run();
                    list.DisplayEndingMessage();
                    times++;
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}