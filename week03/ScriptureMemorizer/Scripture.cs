using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitwords = text.Split(" ");
        foreach (string item in splitwords)
        {
            _words.Add(new Word(item));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHiddend())
            {
                _words[index].Hide();
                wordsHidden++;
            }
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word item in _words)
        {
            verseText += item.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} \n{verseText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word item in _words)
        {
            if (!item.IsHiddend())
            {
                return false;
            }
        }
        return true;
    }
}