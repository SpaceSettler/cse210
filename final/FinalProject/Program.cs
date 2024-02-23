using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which program do you want to run?");
        string response = Console.ReadLine();
        if (response == "1")
        {
            //Abstraction
            Video vid1 = new Video("Beans", "Jason", 486);
            Video vid2 = new Video("Raviloi", "Milly", 846);
            Video vid3 = new Video("Cancer", "Carl", 648);
            Video vid4 = new Video("DIaphram", "Alonzo", 468);
            Comment c1 = new Comment("Diane", "I love beans!!!");
            vid1.SetComments(c1);
            Comment c2 = new Comment("Stephany", "BEEAAANS!!!!!");
            vid1.SetComments(c2);
            Comment c3 = new Comment("James", "Where's the beef!");
            vid1.SetComments(c3);
            Comment c4 = new Comment("Tiffany", "Pasta does sound good right about now.");
            vid2.SetComments(c4);
            Comment c5 = new Comment("Beatrice", "So that's how that works!");
            vid2.SetComments(c5);
            Comment c6 = new Comment("Klein", "Thank you so much for making this video! It helped a lot.");
            vid2.SetComments(c6);
            Comment c7 = new Comment("Bartholomew", "I thought I had cancer once.");
            vid3.SetComments(c7);
            Comment c8 = new Comment("Mandy", "CANCER!!! *angry* >:(");
            vid3.SetComments(c8);
            Comment c9 = new Comment("Charles", "Wow. That's scary. :,(!");
            vid3.SetComments(c9);
            Comment c10 = new Comment("Mik", "Don't hit it.");
            vid4.SetComments(c10);
            Comment c11 = new Comment("Roxanne", "Am I the only one who thought this was a food item?!");
            vid4.SetComments(c11);
            Comment c12 = new Comment("Freddy", "Turn to Jesus and live!!");
            vid4.SetComments(c12);
            List<Video> videos = new List<Video> { vid1, vid2, vid3, vid4 };
            foreach (Video vid in videos)
            {
                Console.WriteLine(vid.Details());
                vid.GetComments();
                Console.WriteLine();
            }
        }
        if (response == "2")
        {
            Address addy1 = new Address("124 Glendale rd", "South Landing", "Montana", "USA");
            Address addy2 = new Address("9 Privet dr", "West minster", "England", "UK");
            Customer cust1 = new Customer("James", addy1);
            Customer cust2 = new Customer("Melissa", addy2);
            Order ord1 = new Order(cust1);
            Order ord2 = new Order(cust2);
            Product p1 = new Product("Hand Towels", 23, 25, 3);
            ord1.SetProduct(p1);
            Product p2 = new Product("Grenades", 2, 99, 30);
            ord1.SetProduct(p2);
            Product p3 = new Product("Dish Soap", 42, 10, 1);
            ord1.SetProduct(p3);
            Product p4 = new Product("Biscuits", -98, 400, 2);
            ord2.SetProduct(p4);
            Product p5 = new Product("Firebolt", 38, 2000, 1);
            ord2.SetProduct(p5);
            ord1.PackagingLabel();
            ord2.PackagingLabel();
            Console.WriteLine();
            ord1.ShippingLabel();
            ord2.ShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${ord1.TotalCost()}");
            Console.WriteLine($"Total Cost: #{ord2.TotalCost()}");
        }
        if (response == "3")
        {
            Address eAddresss1 = new Address("1280 Surrey Ln", "Holden", "Arizona", "USA");
            Address eAddresss2 = new Address("640 S Myna St.", "Charleston", "Great Britain", "Russia");
            Address eAddresss3 = new Address("113 Meadow glen dr", "Dover", "Wisconsin", "USA");
            Lecture lecture = new Lecture("Bees and Altruism", "the fascinating life of the worlds hardest workers!", "March 28 2025", "6:00AM", eAddresss1, "Jimbo Jenkins", 19);
            Reception reception = new Reception("Kyle and Jenny's Reception", "exiting new developments in the life of Kyle and Jenny!", "September 11 2001", "10:00AM", eAddresss2, "LennyLane82@yahoo.com");
            Outdoor outdoor = new Outdoor("Picnic!", "a picnic in the park", "May 3 2011", "11:30AM", eAddresss3, "Sunny: 73F");
            List<Event> events = new List<Event>();
            events.Add(lecture); events.Add(reception); events.Add(outdoor);
            foreach (Event e in events)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine($"You're invited to {e.ShortDescription()}!\n{e.FullDetails()}\n\n{e.StandardDetails()}\n\n");
            }

        }
        if (response == "4")
        {
            Running run = new Running("Jan 3rd 2023", 34, 5);
            Cycling cyc = new Cycling("Feb 23rd 2024", 101, 13.4);
            Swimming swim = new Swimming("Dec 6th 2023", 6, 21);
            List<Activity> activities = new List<Activity>();
            activities.Add(run); activities.Add(cyc); activities.Add(swim);
            foreach (Activity a in activities)
            {
                Console.WriteLine(a.GetSummary());
            }
        }
    }
}