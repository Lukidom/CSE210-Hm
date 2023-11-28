using System;

using System.Dynamic;

// Math classes with inherited base class
class Math : Base
{
    private string _textBookSection;

    private string _problems;

    public Math()
    {
        
    }

    public string GetHomeWork(string Section, string problemsGiven)
    {
        _textBookSection = Section;
        _problems = problemsGiven;

        return $"{_textBookSection} - {problemsGiven}";
    }
}