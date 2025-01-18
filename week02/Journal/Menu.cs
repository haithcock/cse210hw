using System;
using static System.Console;

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
                        string journalContent = string.Join("\n", journal.journalEntries);
                        journal.SaveJournalToFile(journalContent);
                        break;
                    case "4":
                        journal.LoadJournalFromFile();
                        break;
                    case "5":
                        journal.AddEntry();
                        break;
                }
            } while (choice != "6");
        }

        private string GetChoice()
        {
            bool isChoiceValid = false;
            string choice;

            do
            {
                Clear();
                WriteLine("\nWhat would you like to do?");
                WriteLine(" > 1 - Read the Journal.");
                WriteLine(" > 2 - Clear the Journal.");
                WriteLine(" > 3 - Save the Journal to a file.");
                WriteLine(" > 4 - Load Journal from a file.");
                WriteLine(" > 5 - Add to the Journal.");
                WriteLine(" > 6 - Exit.");
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
