using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example scripture and reference
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

            Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());  // Show the scripture with or without hidden words
                string input = Console.ReadLine();  // Wait for user input

                if (input.ToLower() == "quit")  // Check if the user wants to quit
                    break;

                scripture.HideRandomWords(1);  // Hide one random word
                Console.Clear();  // Clear the console screen for clean output
            }

            Console.WriteLine("Final scripture with all words hidden:");
            Console.WriteLine(scripture.GetDisplayText());  // Show the final hidden scripture
        }

    }
}
