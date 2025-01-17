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
            CreateJournalFile();
            AddEntry();
            DisplayJournalContents();
            //ClearFile();
            DisplayJournalContents();

            DisplayOutro();
        }

        private void CreateJournalFile() //Checks to see if file exists then creates one if it doesn't.
        {
            // WriteLine($"Does file exist? {File.Exists("MyJournal.txt")}");

            if (!File.Exists(JournalFile))
            {
                File.CreateText(JournalFile);
            }
        }

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

        private void DisplayJournalContents()
        {
            string journalText = File.ReadAllText(JournalFile);
            WriteLine("\n=== Journal Contents ===");
            WriteLine(journalText);
            WriteLine("\n=== Journal Contents ===");
            WriteLine("===========================");
            WaitForKey();
        }

        private void ClearFile()
        {
            File.WriteAllText(JournalFile, "");
            WriteLine("Journal Cleared! ");
            WaitForKey();
        }

        private void AddEntry()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\nWhat would you like to add?:   ");
            string newLine = ReadLine();
            File.AppendAllText(JournalFile, $"\nEntry:{System.DateTime.Now}\n> {newLine}\n");
            WriteLine("The Journal has been modified. ");
            WaitForKey();
        }

    }
}
