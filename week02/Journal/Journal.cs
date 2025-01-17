using System
using System.Collections.Generic
using System.Linq
using System.Text
using System.Threading.Tasks

namespace JournalApp
{
    public class Journal
    {
        // This starts the journal app to get it running.
        public void Run()
        {
            DisplayIntro();
            // Add your logic here
            DisplayOutro();
        }

        private void CreateJournalFile()
        {
            // Logic for creating a journal file
        }

        private void DisplayIntro()
        {
            Console.WriteLine("Welcome to the Journal App!");
        }

        private void DisplayOutro()
        {
            Console.WriteLine("Thank you for using the Journal App!");
        }

        private void DisplayJournalContents()
        {
            // Logic for displaying journal contents
        }

        private void ClearFile()
        {
            // Logic for clearing the file
        }

        private void AddEntry()
        {
            // Logic for adding an entry
        }
    }
}
