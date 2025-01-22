using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    // Constructor
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to hide a specified number of words randomly
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

    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        return $"{Reference.GetDisplayText()} {string.Join(" ", Words.Select(w => w.GetDisplayText()))}";
    }

    // Method to check if all words are completely hidden
    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}

/*
getters and setters need to be 
private string book

private string book; --- all member variables need to be 

~later~

public string GetBook()
{
    return chapter;
}




*/