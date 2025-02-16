using System;
using static System.Console;
using JournalApp;
using GoalApp;

namespace JournalApp
{
    public class Menu
    {
        public void DisplayMenu(Journal journal)
        {
            string choice;
            do
            {
                choice = GetChoice();
                switch (choice)
                {
                    case "1":
                        journal.DisplayJournalContents();
                        break;
                    case "2":
                        journal.ClearFile();
                        break;
                    case "3":
                        string journalContent = string.Join("\n", journal._journalEntries);
                        journal.SaveJournalToFile(journalContent);
                        break;
                    case "4":
                        journal.LoadJournalFromFile();
                        break;
                    case "5":
                        journal.AddEntry();
                        break;
                    case "6":
                        journal.CompleteTask();
                        break;
                }
            } while (choice != "7");
        }

        private string GetChoice()
        {
            bool isChoiceValid = false;
            string choice;

            do
            {
                Clear();
                WriteLine("\nWhat would you like to do?");
                WriteLine(" > 1 - Read your Goals.");
                WriteLine(" > 2 - Clear your Goals.");
                WriteLine(" > 3 - Save your Goals to a file.");
                WriteLine(" > 4 - Load Goals from a file.");
                WriteLine(" > 5 - Add to your Goals.");
                WriteLine(" > 6 - Complete a Goal.");
                WriteLine(" > 7 - Exit.");
                choice = ReadLine()?.Trim();

                if (choice is "1" or "2" or "3" or "4" or "5" or "6")
                {
                    isChoiceValid = true;
                }
                else
                {
                    WriteLine($"\"{choice}\" is not a valid option. Please choose 1 - 6.");
                    WriteLine("Press any key to continue...");
                    ReadKey();
                }
            } while (!isChoiceValid);

            return choice;
        }
    }
}
