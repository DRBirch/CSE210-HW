using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ');

        foreach (string wordText in splitWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public string DisplayText()
    {
        string displayText = _reference.DisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.DisplayText() + " ";
        }
        return displayText;
    }
    public void HideWords( int hideNumber)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < hideNumber)
        {
            int randomIndex = random.Next(_words.Count);
            if (_words[randomIndex].Hidden() == false)
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
            if (Hidden())
            {
                break;
            }
        }
    }
    public bool Hidden()
    {
        foreach (Word word in _words)
        {
            if (word.Hidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}