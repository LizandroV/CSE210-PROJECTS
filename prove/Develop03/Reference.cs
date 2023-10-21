internal class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = "";
        _verse = "";
        _endVerse = "";
    }

    public Reference(string Book, string Chapter, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = "";
    }

    public Reference(string Book, string Chapter, string Verse, string EndVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = EndVerse;
    }

    public string DisplayReference()
    {
        if (_endVerse == "")
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
            
    }


}