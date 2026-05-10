using System;

class Word
{
    private string _text;
    private bool _hidden;
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public bool Hidden()
    {
        return _hidden;
    }
    public string DisplayText()
    {
        if (_hidden)
        {
            string hiddenWord = "";
            for (int i=0; i < _text.Length; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}