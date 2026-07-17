using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordStrings = text.Split(' ');
        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(_reference.GetDisplayText());

        foreach (Word word in _words)
        {
            sb.Append(word.GetDisplayText() + " ");
        }

        return sb.ToString();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}