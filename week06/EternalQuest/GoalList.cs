using System;
using System.Collections.Generic;
using JournalApp;

namespace GoalApp
{
    public class GoalEntry
    {
        private static List<string> _prompts = new List<string>
        {
            "\nWhat needs to get done today? (50 points per completion)\n",
            "\nWhat needs hours for progress today? Enter a name and hours to commit (100 points/hour, max 2 hours):\n",
            "Eating food: Enter calories consumed (50 points for 500-550, -5 if over 550):",
            "Enter target water intake (50 points for meeting it):",
            "Did you sleep 8 hours? (200 points):"
        };

        public static (string entry, TaskBase task) CreateNewEntry()
        {
            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            string selectedPrompt = _prompts[promptIndex];
            Console.WriteLine(selectedPrompt);

            TaskBase task = null;
            int points = 0;
            string description = "";
            string userResponse = "";

            switch (promptIndex)
            {
                case 0: // General task (50 points)
                    Console.Write("Enter task: ");
                    userResponse = Console.ReadLine().Trim();
                    points = 50;
                    description = userResponse;
                    break;

                case 1: // Hours (100/hour, max 2)
                    double hours;
                    do
                    {
                        Console.Write("Hours (1-2): ");
                    } while (!double.TryParse(Console.ReadLine(), out hours) || hours <= 0);
                    hours = Math.Min(hours, 2);
                    points = (int)(hours * 100);
                    description = $"{hours} hours committed";
                    break;

                case 2: // Calories
                    int calories;
                    do
                    {
                        Console.Write("Calories consumed: ");
                    } while (!int.TryParse(Console.ReadLine(), out calories));
                    points = (calories >= 500 && calories <= 550) ? 50 : (calories > 550) ? -5 : 0;
                    description = $"Ate {calories} calories";
                    break;

                case 3: // Water
                    Console.Write("Target water intake: ");
                    userResponse = Console.ReadLine().Trim();
                    points = 50; // Awarded when completed
                    description = $"Drink {userResponse}";
                    break;

                case 4: // Sleep
                    points = 200;
                    description = "Slept 8 hours";
                    break;
            }

            task = new DailyTask(description, points);
            string entry = $"\n>{DateTime.Now}\nPrompt: {selectedPrompt}\nResponse: {userResponse}\n";
            return (entry, task);
        }
    }
}