using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity to start:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Activity breathing = new BreathingActivity(30); // 10 seconds for example
                    breathing.StartActivity();
                    breathing.RunActivity();
                    breathing.EndActivity();
                    break;
                case "2":
                    Activity reflection = new ReflectionActivity(60); // 60 seconds for example
                    reflection.StartActivity();
                    reflection.RunActivity();
                    reflection.EndActivity();
                    break;
                case "3":
                    Activity listing = new ListingActivity(45); // 45 seconds for example
                    listing.StartActivity();
                    listing.RunActivity();
                    listing.EndActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
