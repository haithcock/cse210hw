using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private string JournalFile = "MyJournal.txt";

        public List<string> journalEntries = new List<string>();
        private string TitleArt = @"⣿⣿⣿⣿⣿⠟⠋⠄⠄⠄⠄⠄⠄⠄⢁⠈⢻⢿⣿⣿⣿⣿⣿⣿⣿
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
        public void Run()
        {
            Title = "Journal App";

            DisplayIntro();

            //RunMenu();
            var menu = new Menu();
            menu.DisplayMenu(this);

            DisplayOutro();
        }
        /*
                public void RunMenu() //Presents options and allowe user to navigate freely.
                {
                    string choice;
                    do
                    {
                        choice = GetChoice();
                        switch (choice)
                        {
                            case "1":
                                DisplayJournalContents();
                                break;
                            case "2":
                                ClearFile();
                                break;
                            case "3":
                                // Save journal content to a file
                                string journalContent = string.Join("\n", journalEntries);
                                SaveJournalToFile(journalContent);
                                break;
                            case "4":
                                LoadJournalFromFile(); // Call the new method here
                                break;
                            case "5":
                                AddEntry();
                                break;
                        }
                    } while (choice != "6");
                }
                private string GetChoice()
                {
                    bool isChoiceValid = false;
                    string choice = "";

                    do
                    {

                        Clear();
                        ForegroundColor = ConsoleColor.DarkGray;
                        WriteLine(TitleArt);
                        ForegroundColor = ConsoleColor.Black;
                        WriteLine("\nWhat would you like to do?");
                        WriteLine(" > 1 - Read the Journal.");
                        WriteLine(" > 2 - Clear the Journal.");
                        WriteLine(" > 3 - Create a new Journal file.");
                        WriteLine(" > 4 - Load Journal file.");
                        WriteLine(" > 5 - Add to the Journal");
                        WriteLine(" > 6 - Exit the Journal");
                        choice = ReadLine().Trim();

                        if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                        {
                            isChoiceValid = true;

                        }
                        else
                        {
                            WriteLine($"\"{choice}\" is not a valid option. Please Chose 1 - 5");
                            WaitForKey();
                        }
                    } while (!isChoiceValid);
                    return choice;

                }
        */
        public void SaveJournalToFile(string journalContent)
        {
            Console.WriteLine("\nPlease enter the filename (including extension, e.g., 'MyJournal.txt'):");
            string fileName = Console.ReadLine();
            // Validate filename
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid filename. Operation canceled.");
                return;
            }

            // Write the journal content to the specified file
            try
            {
                File.WriteAllText(fileName, journalContent);
                Console.WriteLine($"Journal successfully saved to '{fileName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
            }
        }

        /*     
                        private void CreateJournalFile() //Checks to see if file exists then creates one if it doesn't.
                        {
                            // WriteLine($"Does file exist? {File.Exists("MyJournal.txt")}");

                            if (!File.Exists(JournalFile))
                            {
                                File.CreateText(JournalFile);
                            }
                        }
         */
        private void DisplayIntro()
        {
            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Magenta;
            Clear();
            WriteLine(TitleArt);
            WriteLine(" \n    Greetings Comrade,\n\n  Welcome to the best Journal App you'll ever grade.");
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
            if (journalEntries.Count == 0)
            {
                WriteLine("The journal is empty.");
            }
            else
            {
                WriteLine("\n=== Journal Contents ===");
                foreach (var entry in journalEntries)
                {
                    WriteLine(entry);
                }
                WriteLine("===========================");
            }
            WaitForKey();
        }

        public void ClearFile()
        {
            journalEntries.Clear();
            File.WriteAllText(JournalFile, "");
            WriteLine("Journal Cleared! ");
            WaitForKey();
        }

        public void LoadJournalFromFile()
        {
            Console.WriteLine("\nPlease enter the filename to load (including extension, e.g., 'MyJournal.txt'):");
            string fileName = Console.ReadLine();

            // Validate the filename
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid filename. Operation canceled.");
                return;
            }

            // Try to read the file and load its content
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine($"File '{fileName}' does not exist. Operation canceled.");
                    return;
                }

                // Read all lines from the file
                var fileContent = File.ReadAllLines(fileName);

                // Replace current journal entries with the content from the file
                journalEntries = new List<string>(fileContent);

                Console.WriteLine($"Journal successfully loaded from '{fileName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
            }
        }


        public void AddEntry()
        {
            ForegroundColor = ConsoleColor.Green; //needs to prompt user from a list of writing prompts.
            //WriteLine("\nWhat would you like to add?:   ");
            List<string> prompts = new List<string> { "Are you happy today?", "Did you make someone smile today?", "Did you eat enough food?", "Did you drink enough water?", "Did you get enough sleep?" };

            Random random = new Random();
            string selectedPrompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(selectedPrompt);
            string userResponse = ReadLine();
            string journalEntry = $"\n>{System.DateTime.Now}\nPrompt: {selectedPrompt}\nResponse: {userResponse}\n";
            journalEntries.Add(journalEntry);
            File.AppendAllText(JournalFile, $"\n{journalEntry}\n");
            WriteLine("The Journal has been modified. ");
            WaitForKey();
        }

    }
}
