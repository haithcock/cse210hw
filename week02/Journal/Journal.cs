using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JournalApp
{
    public class Journal
    {
        public void Run()
        {
            DisplayIntro();
            // To do: Rest of the program
            DisplayOutro();
        }
        private void CreateJournalFile() { }

        private void DisplayIntro()
        {
            WriteLine("Thanks for using the journal!");
            ReadKey(true);
        }

        private void DisplayOutro()
        {
            WriteLine("Journal App.");
            ReadKey(true);
        }

        private void DisplayJournalContents() { }

        private void ClearFile() { }

        private void AddEntry() { }

    }
}
