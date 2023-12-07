using System;

public class ListingActivity : Activity

// listing activity. User is given a promt and makes list of things. things one is grateful for etc..
{
    protected string _userResponse;

    protected int _timeDuration;

    public ListingActivity() : base()
    {
        
    }
    public ListingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }
    
    public void GetDuration(int timeDuration)
    {
        _timeDuration = timeDuration;
    }

    // Base part again

    // Displays prompt for listing exercise 
    public void DisplayPrompt()
    {
        string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

        Random random = new Random();
        for (int i = 0; i < prompts.Length; i++)
        {
            int indexToPrint = random.Next(0, prompts.Length);
            Console.WriteLine(indexToPrint);
            break;
        }
        
    }

    public void DisplayResult()
    {
        List<string>  inputs = new List<string>();
        Console.WriteLine("please write your response to the prompt: ");
        while (_timeDuration < _duration)
        {
        Console.Write(">< ");
        _userResponse = Console.ReadLine();
        inputs.Add(_userResponse);
        _timeDuration++;
        }
        Console.WriteLine($"==> {inputs}");

    }
    // public string UserInputAndOutput()
    // {
    //     userResponse = Console.ReadLine();
        
    //     return " ";
    // }
}