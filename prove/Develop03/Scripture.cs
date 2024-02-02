using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string str in text.Split())
        {
            Word entry = new Word(str);
           _words.Add(entry);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int numWords = numberToHide;
        Random rand = new Random();
        while (numWords > 0)
        {
            int remove = rand.Next(0, _words.Count());
            Word entry = _words[remove];
            if (entry.IsHidden() == false)
            {
                entry.Hide();
                numWords--;
            }
            if (IsCompletelyHidden() == true)
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            scripture += $"{word.GetDisplayText()} ";
        }
        return scripture;
    }
    public bool IsCompletelyHidden()
    {
        bool isHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                isHidden = false;
                break;
            }
        }
        return isHidden;
    }
}