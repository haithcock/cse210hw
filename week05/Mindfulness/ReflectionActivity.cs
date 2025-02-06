using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration)
        : base("Reflection", duration)
    {
    }

    public override void RunActivity()
    {
        Random rand = new Random();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        
        // Display a random prompt
        int promptIndex = rand.Next(prompts.Count);
        Console.WriteLine(prompts[promptIndex]);

        // Display questions related to the experience
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            int questionIndex = rand.Next(questions.Count);
            Console.WriteLine(questions[questionIndex]);
            ShowSpinner(3); // Show spinner for 3 seconds
        }
    }

    private void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration * 10; i++)
        {
            Thread.Sleep(1000);
            Console.Write("\b/");
            Thread.Sleep(1000);
            Console.Write("\b-");
            Thread.Sleep(1000);
            Console.Write("\b\\");
            Thread.Sleep(1000);
            Console.Write("\b|");
        }
        Console.WriteLine("\b "); 
    }
}
