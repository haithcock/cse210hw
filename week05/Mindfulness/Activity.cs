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
  public void GreetInKorean()
    {
        var now = DateTime.Now;
        if (now.Hour < 12)
        {
            Console.WriteLine("안녕하세요! 좋은 아침이에요. (Good morning!)");
        }
        else if (now.Hour < 18)
        {
            Console.WriteLine("안녕하세요! 좋은 오후입니다. (Good afternoon!)");
        }
        else
        {
            Console.WriteLine("안녕하세요! 좋은 저녁이에요. (Good evening!)");
        }
    }
    // Methods
    public void StartActivity()
    {
        GreetInKorean(); 
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
