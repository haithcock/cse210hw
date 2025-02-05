using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing", duration)
    {
    }

    public override void RunActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int halfDuration = Duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Simulate breathing in for 2 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Simulate breathing out for 2 seconds
        }
    }
}
