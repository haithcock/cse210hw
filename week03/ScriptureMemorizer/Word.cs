public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    // Constructor
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        IsHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        IsHidden = false;
    }

    // Method to get the display text of the word
    public string GetDisplayText()
    {
        if (IsHidden)
            return new string('_', Text.Length); // Replace each character with an underscore
        else
            return Text;
    }
}
