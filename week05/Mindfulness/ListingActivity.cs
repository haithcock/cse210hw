using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration)
        : base("Listing", duration)
    {
    }

    public override void RunActivity()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Count);
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine(prompts[promptIndex]);

        // Begin listing items
        List<string> listedItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Console.WriteLine("Start listing now (type an item and press enter):");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    listedItems.Add(item);
                }
            }
        }

        // Display the number of items listed
        Console.WriteLine($"You have listed {listedItems.Count} items.");
    }
}
