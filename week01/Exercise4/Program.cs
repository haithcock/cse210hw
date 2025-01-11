using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<string> shins = new List<string>();
        shins.Add("Seongyong");
        shins.Add("Laurie");
        Console.WriteLine(shins.Count);
        Console.WriteLine($"Once upon a time there were {shins.Count} people");

        foreach (string familymembow in shins)
        {
            Console.WriteLine(familymembow);
        }

        shins.Add("Adam");
        shins.Add("Emma");
        shins.Add("Caleb");
        shins.Add("Jared");
        shins.Add("Laura");

        Console.WriteLine($"But then they got busy and soon their family became a family of {shins.Count}.");

        foreach (string familymembow in shins)
        {
            string familymembow2 = familymembow;
            if (familymembow2 = "Emma")
            {
                Console.WriteLine($"{familymembow} was nice this year.");
            }

            else
            {
                Console.WriteLine($"{familymembow} was naughty this year.");
            }

        }

    }
}