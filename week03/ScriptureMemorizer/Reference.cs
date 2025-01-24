public class Reference
{
    private string Book { get; set; }
    private int Chapter { get; set; }
    private int Verse { get; set; }
    private int EndVerse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (Verse == EndVerse)
            return $"{Book} {Chapter}:{Verse}";
        else
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
    }

    public string GetBook() { return Book; }
    public int GetChapter() { return Chapter; }
    public int GetVerse() { return Verse; }
    public int GetEndVerse() { return EndVerse; }
}

