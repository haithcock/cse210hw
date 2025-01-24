using System;
using System.Collections.Generic;
using System.Linq;
public class Scripture
{
    private Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return $"{GetReferenceText()} {string.Join(" ", Words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    // Helper method to get the display text of the reference
    public string GetReferenceText()
    {
        return Reference.GetDisplayText();
    }

    // Method to retrieve the count of words, if needed
    public int GetWordCount()
    {
        return Words.Count;
    }

    // Method to expose words for external functionalities that require specific word manipulation
    public IEnumerable<string> GetWordDisplayTexts()
    {
        return Words.Select(w => w.GetDisplayText());
    }
}
