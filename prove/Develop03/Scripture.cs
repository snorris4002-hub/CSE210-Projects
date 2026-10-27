using System;

using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] individualWords = text.Split(' ');

        foreach (string word in individualWords)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hidden = 0;

        while (hidden < numberToHide)
        {
            int number = random.Next(0, _words.Count);

            if (!_words[number].IsHidden())
            {
                _words[number].Hide();
                hidden++;
            }
        }
    }
}