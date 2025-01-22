public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int EndVerse { get; private set; } /*This is optional and not always necessary.*/

     // Constructor for a single verse reference
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = verse; // No range, so end verse is the same as verse
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

        // Method to get the display text of the reference
    public string GetDisplayText()
    {
        if (Verse == EndVerse)
            return $"{Book} {Chapter}:{Verse}";
        else
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
    }
}