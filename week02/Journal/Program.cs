using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.Run();
        }
    }
}

/* public static void WriteAllText (string path, string? contents); 
- this creates a new file,
writes the specified string to a file,
then finally closes the file. 
If the target file already exists then it is over written */