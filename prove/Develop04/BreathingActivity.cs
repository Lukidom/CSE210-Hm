using System;
using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        
    }
    public BreathingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }

    int _timeDuration;

    public void GetDuration(int timeDuration)
    {

        _timeDuration = timeDuration; 
    }

    
    public void DisplayBreathingMessage()
    {
        
        while (_timeDuration < _duration)
        {            
            Console.Write("breathe in..");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write("breathe out..");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            _timeDuration++;

        }
    }
    
}
