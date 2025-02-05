using System;
using System.Threading;

public abstract class Activity
{
    // Properties
    public string Name { get; set; }
    public int Duration { get; set; }

    // Constructor
    public Activity(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    // Methods
    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} activity for {Duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds before starting
    }

    public void EndActivity()
    {
        Console.WriteLine("You did a great job!");
        Console.WriteLine($"You have completed the {Name} activity.");
        Thread.Sleep(2000); // Pause for 2 seconds before finishing
    }

    // Abstract method to be implemented by derived classes
    public abstract void RunActivity();
}
