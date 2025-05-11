using System;

public class Reference{

    public string _book;

    public int _chapter;

    public int _verse;

    public int? _endVerse; //https://stackoverflow.com/questions/6967700/why-int-cant-be-null-how-does-nullable-int-int-work-in-c


    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){

        if (_endVerse == null){
        return $"{_book} {_chapter}:{_verse}";
        }

        else{
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

}