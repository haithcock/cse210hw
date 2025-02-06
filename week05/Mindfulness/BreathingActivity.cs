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
        int halfDuration = Duration / 10;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in for four seconds...");
            Thread.Sleep(4000); // Simulate breathing in for 4 seconds
            Console.WriteLine("Breathe out for six seconds...");
            Thread.Sleep(6000); // Simulate breathing out for 2 seconds
        }
    }
}
