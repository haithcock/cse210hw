using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class JournalEntry
    {
        private static List<string> _prompts = new List<string>
        {
            "Are you happy today?",
            "Did you make someone smile today?",
            "Did you eat enough food?",
            "Did you drink enough water?",
            "Did you get enough sleep?"
        };

        public static string CreateNewEntry()
        {
            Random random = new Random();
            string selectedPrompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(selectedPrompt);

            string userResponse = Console.ReadLine();
            return $"\n>{DateTime.Now}\nPrompt: {selectedPrompt}\nResponse: {userResponse}\n";
        }
    }
}
