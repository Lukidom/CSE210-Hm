using System;

public class ReflectionActivity : Activity
{
    List<string> prompts = ["think of when you had a defineing moment", "Think of a time when you did something difficult", "think of when you have helped someone in need"];
    // string list prompts list<string> 

    public ReflectionActivity() : base()
    {

    }
    public ReflectionActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }
   

    public void DisplayPrompts()
    {
        foreach (var prompt in prompts)
        {
            Console.WriteLine(prompt);
        }
    }
    
}