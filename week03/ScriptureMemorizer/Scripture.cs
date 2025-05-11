using System;

public class Scripture{

    private Reference _reference;

    private List<Word> _words;

    private Random _random;

    public Scripture(Reference reference, string text){

        _reference = reference;

        _words = text.Split(' ').Select(word => new Word(word)).ToList(); // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

        _random = new Random();
    }

    public string GetDisplayText(){
        string joinedWords = "";

        foreach(Word word in _words){
            if(word._isHidden == false){
                joinedWords = joinedWords + " " + word;
            }
        }

        return joinedWords;
        
    }

    public void HideRandomWords(int count){
        var visibleWords = new List<Word>();

        foreach (var word in _words){
            if (!word.IsHidden()){
                visibleWords.Add(word);
            }

            for (int i = 0; i < count && visibleWords.Count > 0; i++){
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }

        }

    }

}