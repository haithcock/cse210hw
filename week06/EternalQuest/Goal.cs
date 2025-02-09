using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using GoalApp;

namespace JournalApp
{
    public class Journal
    {
        private string _journalFile = "MyJournal.txt";

        public List<string> _journalEntries = new List<string>();
        private string _titleArt = @"⣿⣿⣿⣿⣿⠟⠋⠄⠄⠄⠄⠄⠄⠄⢁⠈⢻⢿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⠃⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⡀⠭⢿⣿⣿⣿⣿
⣿⣿⣿⣿⡟⠄⢀⣾⣿⣿⣿⣷⣶⣿⣷⣶⣶⡆⠄⠄⠄⣿⣿⣿⣿
⣿⣿⣿⣿⡇⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠄⠄⢸⣿⣿⣿⣿
⣿⣿⣿⣿⣇⣼⣿⣿⠿⠶⠙⣿⡟⠡⣴⣿⣽⣿⣧⠄⢸⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣾⣿⣿⣟⣭⣾⣿⣷⣶⣶⣴⣶⣿⣿⢄⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⡟⣩⣿⣿⣿⡏⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣹⡋⠘⠷⣦⣀⣠⡶⠁⠈⠁⠄⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣍⠃⣴⣶⡔⠒⠄⣠⢀⠄⠄⠄⡨⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣦⡘⠿⣷⣿⠿⠟⠃⠄⠄⣠⡇⠈⠻⣿⣿⣿⣿
⣿⣿⣿⣿⡿⠟⠋⢁⣷⣠⠄⠄⠄⠄⣀⣠⣾⡟⠄⠄⠄⠄⠉⠙⠻
⡿⠟⠋⠁⠄⠄⠄⢸⣿⣿⡯⢓⣴⣾⣿⣿⡟⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⣿⡟⣷⠄⠹⣿⣿⣿⡿⠁⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⣸⣿⡷⡇⠄⣴⣾⣿⣿⠃⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⣿⣿⠃⣦⣄⣿⣿⣿⠇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⢸⣿⠗⢈⡶⣷⣿⣿⡏⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄";
        public GoalsMain Goals { get; } = new GoalsMain(); 
        public void Run()
        {
            Title = "Journal App";

            DisplayIntro();


            var menu = new Menu();
            menu.DisplayMenu(this);

            DisplayOutro();
        }

        public void SaveJournalToFile(string journalContent)
        {
            Console.WriteLine("\nPlease enter the filename (including extension, e.g., 'MyGoals.txt'):");
            string fileName = Console.ReadLine();
            // Validate filename
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid filename. Operation canceled.");
                return;
            }


            try
            {
                File.WriteAllText(fileName, journalContent);
                Console.WriteLine($"Goal list successfully saved to '{fileName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the list of Goals: {ex.Message}");
            }
        }

        private void DisplayIntro()
        {
            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Magenta;
            Clear();
            WriteLine(_titleArt);
            WriteLine(" \n    Greetings Comrade,\n\n  Welcome to the best Goal-list App you'll ever grade.");
            WaitForKey();
        }

        private void DisplayOutro()
        {
            WriteLine("\nArt from: https://www.twitchquotes.com/copypastas/3553");
            WriteLine("     谢谢 Comrade!\n Thank you for good grade! \n 500+ Social Credit Points to you ");
            ReadKey(true);
        }
        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress any key...");
            ReadKey(true);
        }


        public void DisplayJournalContents()
        {
            if (_journalEntries.Count == 0)
            {
                WriteLine("The journal is empty.");
            }
            else
            {
                WriteLine("\n=== Journal Contents ===");
                foreach (var entry in _journalEntries)
                {
                    WriteLine(entry);
                }
                WriteLine("===========================");
            }
            WaitForKey();
        }

        public void ClearFile()
        {
            _journalEntries.Clear();
            File.WriteAllText(_journalFile, "");
            WriteLine("goal list Cleared! ");
            WaitForKey();
        }

        public void LoadJournalFromFile()
        {
            Console.WriteLine("\nPlease enter the filename to load (including extension, e.g., 'MyGoals.txt'):");
            string fileName = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid filename. Operation canceled.");
                return;
            }

            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine($"File '{fileName}' does not exist. Operation canceled.");
                    return;
                }

 
                var fileContent = File.ReadAllLines(fileName);

               
                _journalEntries = new List<string>(fileContent);

                Console.WriteLine($"Goal-list successfully loaded from '{fileName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the Goal-list: {ex.Message}");
            }
        }

        public void CompleteTask()
        {
            if (Goals.tasks.Count == 0)
            {
                WriteLine("No goals to complete.");
                WaitForKey();
                return;
            }

            WriteLine("Current Goals:");
            Goals.DisplayTasks();
            Write("Enter goal number to complete: ");
            if (int.TryParse(ReadLine(), out int index) && index > 0 && index <= Goals.tasks.Count)
                {
                    Goals.CompleteTask(index - 1); // Convert to 0-based index
                    WriteLine("Goal completed!");
                }
                else
                {
                    WriteLine("Invalid input.");
                }
                WaitForKey();
        }
            public void AddEntry()
            {
                bool keepAdding = true;
                while (keepAdding)
                {
                    // Generate a new prompt and task each iteration
                    var (newEntry, newTask) = GoalEntry.CreateNewEntry();
                    _journalEntries.Add(newEntry);
                    File.AppendAllText(_journalFile, newEntry);
                    Goals.AddTask(newTask);
            
                    Console.Write("\nAdd another goal? (Y/N): ");
                    string response = Console.ReadLine()?.Trim().ToUpper();
                    keepAdding = (response == "Y");
                }
                Console.WriteLine("\nYour goals have been updated.");
                WaitForKey();
            }

        }



  
            public class DailyTask : TaskBase
        {
        public DailyTask(string description, int points) : base(description, points)
        {
        }
    
        public override void Complete()
        {
            base.Complete();
            // Additional logic specific to daily tasks if needed
        }
    
        public override string Display()
        {
            return base.Display() + " (Daily Task)";
        }
    }
}
