using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string text;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        text = $"{_book} {_chapter}:{_verse}";
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    public string GetDisplayText()
    {
        return text;
    }
}