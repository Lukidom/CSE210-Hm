using System;

using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Word
{
    private string _word;

    private bool hidden;

    public Word(string word)
    {
        this. _word = word;
    }
    public void Hide()
    {
        this.hidden = true;
    }
    public string GetWord()
    {
        {
        if (hidden == true)
            return "____";
        }
        return this._word;
    }
}
