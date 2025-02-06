using System;
using System.Threading;

public class ListingActivity : Activity
{
    public ListingActivity(int duration)
        : base("Listing", duration)
    {
    }

    public override void RunActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Who are people that you appreciate? List as many as you can:");
        
        // Simulate listing time with a pause
        Thread.Sleep(Duration * 1000); // Total listing time
    }
}
